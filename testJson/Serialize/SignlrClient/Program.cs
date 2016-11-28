using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;

namespace SignlrClient
{
    class Program
    {
        static void Main(string[] args)
        {
           // eventLog1.WriteEntry("In OnStart");
            try
            {
                var hubConnection = new HubConnection("http://localhost/SignalRChat");
                IHubProxy alphaProxy = hubConnection.CreateHubProxy("chatHub");

                alphaProxy.On<string,string>("addNewMessageToPage", (m, n) =>
                {
                    Console.Write(m as string);
                });

                 hubConnection.Start().Wait();
                
                alphaProxy.Invoke("Send","pankaj", "Message from Service");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
               /// eventLog1.WriteEntry(ex.Message);
            }
        }
    }
}
