using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServiceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service)))
            {
                host.Open();
                foreach (var item in host.Description.Endpoints)
                {
                    Console.WriteLine(item.ListenUri);
                }
                Console.WriteLine("The service is ready at {0}", host.Description.Endpoints);           
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
