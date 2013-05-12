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
            try
            {
                if (!checkMail()) 
                {
                    MessageBox.Show("请输入相关的邮件信息！");
                    return;
                }
                bool isSent = true;
                this.btnSendMail.Enabled = false;
                this.btnTimeSend.Enabled = false;
                foreach (DataGridViewRow dvr in dgvMailList.Rows)
                {
                    if (dvr.Cells[0].Value != null)
                    {
                        isSent = MailUtil.SendMail(bindMailInfo(), dvr.Cells[0].Value.ToString());
                        if (!isSent) {
                            MessageBox.Show("邮件发送失败！请检查输入的值是否正确。");
                            return;
                        }
                    }
                }
                MessageBox.Show("邮件发送成功！");
            }
            catch
            {
                MessageBox.Show("邮件发送失败！请检查输入的值是否正确。");

            }
            finally {

                this.btnSendMail.Enabled = true;
                this.btnTimeSend.Enabled = true;            
            }
        }

        private bool checkMail() 
        {
            bool isPassed = true;
            if (this.cmbSmtpName.Text.Trim().Equals(""))
            {
                isPassed = false;
            }
            else if (this.cmbSMTP.Text.Trim().Equals(""))
            {
                isPassed = false;
            }
            else if (this.txtFrom.Text.Trim().Equals(""))
            {
                isPassed = false;
            }
            else if (this.cmbFrom.Text.Trim().Equals(""))
            {
                isPassed = false;
            }
            else if (this.txtPsw.Text.Trim().Equals(""))
            {
                isPassed = false;
            }
            else if (this.dgvMailList.RowCount<=1)
            {
                isPassed = false;
            }


            return isPassed;
        }

        private MailAssistemt bindMailInfo() 
        {
            MailAssistemt mail = new MailAssistemt();
            mail.SmtpName = "SMTP."+this.cmbSmtpName.Text.Trim()+this.cmbSMTP.Text;
            mail.Port = this.muPort.Value.ToString();
            mail.MailFromAddress = this.txtFrom.Text + this.cmbFrom.Text;
            mail.MailPassword = this.txtPsw.Text;
            mail.AttPathList = this.pathList;
            mail.Subject = this.txtTitle.Text;
            mail.MailContent = this.rTxtContent.Text;

            return mail;
        }
        
        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimeSend_Click(object sender, EventArgs e)
        {
            if (!checkMail())
            {
                MessageBox.Show("请输入相关的邮件信息！");
                return;
            }
            initMailJob();
            this.btnTimeSend.Enabled = false;
            this.btnStopSend.Enabled = true;
        }


        private void btnStopSend_Click(object sender, EventArgs e)
        {
            sched.Shutdown();
            this.btnStopSend.Enabled = false;
            this.btnTimeSend.Enabled = true;
        }

        IScheduler sched;
        private void initMailJob() 
        {
            log.Info("------- Initializing ----------------------");
            MailUtil.jobMail = bindMailInfo();
            ArrayList recList = new ArrayList();
            foreach (DataGridViewRow dvr in dgvMailList.Rows)
            {
                if (dvr.Cells[0].Value != null)
                {
                    recList.Add(dvr.Cells[0].Value.ToString());
                }
            }
            MailUtil.recList = recList;
            int timeInter = int.Parse(this.txtTimeInter.Text);

            // First we must get a reference to a scheduler
            ISchedulerFactory sf = new StdSchedulerFactory();
            sched = sf.GetScheduler();

            log.Info("------- Initialization Complete -----------");

            DateTime startTime = new DateTime(int.Parse(this.txtYear.Text), 
                int.Parse(this.txtMonth.Text),int.Parse(this.txtDay.Text),
                int.Parse(this.txtHour.Text),int.Parse(this.txtMonth.Text),int.Parse(this.txtSec.Text));
            
            log.Info("------- Scheduling Job  -------------------");

            // define the job and tie it to our HelloJob class
            IJobDetail mailJob = JobBuilder.Create<MailSendJob>()
                .WithIdentity("MailSendJob", "MailSendGroup")
                .Build();

            ITrigger mailTrigger = null;
            if(this.cmbTimeType.Text.Equals("分钟"))
            {
                mailTrigger = (ISimpleTrigger)TriggerBuilder.Create()
                                           .WithIdentity("MailSendTrigger", "MailSendGroup")
                                           .StartAt(startTime)
                                           .WithSimpleSchedule(x => x.WithIntervalInMinutes(timeInter).RepeatForever())
                                           .Build();
            }
            else if (this.cmbTimeType.Text.Equals("小时"))
            {
                mailTrigger = (ISimpleTrigger)TriggerBuilder.Create()
                                           .WithIdentity("MailSendTrigger", "MailSendGroup")
                                           .StartAt(startTime)
                                           .WithSimpleSchedule(x => x.WithIntervalInHours(timeInter).RepeatForever())
                                           .Build();
            }else{
                mailTrigger = (ISimpleTrigger)TriggerBuilder.Create()
                                               .WithIdentity("MailSendTrigger", "MailSendGroup")
                                               .StartAt(startTime)
                                               .WithSimpleSchedule(x => x.WithIntervalInSeconds(timeInter).RepeatForever())
                                               .Build();       
            }            

            // Tell quartz to schedule the job using our trigger
            sched.ScheduleJob(mailJob, mailTrigger);

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

            MailAssistemt objMA = MailUtil.GetMailAssistemt();
            if (objMA!=null)
            {
                this.cmbFrom.Text = objMA.MailFromType;
                this.txtFrom.Text = objMA.MailFromAddress;
                this.txtPsw.Text = objMA.MailPassword;
                this.chkSaveFrom.Checked = objMA.IsCheckedFrom;
            }

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
            if (this.chkSaveFrom.Checked)
            {
                MailAssistemt objMA = new MailAssistemt();
                objMA.MailFromType = this.cmbFrom.Text;
                objMA.MailFromAddress = this.txtFrom.Text;
                objMA.MailPassword = this.txtPsw.Text;
                objMA.IsCheckedFrom = true;
                MailUtil.SaveMailAssistemt(objMA);
            }
            
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

        private void txtMonth_Leave(object sender, EventArgs e)
        {
            if (this.txtMonth.Text.Trim().Equals(""))
            {
                this.txtMonth.Text = DateTime.Now.Month.ToString();
                return;
            }
            int mon = int.Parse(this.txtMonth.Text);
            if (mon > 12 || mon<1)
            {
                MessageBox.Show("请输入正确的月份！");
                this.txtMonth.Text = DateTime.Now.Month.ToString();
            }
        }

        private void txtTimeInter_Leave(object sender, EventArgs e)
        {

        }

        private void txtDay_Leave(object sender, EventArgs e)
        {
            if (this.txtDay.Text.Trim().Equals(""))
            {
                this.txtDay.Text = DateTime.Now.Day.ToString();
                return;
            }
            int day = int.Parse(this.txtDay.Text);
            if (day > 31 || day < 1)
            {
                MessageBox.Show("请输入正确的天数！");
                this.txtDay.Text = DateTime.Now.Day.ToString();
                return;
            }
            try
            {
                DateTime dtValid = DateTime.Parse(this.txtYear.Text+"-"+this.txtMonth.Text+"-"+this.txtDay.Text);
            }
            catch {

                MessageBox.Show("请输入正确的天数！");
                this.txtMonth.Text = DateTime.Now.Month.ToString();
                this.txtDay.Text = DateTime.Now.Day.ToString();
                return;
            }
        }

        private void txtHour_Leave(object sender, EventArgs e)
        {
            if (this.txtHour.Text.Trim().Equals(""))
            {
                this.txtHour.Text = DateTime.Now.Hour.ToString();
                return;
            }
            int hour = int.Parse(this.txtHour.Text);
            if (hour > 23)
            {
                MessageBox.Show("请输入正确的小时数！");
                this.txtHour.Text = DateTime.Now.Hour.ToString();
                return;
            }
        }

        private void txtMin_Leave(object sender, EventArgs e)
        {
            if (this.txtMin.Text.Trim().Equals(""))
            {
                this.txtMin.Text = DateTime.Now.Minute.ToString();
                return;
            }
            int min = int.Parse(this.txtMin.Text);
            if (min > 59)
            {
                MessageBox.Show("请输入正确的分钟数！");
                this.txtMin.Text = DateTime.Now.Minute.ToString();
                return;
            }
        }

        private void cmsItemRemove_Click(object sender, EventArgs e)
        {
            btnDel_Click(sender,e);
        }

        private void rTxtContent_DoubleClick(object sender, EventArgs e)
        {
            frmBodyEditor.htmlBody = this.rTxtContent.Text;
            frmBodyEditor objBodyEditor = new frmBodyEditor();
            objBodyEditor.ShowDialog();
            this.rTxtContent.Text = frmBodyEditor.htmlBody;
        }
    }
}
