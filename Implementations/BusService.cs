﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class BusService : IService
    {
        
        public void PrintMessage()
        {
            Console.WriteLine("Bus Service");
        }
    }
}
