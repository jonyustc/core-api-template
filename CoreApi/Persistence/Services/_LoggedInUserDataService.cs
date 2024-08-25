using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace QMS_API.Persistence.Services
{
    public class _LoggedInUserDataService
    {

        IMapper _mapper;
        ILogger<_LoggedInUserDataService> _logger;
        public long LoggedInUserID { get; set; }
        public long UserID { get; set; }
        public string LoggedInUserName { get; set; }
        public IList<string> Roles { get; set; }
        private readonly IHttpContextAccessor _httpContextAccessor;
        //IHttpContextAccessor httpContext

        public _LoggedInUserDataService(IMapper mapper, ILogger<_LoggedInUserDataService> logger, IHttpContextAccessor httpContextAccessor)
        {

            _logger = logger;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;

            
            LoggedInUserID = GetUserID();
            LoggedInUserName = GetUserName();


            //TODO: Take roles from token
        }


        public string GetUserName()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.GivenName);
        } 
        
        public long GetUserID()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)  return 0;  
            return Convert.ToInt64(userId);
        }

        public string GetUserEmail()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Email);
        }
    }
}
