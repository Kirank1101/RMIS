using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using RMIS.Domain.Mediator;
using log4net;
using RMIS.Domain.Business;
using RMIS.Domain.RiceMill;
using AllInOne.Common.Library.Util;
using RMIS.Domain;

namespace RMIS.Business
{
    public class MailProvider : IMailProvider
    {

        IRMISMediator imp;
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MailProvider));
        public MailProvider(IRMISMediator imp)
        {
            this.imp = imp;
        }

        const string usermailId = "info@Ormer-rims.com";
        const string password = "pass1234";
        internal bool SendMailThroughGoDaddy(string messagebody, string subject, string to)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string msg = string.Empty;
            try
            {
                MailAddress fromAddress = new MailAddress(usermailId);
                message.From = fromAddress;
                message.To.Add(to);
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = messagebody;
                smtpClient.Host = "relay-hosting.secureserver.net";   //-- Donot change.
                smtpClient.Port = 25; //--- Donot change
                smtpClient.EnableSsl = false;//--- Donot change
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(usermailId, password);
                smtpClient.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            return false;
        }

        public void CallMailQueue()
        {
            List<MailQueueEntity> listMailQueueEntity = imp.GetMailQueueEntities(YesNo.N);
            if (listMailQueueEntity != null && listMailQueueEntity.Count > 0)
            {
                foreach (MailQueueEntity objMailQueueEntity in listMailQueueEntity)
                {
                    if (SendMailThroughGoDaddy(objMailQueueEntity.MessageBody, objMailQueueEntity.Subject, objMailQueueEntity.ToEmail))
                        objMailQueueEntity.Status = YesNo.Y;
                }
                imp.BeginTransaction();
                foreach (MailQueueEntity objMailQueueEntity in listMailQueueEntity)
                {
                    imp.SaveOrUpdateMailQueueEntity(objMailQueueEntity, true);
                }
                imp.CommitAndCloseSession();

            }
        }

        public bool AddToMailQueue(string messagebody, string subject, string to)
        {
            MailQueueEntity objMailQueueEntity = new MailQueueEntity();
            objMailQueueEntity.MailId = CommonUtil.CreateUniqueID("ML");
            objMailQueueEntity.MessageBody = messagebody;
            objMailQueueEntity.Status = YesNo.N;
            objMailQueueEntity.Subject = subject;
            objMailQueueEntity.FromEmail = usermailId;
            objMailQueueEntity.ToEmail = to;
            objMailQueueEntity.LastModifiedDate = DateTime.Now;
            try
            {
                imp.BeginTransaction();
                imp.SaveOrUpdateMailQueueEntity(objMailQueueEntity, false);
                imp.CommitAndCloseSession();
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex);

            }
            return false;

        }


    }
}
