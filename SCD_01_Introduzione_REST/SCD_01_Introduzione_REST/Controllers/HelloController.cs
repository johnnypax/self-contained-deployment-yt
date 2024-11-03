using Microsoft.AspNetCore.Mvc;

namespace SCD_01_Introduzione_REST.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Saluta() {
            return Ok("Hello World");
        }

        [HttpGet("{varNominativo}")]
        public IActionResult SalutaConNome(string varNominativo)
        {  
            return Ok($"Ciao {varNominativo}");
        }
    }
}
