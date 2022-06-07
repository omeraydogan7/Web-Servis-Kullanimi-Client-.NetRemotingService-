using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServiceHost
{
    class Program
    {
        static void Main()
        {
            HelloRemotingService.HelloRemotingService remotingeService = new HelloRemotingService.HelloRemotingService();

            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService), "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine("Remoting Service Starded @"+DateTime.Now);
            Console.ReadLine();



        }
    }
}
