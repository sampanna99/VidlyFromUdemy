using AutoMapper;
using Vidlly.Dtos;
using Vidlly.Models;

namespace Vidlly.App_Start
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile()
        {
            //member to dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();


            //dto to member
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}