using TodoApi.Models;

namespace TodoApi.BusinessService
{
    public interface IJWTManagerRepository
    {
        public string GetToken(User user);
    }
}