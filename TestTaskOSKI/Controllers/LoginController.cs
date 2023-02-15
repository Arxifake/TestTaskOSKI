using Microsoft.AspNetCore.Mvc;
using TestTaskOSKI.DTO.ModelViewsObjects;
using TestTaskOSKI.Services.ServicesInterfaces;

namespace TestTaskOSKI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginServices;

        public LoginController(ILoginService loginServices)
        {
            _loginServices = loginServices;
        }
        [HttpPost]
        public int NewUser([FromBody]UserDTO user)
        {
            return _loginServices.NewUser(user);
        }
    }
}
