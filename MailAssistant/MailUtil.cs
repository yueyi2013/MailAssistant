using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Net.Mime;

namespace MailAssistant
{
    class MailUtil
    {

        public static MailAssistemt jobMail = null;
        public static ArrayList recList = null;

        public static bool SendMail(MailAssistemt mail, string receiver) 
        {
            //创建smtpclient对象
            SmtpClient client = new SmtpClient();
            client.Host = mail.SmtpName;
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

            try
            {
                client.Send(message);             
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}
