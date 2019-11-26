using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(TeachService));
            host.Open();
            Console.WriteLine("WCF SERVICE IS START!");
            Console.ReadLine();
        }
    }
}
