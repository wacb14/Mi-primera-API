using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TodoApi.DataService.Interfaces;
using TodoApi.Models;

namespace TodoApi{
    public class UserDataService:IUserDataService
    {
        public GeneralContext _context;
        public UserDataService(GeneralContext context){
            _context=context;
        }
        public List<User> GetAllUsers(){
            return _context.User.ToList();
        }
        public User Create(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return _context.User.FirstOrDefault(e => e.Id == user.Id);
        }
        public User Update(int id, User user)
        {
            if (id != user.Id)
            {
                return null;
            }
            else
            {
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();
                return _context.User.FirstOrDefault(e => e.Id == id);
            }
        }
        public int DeleteById(int id)
        {
            User user = _context.User.FirstOrDefault(e => e.Id == id);
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }
            return id;
        }
    }
}