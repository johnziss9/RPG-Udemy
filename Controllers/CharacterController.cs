using dotnet_rpg_udemy.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg_udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}