using System;
using System.Runtime.Serialization;

namespace SecurityService_Host.Data
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string EMail { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public EmployeeAccType AccountType{ get; set; }
    }
}
