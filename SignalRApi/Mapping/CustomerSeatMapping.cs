using AutoMapper;
using SignalR.DtoLayer.CustomerSeatDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class CustomerSeatMapping : Profile
    {
        public CustomerSeatMapping()
        {
            CreateMap<CustomerSeat, ResultCustomerSeatDto>().ReverseMap();
            CreateMap<CustomerSeat, CreateCustomerSeatDto>().ReverseMap();
            CreateMap<CustomerSeat, UpdateCustomerSeatDto>().ReverseMap();
            CreateMap<CustomerSeat, GetCustomerSeatDto>().ReverseMap();
        }
    }
}
