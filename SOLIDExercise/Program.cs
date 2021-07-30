using System;

namespace SOLIDExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        
           OutlookClient client = new OutlookClient("server configuration");
           OutlookClientOperations oparations = new OutlookClientOperations(client);
        }
    }

    public static class Operations
    {
        private static void RecieveMessagge(this OutlookClient outlookClient)
        {
            System.Console.WriteLine("hol");
        }
    }
}
