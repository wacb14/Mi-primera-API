using System.Collections.Generic;
using TodoApi.Models;
using TodoApi.ViewModels;

namespace TodoApi.BusinessService.Interfaces{
    public interface IUserBusinessService{
        public List<UserViewModel> GetAllUsers();
        public UserViewModel Create(User user);
        public UserViewModel Update(int id, User user);
        public int DeleteById(int id);
    }
}