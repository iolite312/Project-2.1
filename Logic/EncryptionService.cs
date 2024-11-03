using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EncryptionService
    {
        //Encrypts password :)
        public string EncryptPassword(string password, string salt)
        {
            string input = password + salt;
            return Hash(input);
        }

        //Generates a random string
        public string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+[]{}|;:',.<>?/~`";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //encrypts whatever data you throw in
        public string EncryptData(string data)
        {
            return Hash(data);
        }

        //Hashes
        private string Hash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }
                return hashString.ToString();
            }
        }


        //Encrypts an input using the key and IV provided
        public string Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        //Decrypts an input using the key and IV provided
        public string Decrypt(string cipherText, byte[] Key, byte[] IV)
        {
            var fullCipher = Convert.FromBase64String(cipherText);

            using (var aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(fullCipher))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        //Generates a random key for the aes encryption
        public byte[] GenerateRandomKey(int size)
        {
            byte[] key = new byte[size];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(key);
            }
            return key;
        }

        //Generates a random IV for the aes encryption
        public byte[] GenerateRandomIV()
        {
            return GenerateRandomKey(16);
        }

    }
}
