using Serilog;
using System;
using System.Diagnostics;
using System.Net;

namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.FirstChanceException += (sender, eventArgs) => {
                Debug.WriteLine(eventArgs.Exception.ToString());
            };
            //WebClient webClient = null;
            //try
            //{
            //    string param = null;
            //    webClient = new WebClient();
            //    var resultData = webClient.DownloadString("http://google.comx");
            //}
            //catch (ArgumentNullException ex)
            //{
            //}
            //catch (WebException ex)
            //when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            //{

            //}
            //catch (Exception ex)
            //{

            //}

            //finally
            //{
            //    webClient?.Dispose();
            //}

            //try
            //{
            //    DoBilling(5);
            //}
            //catch (ClientBillingEXception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //Hidden Exceptions
            //var date = GetDate(new SqlDataReated(), null);

            try
            {
                int number = 5;
                number += number / (0);
            }
            catch (Exception ex)
            {
                Log.Error(string.Format("Excellent description goes here about the exception. Happened for client {0}", 5), ex);
                throw;
            }

        }

        //public static DateTime? GetDate(SqlDateReated reader, string columnName)
        //{
        //    DateTime? dateTime = null;

        //    try
        //    {
        //        dateTime = DateTime.Parse(reader[columnName].ToString());
        //    }
        //    catch
        //    {
        //    }
        //    return dateTime;
        //}

        public static void DoBilling(int clientID)
        {
            Client client = GetClient(clientID);

            if (client == null)
            {
                throw new ClientBillingEXception(string.Format("Unable to find a clilent by id {0}", clientID));
            }
        }

        private static Client GetClient(int clientID)
        {
            return null;
        }

        public class ClientBillingEXception: Exception
        {
            public ClientBillingEXception(string message): base(message)
            {

            }
        }
    }

    internal class Client
    {
    }
}
