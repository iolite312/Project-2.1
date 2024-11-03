using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class RememberMe
    {
        private string Email;
        private string Password;
        private string MacAddress;
        private byte[] Key;
        private string ProcessorID;
        private byte[] IV;
        private string DiskDriveID;
        private DateTime TimeCreated;

        public RememberMe(string email, string password, string macAddress, byte[] key, string processorID, byte[] iV, string diskDriveID, DateTime timeCreated)
        {
            Email = email;
            Password = password;
            MacAddress = macAddress;
            Key = key;
            ProcessorID = processorID;
            IV = iV;
            DiskDriveID = diskDriveID;
            TimeCreated = timeCreated;
        }

        public RememberMe() { }

        public string GetEmail() { return Email; }
        public string GetPassword() { return Password; }
        public string GetMacAddress() {  return MacAddress; }
        public string GetProcessorID() {  return ProcessorID; }
        public string GetDiskDriveID() {  return DiskDriveID; } 
        public byte[] GetKey() { return Key; }
        public byte[] GetIV() { return IV;}

        public bool GetValid()
        {
            TimeSpan timeDifference = DateTime.Now - TimeCreated;
            return timeDifference.TotalDays < 90;
        }

    }
}
