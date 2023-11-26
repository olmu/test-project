using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BL.Requests;

namespace TestProject.BL.Handlers
{
    public class GetCustomerBalanceHandler : IRequestHandler<GetCustomerBalanceBlRequest, GetCustomerBalanceBlResponse>
    {
        public async Task<GetCustomerBalanceBlResponse> Handle(GetCustomerBalanceBlRequest request)
        {
            if (!TestData.RegisteredCustomers.TryGetValue(request.CustomerId, out var customerInfo)) {
                throw new InvalidOperationException($"Customer '{request.CustomerId}' not found");
            }

            return new GetCustomerBalanceBlResponse
            {
                Balance = customerInfo.Balance
            };
        }
    }
}
