using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Model;


namespace Logic
{
    public class RememberMeService
    {
        EncryptionService EncryptionService;
        private string FileName = "RememberMeData.xml";

        public RememberMeService()
        {
            EncryptionService = new EncryptionService();
        }

        // get the processor id
        public string GetProcessorId()
        {
            string processorId = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select ProcessorId from Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    processorId = obj["ProcessorId"]?.ToString();
                    break;
                }
            }
            return EncryptionService.EncryptData(processorId);
        }

        //get the disk drive id
        public string GetDiskDriveId()
        {
            string diskDriveId = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select SerialNumber from Win32_DiskDrive"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    diskDriveId = obj["SerialNumber"]?.ToString();
                    break;
                }
            }
            return EncryptionService.EncryptData(diskDriveId);
        }

        // get the MAC adress
        public string GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet || nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211) && !nic.Description.ToLower().Contains("virtual") && !nic.Description.ToLower().Contains("pseudo"))
                {
                    return EncryptionService.EncryptData(nic.GetPhysicalAddress().ToString());
                }
            }
            throw new Exception("MAC address not found!");
        }

        //create the file for the remember me functionality
        public void SaveRememberMeData(RememberMe rememberMe)
        {
            DeleteFile();
            if (rememberMe == null) { return; }
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(typeof(RememberMe));
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, rememberMe);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(FileName);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving data: " + ex.Message);
            }
        }

        //reads file from the remember me functionality and gives back a remember me object
        public RememberMe LoadRememberMeData()
        {
            if (string.IsNullOrEmpty(FileName)) {
                DeleteFile();
                throw new Exception("Can't login with remember me."); 
            }
            RememberMe rememberMe = default(RememberMe);
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(FileName);
                string xmlString = xmlDocument.OuterXml;
                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(RememberMe);
                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        rememberMe = (RememberMe)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex){ throw new Exception("Error loading data: " + ex.Message); }
            return rememberMe;
        }

        public void DeleteFile()
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }
        }

        public bool CheckIfFileExists()
        {
            if (File.Exists(FileName))
            {
                return true;
            }
            return false;
        }

        public bool CheckHardware(RememberMe rememberMe)
        {
            if(rememberMe.GetProcessorID() == GetProcessorId() && rememberMe.GetDiskDriveID() == GetDiskDriveId() && rememberMe.GetMacAddress() == GetMacAddress())
            {
                return true;
            }
            return false;
        }

        
    }
}
