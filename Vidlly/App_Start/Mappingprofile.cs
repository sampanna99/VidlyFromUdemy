using AutoMapper;
using Vidlly.Dtos;
using Vidlly.Models;

namespace Vidlly.App_Start
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}