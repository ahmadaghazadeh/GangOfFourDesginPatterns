using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.CreationalMtehod.Singleton
{
    public class ServerProvider
    {
        private static ServerProvider instance = null;
        private string Name { get; set; }
        private string IP { get; set; }
        private static object syncLock = new object();

        private ServerProvider()
        {
            //To DO: Remove below line
            Console.WriteLine("Singleton Intance");

            Name = "Server1";
            IP = "192.168.1.23";
        }

        public static ServerProvider Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (instance == null)
                        instance = new ServerProvider();

                    return instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }
    }
}
