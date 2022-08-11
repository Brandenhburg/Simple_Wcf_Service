using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using SecurityService_Host;

namespace SecurityService_Host.Data
{
    public static class EmployeesMockDatabase
    {

        public static List<Employee> Employees { get; private set; } = new List<Employee>();


        public static bool IsNewEmployeeCreated(string username, string email, string password)
        {
            Thread.Sleep(4000);

            if (Employees.Exists(e => e.Username == username || e.EMail == email))
                return false;


            Employee newEmplloyee = new Employee
            {
                Id = Guid.NewGuid(),
                Username = username,
                EMail = email,
                AccountType = EmployeeAccType.AccountManager
            };

            newEmplloyee.Password = CreateHash(newEmplloyee.Id, password);

            Employees.Add(newEmplloyee);

            return true;        
        }
        public static Employee GetEmployee(string userName, string password)
        {
            Thread.Sleep(4000);

            Employee employee = Employees.Find(e => e.Username == userName);

            if (employee == null)
                return employee;

            if (!CorrectPassword(employee, password))
            {
                employee = null;
                return employee;
            }

            return employee;
        }




        public static void AddDefaultEmployee()
        {
            Employee defaultEmployee = new Employee
            {
                Id = Guid.NewGuid(),
                Username = "worker",
                EMail = "worker",
                AccountType = EmployeeAccType.AccountManager
            };

            defaultEmployee.Password = CreateHash(defaultEmployee.Id, "worker");

            Employees.Add(defaultEmployee);
        }

        private static bool CorrectPassword(Employee employee, string password)
        {
            if (employee.Password == CreateHash(employee.Id, password))
                return true;

            return false;
        }

        private static string CreateHash(Guid id, string password)
        {
            SHA512 sha512 = SHA512.Create();
            byte[] saltedHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(password + id.ToString()));
            return Convert.ToBase64String(saltedHash);
        }
    }
}
