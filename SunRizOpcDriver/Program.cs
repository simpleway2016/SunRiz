﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunRizOpcDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new SunRizOpcDriver.OpcDriverServer(int.Parse(args[0]));
            server.Start();
            Console.WriteLine($"runing on port:{args[0]}");
            while (true)
                System.Threading.Thread.Sleep(100000);
        }
    }
}
