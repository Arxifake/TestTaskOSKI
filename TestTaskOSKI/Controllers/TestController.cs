using Microsoft.AspNetCore.Mvc;
using TestTaskOSKI.DTO.ModelViewsObjects;
using TestTaskOSKI.Services.ServicesInterfaces;

namespace TestTaskOSKI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ITestServices _testsServices;

        public TestController(ITestServices testsServices)
        {
            _testsServices = testsServices;
        }

        [Route("GetTest/{id}")]
        [HttpGet]
        public TestDTO GetTest(int id) 
        {
            return _testsServices.GetTest(id);
        }
    }
}
