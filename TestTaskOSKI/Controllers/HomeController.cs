using Microsoft.AspNetCore.Mvc;
using TestTaskOSKI.DTO.ModelViewsObjects;
using TestTaskOSKI.Services.ServicesInterfaces;

namespace TestTaskOSKI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ITestServices _testsServices;

        public HomeController(ITestServices testsServices)
        {
            _testsServices = testsServices;
        }

        [HttpGet]
        [Route("GetTests/{userId}")]
        public List<TestDTO> GetTests(int userId)
        {
            return _testsServices.GetTests(userId);
        }
    }
}
