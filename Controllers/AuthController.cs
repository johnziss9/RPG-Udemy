using System.Threading.Tasks;
using dotnet_rpg_udemy.Models;
using Microsoft.AspNetCore.Mvc;
using RPG_Udemy.Data;
using RPG_Udemy.Dtos.User;
using RPG_Udemy.Models;

namespace RPG_Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            this._authRepo = authRepo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto request)
        {
            ServiceResponse<int> response = await _authRepo.Register(new User { Username = request.Username }, request.Password);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }
    }
}