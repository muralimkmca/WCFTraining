using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFSelfhost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CalcService));
            host.Open();
            Console.WriteLine("Service is running.....");
            Console.Read();

        }
    }
}
