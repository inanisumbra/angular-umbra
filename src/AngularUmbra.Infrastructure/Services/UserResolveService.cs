using Microsoft.AspNetCore.Http;

namespace AngularUmbra.Infrastructure.Services
{
    public class UserResolverService
    {
        private readonly IHttpContextAccessor _context;
        public UserResolverService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string GetUser()
        {
            return _context.HttpContext?.User?.Identity?.Name;
        }
    }
}