using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace StationCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Specs Computer = new Specs();
            double Memory = Convert.ToDouble(Computer.GetMemoryInfo()) / 1024 / 1024;
            double roundMemory = Math.Ceiling(Memory);
            Console.WriteLine("Drive Info:\t\t"+Computer.GetDrivesInfo());
            Console.WriteLine("Processor Info:\t\t"+Computer.GetProcessorInfo());
            Console.WriteLine("Memory Info:\t\t{0} GB", Convert.ToString(roundMemory));
            Console.WriteLine("OS Info:\t\t"+Computer.GetOSInfo());
        }
    }
}
