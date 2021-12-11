using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class CustomerInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string JoinedOnDate { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal SavingsBalance { get; set; }
    }
}
