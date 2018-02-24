using CodeTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace CodeTest.Controllers
{
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        // GET
        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            if (ModelState.IsValid)
            {
                return new ObjectResult(_fizzBuzzService.GetResult(number));
            }

            return new BadRequestObjectResult("Input is not a number");
        }
    }
}
