using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserBusinessService _userBusinessService;
        public UserController(IUserBusinessService userBusinessService)
        {
            _userBusinessService = userBusinessService;
        }
        [HttpGet("[action]")]
        public IEnumerable<User> GetAll()
        {
            return _userBusinessService.GetAllUsers();
        }
        [HttpPost("[action]")]
        public User Create(User user)
        {
            return _userBusinessService.Create(user);
        }
        [HttpPut("{id}")]
        public User Update(int id, User user)
        {
            return _userBusinessService.Update(id, user);
        }
        [HttpDelete("[action]")]
        public int DeleteById(int id)
        {
            return _userBusinessService.DeleteById(id);
        }

    }
}