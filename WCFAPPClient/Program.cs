using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAPPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWFCService.TeachServiceClient client = new MyWFCService.TeachServiceClient();
            string serverName= client.GetServerName();
            string name=client.GetServerByName("你好");
            client.Close();
            client = new MyWFCService.TeachServiceClient();
            name = client.GetServerByName("你好");
            Console.WriteLine(serverName);
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
