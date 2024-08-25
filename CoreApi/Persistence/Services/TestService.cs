using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreApi.Application.Dtos;
using CoreApi.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using QMS_API.Application.Core;
using QMS_API.Application.Interfaces;
using QMS_API.Persistence.Services;

namespace CoreApi.Persistence.Services
{
    public class TestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly LoggedInUserDataService _loggedInUserData;

        public TestService(IUnitOfWork unitOfWork, IMapper mapper
            , ILoggerFactory loggerFactory)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<PagedList<EmployeeToReturnDto>>> GetPagedEmployeesAsync(PagingParams pagingParams)
        {
            var list = _unitOfWork.Repository<Employee>()
                .GetByExpression(x => x.Inactive == false).AsQueryable().ProjectTo<EmployeeToReturnDto>(_mapper.ConfigurationProvider).AsQueryable();

            var results = Result<PagedList<EmployeeToReturnDto>>
            .Success(await PagedList<EmployeeToReturnDto>.CreateAsync(list, pagingParams.PageNumber, pagingParams.PageSize));

            return results;
        }

        public async Task<Result<List<EmployeeToReturnDto>>> GetAllEmployeesAsync()
        {
            var list = await _unitOfWork.Repository<Employee>()
                .GetByExpression(x => x.Inactive == false)
                .ProjectTo<EmployeeToReturnDto>(_mapper.ConfigurationProvider).ToListAsync();


            var results = Result<List<EmployeeToReturnDto>>
            .Success(list);

            return results;
        }
    }
}
