using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityService_Host.Data
{
    public class ActiveEmployees
    {
        internal List<Employee> SignedInEmployees { get; private set; }
        static ActiveEmployees instance;
        private ActiveEmployees()
        {
            SignedInEmployees = new List<Employee>();
        } 

        public static ActiveEmployees GetIntance()
        {
            if (instance == null)
                instance = new ActiveEmployees();

            return instance;
        }

    }
}
