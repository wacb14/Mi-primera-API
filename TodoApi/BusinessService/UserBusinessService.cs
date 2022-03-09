using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.DataService.Interfaces;

namespace TodoApi
{
    public class UserBusinessService : IUserBusinessService
    {
        private IUserDataService _userBusinessService;
        public UserBusinessService(IUserDataService userBusinessService)
        {
            _userBusinessService = userBusinessService;
        }
        public List<User> GetAllUsers()
        {
            return _userBusinessService.GetAllUsers();
        }
        public User Create(User user)
        {
            return _userBusinessService.Create(user);

        }
        public User Update(int id, User user)
        {
            return _userBusinessService.Update(id, user);
        }
        public int DeleteById(int id)
        {
            return _userBusinessService.DeleteById(id);
        }
    }
}