using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BL.Requests;

namespace TestProject.BL.Handlers
{
    public class GetCustomerInfoHandler : IRequestHandler<GetCustomerInfoBlRequest, GetCustomerInfoBlResponse>
    {
        public async Task<GetCustomerInfoBlResponse> Handle(GetCustomerInfoBlRequest request)
        {
            TestData.RegisteredCustomers.TryGetValue(request.CustomerId, out var customerInfo);

            return new GetCustomerInfoBlResponse
            {
                CustomerInfo = customerInfo
            };
        }
    }
}
