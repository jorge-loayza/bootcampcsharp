using SOLIDExercise.Interaces;
using System;
using System.Collections.Generic;

namespace SOLIDExercise
{
    class FolderInbox: IFolderService, IFolderNotification, IFolderRemoveEmail
    {
        public string name { get; set; }
        public List<Email> emails;


        public FolderInbox(string name)
        {
            this.name = name;
        }
        public Email getEmail(string emailId)
        {
            return this.emails.Find(email => email.id == emailId);
        }

        public void addEmail(Email email)
        {
            this.emails.Add(email);
        }

        public bool containsEmail(string emailId)
        {
            return this.emails.Contains(this.emails.Find(email => email.id == emailId));
        }

       

        public void sendNotification()
        {
            Console.WriteLine("Send Notifications");
        }

        public Email removeEmail(string emailId)
        {
            Email email = getEmail(emailId);
            this.emails.Remove(email);
            return email;
        }
    }
}