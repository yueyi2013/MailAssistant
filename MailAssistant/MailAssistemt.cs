using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MailAssistant
{
    class MailAssistemt
    {
        private string smtpName;

        public string SmtpName
        {
            get { return smtpName; }
            set { smtpName = value; }
        }
        private string port;

        public string Port
        {
            get { return port; }
            set { port = value; }
        }
        private string mailFromAddress;

        public string MailFromAddress
        {
            get { return mailFromAddress; }
            set { mailFromAddress = value; }
        }

        private string mailPassword;

        public string MailPassword
        {
            get { return mailPassword; }
            set { mailPassword = value; }
        }

        private int year;
        private int month;
        private int day;
        private int hour;
        private int min;
        private int second;

        private ArrayList mailList = new ArrayList();
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        private string mailContent;

        public string MailContent
        {
            get { return mailContent; }
            set { mailContent = value; }
        }
        private ArrayList attPathList = new ArrayList();

        public ArrayList AttPathList
        {
            get { return attPathList; }
            set { attPathList = value; }
        }
        
    }
}
