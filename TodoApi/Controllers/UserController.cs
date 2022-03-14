using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoApi.BusinessService;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserBusinessService _userBusinessService;
        private IJWTManagerRepository _jwtManagerRepository;
        public UserController(IUserBusinessService userBusinessService, IJWTManagerRepository jwtManagerRepository)
        {
            _userBusinessService = userBusinessService;
            _jwtManagerRepository = jwtManagerRepository;
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public ActionResult login(User user)
        {
            try{
                return Ok(_jwtManagerRepository.GetToken(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet("[action]")]
        public ActionResult GetAll()
        {
            try
            {
                return Ok(_userBusinessService.GetAllUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("[action]")]
        public ActionResult Create(User user)
        {
            try
            {
                return Ok(_userBusinessService.Create(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id, User user)
        {
            try
            {
                return Ok(_userBusinessService.Update(id, user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("[action]")]
        public ActionResult DeleteById(int id)
        {
            try
            {
                return Ok(_userBusinessService.DeleteById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}