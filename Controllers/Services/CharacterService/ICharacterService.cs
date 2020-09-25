using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_rpg_udemy.Dtos;
using dotnet_rpg_udemy.Dtos.Character;
using dotnet_rpg_udemy.Models;

namespace dotnet_rpg_udemy.Services.CharacterService
 {
     public interface ICharacterService
     {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
     }
 }