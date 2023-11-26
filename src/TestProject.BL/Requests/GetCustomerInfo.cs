using TestProject.BL.Models;

namespace TestProject.BL.Requests
{
    public class GetCustomerInfoBlRequest
    {
        public string CustomerId { get; set; }
    }

    public class GetCustomerInfoBlResponse
    {
        public CustomerInfo CustomerInfo { get; set; }
    }
}
