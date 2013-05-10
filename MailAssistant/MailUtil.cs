using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Net.Mime;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MailAssistant
{
    class MailUtil
    {

        public static MailAssistemt jobMail = null;
        public static ArrayList recList = null;

        public static bool SendMail(MailAssistemt mail, string receiver) 
        {
            try
            {
                //创建smtpclient对象
                SmtpClient client = new SmtpClient();
                client.Host = mail.SmtpName;
                client.Timeout = 30000;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(mail.MailFromAddress, mail.MailPassword);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;

                //创建mailMessage对象 
                MailMessage message = new MailMessage(mail.MailFromAddress,receiver);
                message.Subject = mail.Subject;
                //正文默认格式为html
                message.Body = mail.MailContent;
                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;

                //添加附件
                if (mail.AttPathList.Count != 0)
                {
                  foreach (string path in mail.AttPathList)
                  {
                        Attachment data = new Attachment(path, MediaTypeNames.Application.Octet);
                        message.Attachments.Add(data);
                    }
                }
                client.Send(message);             
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 读取邮件信息
        /// </summary>
        /// <returns></returns>
        public static MailAssistemt GetMailAssistemt()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("mails/MailAss.ser", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                return (MailAssistemt)bf.Deserialize(fs);
            }
            catch
            {
                return null;
            }
            finally { 
                if(fs!=null)
                {
                    fs.Close();
                }            
            }
        }

        /// <summary>
        /// 保存邮件信息
        /// </summary>
        /// <param name="mailAss"></param>
        public static void SaveMailAssistemt(MailAssistemt mailAss)
        {
            FileStream fs = null;
            try
            {
                fs= new FileStream("mails/MailAss.ser", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, mailAss);
            }
            catch
            {
                return;
            }
            finally { 
                if(fs!=null)
                {
                    fs.Close();
                }
                
            }
        }

    }
}
