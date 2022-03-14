using System.Collections.Generic;
using AutoMapper;
using TodoApi.BusinessService.Interfaces;
using TodoApi.DataService.Interfaces;
using TodoApi.Models;
using TodoApi.ViewModels;

namespace TodoApi
{
    public class UserBusinessService : IUserBusinessService
    {
        private IUserDataService _userBusinessService;
        private IMapper _mapper;
        public UserBusinessService(IUserDataService userBusinessService, IMapper mapper)
        {
            _userBusinessService = userBusinessService;
            _mapper = mapper;
        }
        public List<UserViewModel> GetAllUsers()
        {
            var userList =_userBusinessService.GetAllUsers();
            var usersViewModelList = _mapper.Map<List<UserViewModel>>(userList);
            return usersViewModelList;
        }
        public UserViewModel Create(User user)
        {
            var userTemp = _userBusinessService.Create(user);
            return _mapper.Map<UserViewModel>(userTemp);

        }
        public UserViewModel Update(int id, User user)
        {
            var userTemp = _userBusinessService.Update(id, user);
            return _mapper.Map<UserViewModel>(userTemp);
        }
        public int DeleteById(int id)
        {
            return _userBusinessService.DeleteById(id);
        }
    }
}