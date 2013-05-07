using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
using System.Configuration;
using Common.Logging;
using System.Threading;
using Quartz;
using Quartz.Impl;
using Quartz.Examples.Example1;

namespace MailAssistant
{
    public partial class frmMail : Form
    {
        ILog log = LogManager.GetLogger(typeof(frmMail));

        public frmMail()
        {
            InitializeComponent();
        }
        public ArrayList pathList = new ArrayList();//保存附件地址

        private void btBrowse_Click(object sender, EventArgs e)
        {

            openFileAttach.Filter = "所有文件(*.*)|*.*";
            if (openFileAttach.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileAttach.FileNames;
                foreach (string file in files)
                {
                    pathList.Add(file);
                    this.txtBrowse.Text += Path.GetFileName(file) + ";";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBrowse.Text = string.Empty;
            pathList.Clear();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailUtil mailUtil = new MailUtil();
            foreach (DataGridViewRow dvr in dgvMailList.Rows)
            {
                if (dvr.Cells[0].Value!=null)
                {
                    mailUtil.SendMail(bindMailInfo(), dvr.Cells[0].Value.ToString());
                }
            }
        }

        private MailAssistemt bindMailInfo() 
        {
            MailAssistemt mail = new MailAssistemt();
            mail.SmtpName = "SMTP."+this.txtSMTP.Text.Trim()+this.cmbSMTP.Text;
            mail.Port = this.cmbSMTP.SelectedText;
            mail.MailFromAddress = this.txtFrom.Text + this.cmbFrom.Text;
            mail.MailPassword = this.txtPsw.Text;
            mail.AttPathList = this.pathList;
            mail.Subject = this.txtTitle.Text;
            mail.MailContent = this.rTxtContent.Text;

            return mail;
        }

        private void initMailJob() 
        {
            log.Info("------- Initializing ----------------------");
            // First we must get a reference to a scheduler
            ISchedulerFactory sf = new StdSchedulerFactory();
            IScheduler sched = sf.GetScheduler();

            log.Info("------- Initialization Complete -----------");
            // computer a time that is on the next round minute
            DateTimeOffset runTime = DateBuilder.EvenMinuteDate(DateTimeOffset.UtcNow);
            log.Info("------- Scheduling Job  -------------------");

            // define the job and tie it to our HelloJob class
            IJobDetail job = JobBuilder.Create<HelloJob>()
                .WithIdentity("job1", "group1")
                .Build();

            // Trigger the job to run on the next round minute
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .StartAt(runTime)
                .Build();

            // Tell quartz to schedule the job using our trigger
            sched.ScheduleJob(job, trigger);
            log.Info(string.Format("{0} will run at: {1}", job.Key, runTime.ToString("r")));

            // Start up the scheduler (nothing can actually run until the 
            // scheduler has been started)
            sched.Start();
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            ArrayList mailList = readMailAddress();
            foreach (string address in mailList)
            {
                string[] str = address.Split(',');
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(this.dgvMailList);
                dr.Cells[0].Value = str[0];
                dr.Cells[1].Value = str[1];
                dgvMailList.Rows.Add(dr);
            }
            DateTime dt = DateTime.Now;
            this.txtYear.Text = dt.Year.ToString();
            this.txtMonth.Text = dt.Month.ToString();
            this.txtDay.Text = dt.Day.ToString();
            this.txtHour.Text = dt.Hour.ToString();
            this.txtMin.Text = dt.Minute.ToString();
        }



        private void frmMail_FormClosed(object sender, FormClosedEventArgs e)
        {
            ArrayList mailList = new ArrayList();
            foreach (DataGridViewRow dvr in dgvMailList.Rows)
            {
                string line = dvr.Cells[0].Value+","+dvr.Cells[1].Value;
                mailList.Add(line);
            }
            saveReceivers(mailList);
        }

        /// <summary>
        /// 保存邮件地址
        /// </summary>
        /// <param name="value"></param>
        private void saveReceivers(ArrayList mailList) 
        {
            using (FileStream fs = new FileStream("mails\\address.mail", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs);
                try
                {
                    foreach(string value in mailList)
                    {
                        if (!value.Trim().Equals(",")) {
                            //开始写入
                            sw.WriteLine(value);                        
                        }
                    }
                }
                catch
                {
                    log.Error("保存邮件地址失败.");
                }
                finally {
                    //清空缓冲区
                    sw.Flush();
                    //关闭流
                    sw.Close();
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// 读取邮件地址
        /// </summary>
        /// <returns></returns>
        private ArrayList readMailAddress() 
        {
            using (StreamReader objReader = new StreamReader("mails\\address.mail")) 
            {
                ArrayList mailList = new ArrayList();
                string sLine = "";
                try
                {
                    while (sLine != null)
                    {
                        sLine = objReader.ReadLine();
                        if (sLine != null && !sLine.Equals(""))
                            mailList.Add(sLine);
                    }
                }
                catch
                {
                    log.Error("读取邮件地址失败.");
                }
                finally {
                    objReader.Close();
                }
                return mailList;
            }            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string line = this.txtRecAddr
                .Text.Trim()+this.cmbAt.Text;
            DataGridViewRow dr = new DataGridViewRow();
            dr.CreateCells(this.dgvMailList);
            dr.Cells[0].Value = line;
            dr.Cells[1].Value = "";
            dgvMailList.Rows.Add(dr);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dr in dgvMailList.SelectedRows)
            {
                if (dr.IsNewRow)
                    continue;
                dgvMailList.Rows.Remove(dr);
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox非数字.和退格不响应，8是退格键
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == 8))
                e.Handled = true;
        }
    }
}
