using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
                
        }

        [HttpGet]
        public IEnumerable<User> Index()
        {
            return new List<User>()
            {
                new User(){Name = "Seba", Age = 24}
            };
        }
    }
}
