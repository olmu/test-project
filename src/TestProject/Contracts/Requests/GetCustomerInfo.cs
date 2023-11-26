using TestProject.BL.Models;

namespace TestProject.Contracts.Requests
{
    public class GetCustomerInfoRequest
    {
        public string CustomerId { get; set; }
    }

    public class GetCustomerInfoResponse
    {
        public CustomerInfo CustomerInfo { get; set; }
    }
}
