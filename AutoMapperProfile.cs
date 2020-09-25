using AutoMapper;
using dotnet_rpg_udemy.Dtos;
using dotnet_rpg_udemy.Dtos.Character;
using dotnet_rpg_udemy.Models;

namespace dotnet_rpg_udemy
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}