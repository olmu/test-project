using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestProject.BL;
using TestProject.BL.Requests;
using TestProject.Contracts.Requests;

namespace TestProject.Controllers
{
    [Route("v1/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;

        public CustomerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("")]
        public async Task<RegisterCustomerResponse> RegisterCustomer([FromBody] RegisterCustomerRequest request, [FromServices] IRequestHandler<RegisterCustomerBlRequest, RegisterCustomerBlResponse> handler)
        {
            var res = await handler.Handle(_mapper.Map<RegisterCustomerBlRequest>(request));

            return _mapper.Map<RegisterCustomerResponse>(res);
        }

        [HttpGet("")]
        public async Task<GetCustomerInfoResponse> GetCustomerInfo(GetCustomerInfoRequest request, [FromServices] IRequestHandler<GetCustomerInfoBlRequest, GetCustomerInfoBlResponse> handler)
        {
            var res = await handler.Handle(_mapper.Map<GetCustomerInfoBlRequest>(request));

            return _mapper.Map<GetCustomerInfoResponse>(res);
        }

        [HttpGet("balance")]
        public async Task<GetCustomerBalanceResponse> GetCustomerBalance(GetCustomerBalanceRequest request, [FromServices] IRequestHandler<GetCustomerBalanceBlRequest, GetCustomerBalanceBlResponse> handler)
        {
            var res = await handler.Handle(_mapper.Map<GetCustomerBalanceBlRequest>(request));

            return _mapper.Map<GetCustomerBalanceResponse>(res);
        }
    }
}
