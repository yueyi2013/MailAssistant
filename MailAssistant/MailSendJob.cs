using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Quartz;
using Common.Logging;
namespace MailAssistant
{
    public class MailSendJob:IJob
    {
        private static ILog _log = LogManager.GetLogger(typeof(MailSendJob));
		
        public MailSendJob()
		{
		}
		
		/// <summary> 
		/// Called by the <see cref="IScheduler" /> when a
		/// <see cref="ITrigger" /> fires that is associated with
		/// the <see cref="IJob" />.
		/// </summary>
		public virtual void  Execute(IJobExecutionContext context)
		{
            foreach (string addr in MailUtil.recList)
            {
                MailUtil.SendMail(MailUtil.jobMail,addr);
            }
		}
    }
}
