using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Version1
{
    class Encryption
    {
        //hashing a string 
        public static string hashMD5(string value , string salt )
        {

            byte[] bytes = Encoding.UTF8.GetBytes(value+salt);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] hashedPass = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hashedPass);


            /*
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
              */ 

            /*
            var md5 = System.Security.Cryptography.SHA1.Create();
            var iBytes = Encoding.UTF8.GetBytes(value);
            var hash = md5.ComputeHash(iBytes);
            
            var sb = new StringBuilder();
            for(var i = 0; i<hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
            */
        }
        internal static byte[] GenerateSalt(int saltSize)
        {
            using (RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[saltSize];
                saltGenerator.GetBytes(salt);
                return salt;
            }
        }


        internal static byte[] ComputeH(string password, byte[] salt, int iterations = 10101, int hashByteSize = 24)
        {
            using (Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt))
            {
                hashGenerator.IterationCount = iterations;
                return hashGenerator.GetBytes(hashByteSize);
            }
        }

    }
}
