using SecurityService_Host.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecurityService_Host.SecurityServices
{
    public static class SecurityManager
    {
        public static string Hash(Guid id, string password)
        {
            SHA512 sha512 = SHA512.Create();
            byte[] saltedHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(password + id.ToString()));
            return Convert.ToBase64String(saltedHash);
        }

        public static bool CheckUsersPassword(string username, string password)
        {
            Worker worker = WorkersMockDatabase.Workers.Find(w => w.Username == username);

            if(worker.Password == Hash(worker.Id, password))
                return true;

            return false;
        }
    }
}
