using System.Collections.Generic;
using dotnet_rpg_udemy.Models;

namespace dotnet_rpg_udemy.Services.CharacterService
 {
     public interface ICharacterService
     {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
     }
 }