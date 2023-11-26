using AutoMapper;
using TestProject.BL.Models;
using TestProject.BL.Requests;
using TestProject.Contracts.Requests;

namespace TestProject
{
    public class MapperProfile : Profile
    {
        public MapperProfile() {

            CreateMap<RegisterCustomerRequest, RegisterCustomerBlRequest>()
                .ForMember(m => m.RegistrationDate, d => d.MapFrom(i => DateTime.Now));
            CreateMap<RegisterCustomerBlRequest, CustomerInfo>()
                .ForMember(m => m.Balance, d => d.Ignore());

            CreateMap<RegisterCustomerBlResponse, RegisterCustomerResponse>();


            CreateMap<GetCustomerBalanceRequest, GetCustomerBalanceBlRequest>();
            CreateMap<GetCustomerBalanceBlResponse, GetCustomerBalanceResponse>();

            CreateMap<GetCustomerInfoRequest, GetCustomerInfoBlRequest>();
            CreateMap<GetCustomerInfoBlResponse, GetCustomerInfoResponse>();

        }
    }
}
