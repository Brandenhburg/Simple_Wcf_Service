using SecurityService_Host.Data;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using System;

namespace SecurityService_Host
{
    [ServiceContract]
    public interface ISecurity_Service
    {
        [OperationContract]
        Task<Employee> SignIn(string userName, string password);

        [OperationContract]
        Task<bool> SignUp(string username, string email, string password);

        [OperationContract(IsOneWay = true)]
        Task SignOut(string Id, string username);
    }
}
