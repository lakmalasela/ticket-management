using AutoMapper;

namespace ticketissuesystem
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, GetEmployeeDto>();
            CreateMap<UpdateEmplyeeDto, Employee>();
            CreateMap<AddEmployeeDto, Employee>();
        }
    }
}
