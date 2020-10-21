using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg_udemy.Dtos;
using dotnet_rpg_udemy.Dtos.Character;
using dotnet_rpg_udemy.Models;
using dotnet_rpg_udemy.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;
using RPG_Udemy.Dtos.Character;

namespace dotnet_rpg_udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            this._characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            ServiceResponse<GetCharacterDto> response = await _characterService.UpdateCharacter(updatedCharacter);

            if (response.Data == null)
                return NotFound(response);

            return Ok(response);
        }
    }
}