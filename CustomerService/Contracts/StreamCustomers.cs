using System.IO;
using System.ServiceModel;

namespace CustomerService.Contracts
{
    [ServiceContract]
    interface StreamCustomers
    {
        [OperationContract]
        Stream GetAllCustomers();
        [OperationContract]
        Stream FilterCustomers(string column, string substringVal);
    }
}
