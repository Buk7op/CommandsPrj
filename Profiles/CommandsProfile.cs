using AutoMapper;
using CommandsPrj.DTOs;
using CommandsPrj.Models;

namespace CommandsPrj.Profiles
{

    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command,CommandReadDto>();
            CreateMap<CommandCreateDto,Command>();
            CreateMap<CommandUpdateDto,Command>();
            CreateMap<Command,CommandUpdateDto>();
        }
    }
}