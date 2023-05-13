using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Email.Model
{
    public class Mail
    {
        private string senderName;
        private string senderSubject;
        private string senderEmail;
        private DateTime dateReceived;
        private string senderImagePath;
        private string body;

        public Mail(string senderName, string senderSubject, string senderEmail, DateTime dateReceived, string senderImagePath, string body)
        {
            this.senderName = senderName;
            this.senderSubject = senderSubject;
            this.senderEmail = senderEmail;
            this.dateReceived = dateReceived;
            this.senderImagePath = senderImagePath;
            this.body = body;
        }
        public string SenderName { get { return senderName; } }

        public string SenderSubject { get { return senderSubject; } }

        public string SenderEmail { get { return senderEmail; } }
        public DateTime DateReceived { get { return dateReceived; } }

        public string SenderImagePath { get { return senderImagePath; } }

        public string Body { get { return body; } }
    }
}
