using AutoMapper;
using CoreApi.Application.Dtos;
using CoreApi.Persistence.Models;

namespace CoreApi.Application.Core
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeToReturnDto>();
        }
    }
}
