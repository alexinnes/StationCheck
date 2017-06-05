using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace StationCheck
{
    public class Specs
    {
        //Creates the list

        public Specs()
        {
            this.SomeNumber = 1;
        }

        public string GetDrivesInfo()
        {
            System.IO.DriveInfo[] Drives = System.IO.DriveInfo.GetDrives();

            foreach (var drive in Drives)
            {
                if (drive.IsReady == true)
                {
                    string volumeName = drive.VolumeLabel;
                    string driveName = drive.Name;
                    return (volumeName + " " + driveName);

                }
                else
                {
                    return "nope";
                }
            }
            return "nope";


        }

        public object GetMemoryInfo()
        {

            ObjectQuery winQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                return (result["TotalVisibleMemorySize"]);
            }
            return "Something went wrong";
        }

        
        public object GetProcessorInfo()
        {
            ObjectQuery winQuery = new ObjectQuery("SELECT * FROM Win32_Processor");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);
            ManagementObjectCollection results = searcher.Get();

            foreach(ManagementObject result in results)
            {   
                return (result["Name"]);
            }

            return "Something went wrong getting the processor info";
        }
        
        public object GetOSInfo()
        {
            ObjectQuery winQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(winQuery);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                return (result["Caption"]);
            }
            return "Something went wrong";
        }

        private int SomeNumber;

        public int someNumber
        {
            get { return SomeNumber; }
            set { SomeNumber = value; }
        }



    }
}
