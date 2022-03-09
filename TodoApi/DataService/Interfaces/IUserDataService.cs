using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.DataService.Interfaces{
    public interface IUserDataService{
        public List<User> GetAllUsers();
        public User Create(User user);
        public User Update(int id, User user);
        public int DeleteById(int id);
    }
}