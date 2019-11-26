using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPWCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPWCFService.TCPTeachServiceClient client = new TCPWCFService.TCPTeachServiceClient();
            string name= client.GetServerName();
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
