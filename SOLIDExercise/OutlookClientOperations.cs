using SOLIDExercise.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExercise
{
    class OutlookClientOperations
    {
        public OutlookClient outlookClient { get; set; }
        public OutlookClientOperations(OutlookClient client)
        {
            this.outlookClient = client;
        }

        
        public void deleteEmail(string emailId)
        {
            System.Console.WriteLine("Email Deleted");
        }

        private IFolderService GetFolderByName(string name)
        {
            return this.outlookClient.folders.Find(folder => folder.name == name);
        }
        public void moveEmail(string emailId, string toFolder)
        {
            IFolderService newFolder = GetFolderByName(toFolder);
            Email emailToMove = this.outlookClient.folders.Find(folder => folder.containsEmail(emailId)).removeEmail(emailId);
            newFolder.addEmail(emailToMove);
            System.Console.WriteLine("Email moved");
        }
    }
}
