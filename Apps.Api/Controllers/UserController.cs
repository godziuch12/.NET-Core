using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apps.Infrastructure.DTO;
using Apps.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Apps.Api.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public readonly int a = 5;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public UserDTO GetDTO(string email) => _userService.GetDTO(email);

    }
}
