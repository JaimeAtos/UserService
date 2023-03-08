using Application.DTOs;
using Application.Features.Users.Commands.CreateUserCommand;
using AutoMapper;
using Core.Entities;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Queries
            CreateMap<User, UserDto>();
            #endregion

            #region Commands
            CreateMap<CreateUserCommand, User>().ReverseMap();
            #endregion
        }
    }
}
