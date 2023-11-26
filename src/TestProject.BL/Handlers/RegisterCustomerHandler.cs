using AutoMapper;
using TestProject.BL.Models;
using TestProject.BL.Requests;

namespace TestProject.BL.Handlers
{
    public class RegisterCustomerHandler : IRequestHandler<RegisterCustomerBlRequest, RegisterCustomerBlResponse>
    {
        private readonly IMapper _mapper;

        private const int DEFAULT_BALANCE = 150;

        public RegisterCustomerHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<RegisterCustomerBlResponse> Handle(RegisterCustomerBlRequest request)
        {
            var customerInfo = _mapper.Map<CustomerInfo>(request);
            customerInfo.Balance = DEFAULT_BALANCE;

            var id = Guid.NewGuid().ToString();

            TestData.RegisteredCustomers[id] = customerInfo;

            return new RegisterCustomerBlResponse
            {
                CreatedCustomerId = id
            };
        }
    }
}
