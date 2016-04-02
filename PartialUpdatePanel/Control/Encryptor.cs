using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace iucon.web.Controls
{
    /// <summary>
    /// Encrypts sensitive data
    /// </summary>
    internal class Encryptor
    {
        #region Constants
        /// <summary>
        /// 
        /// </summary>
        private static readonly byte[] Key;
        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        static Encryptor()
        {
            string sKey = WebConfigurationManager.AppSettings["PartialUpdatePanel.EncryptionKey"];
            if (sKey == null) throw new Exception("You must add \"PartialUpdatePanel.EncryptionKey\" in your web.config");
            byte[] buf = Encoding.ASCII.GetBytes(sKey);

            if (buf == null || buf.Length != 8)
                throw new ArgumentException("Can't initialize Encryption key. Key has to be 8 chars long.");

            Key = buf;
        }

        #endregion

        #region Public methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] Encrypt(string text)
        {
            byte[] buffer = null;
            DESCryptoServiceProvider provider = null;

            try
            {
                provider = GetProvider();
                ICryptoTransform encryptor = provider.CreateEncryptor();

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream encStream = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(encStream))
                    {
                        sw.Write(text);
                    }

                    buffer = ms.ToArray();
                }
            }
            finally
            {
                provider.Clear();
            }

            return buffer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EncryptToString(string text)
        {
            byte[] buff = Encrypt(text);
            string value = Convert.ToBase64String(buff);

            return value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Decrypt(byte[] data)
        {
            string value = null;
            DESCryptoServiceProvider provider = null;

            try
            {
                provider = GetProvider();
                ICryptoTransform decryptor = provider.CreateDecryptor();

                using (MemoryStream ms = new MemoryStream(data))
                using (CryptoStream encStream = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(encStream))
                {
                    value = sr.ReadToEnd();
                }
            }
            finally
            {
                provider.Clear();
            }

            return value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string DecryptFromString(string data)
        {
            byte[] buff = Convert.FromBase64String(data);
            string value = Decrypt(buff);

            return value;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static DESCryptoServiceProvider GetProvider()
        {
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Key = Key;
            provider.IV = Key;

            return provider;
        }
        #endregion
    }
}
