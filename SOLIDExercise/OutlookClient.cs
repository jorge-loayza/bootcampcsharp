using SOLIDExercise.Interaces;
using System.Collections.Generic;

namespace SOLIDExercise
{
    class OutlookClient
    {
        private string serverConfiguration;
        public List<IFolderService> folders;
        private Rule rule;

        public OutlookClient(string serverConfiguration)
        {
            this.serverConfiguration = serverConfiguration;
            folders.Add(new FolderInbox("inbox"));
        }
      
        private void ReciveMesagge(Email email)
        {
            System.Console.WriteLine("Analize Rules and store the Email");
        }
    }


   
}