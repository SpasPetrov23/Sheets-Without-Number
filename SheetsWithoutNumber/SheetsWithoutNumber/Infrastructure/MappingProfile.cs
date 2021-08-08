﻿namespace SheetsWithoutNumber.Infrastructure
{
    using AutoMapper;
    using SheetsWithoutNumber.Models.Characters;
    using SheetsWithoutNumber.Models.Games;
    using SheetsWithoutNumber.Services.Game;
    using SWN.Data.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<CharacterDetailsModel, CharacterFormModel>();

            this.CreateMap<Character, CharacterListingModel>()
                .ForMember(c => c.Class, cfg => cfg.MapFrom(c => c.Class.Name))
                .ForMember(c => c.Background, cfg => cfg.MapFrom(c => c.Background.Name));

            this.CreateMap<Character, CharacterDetailsModel>()
                .ForMember(c => c.Class, cfg => cfg.MapFrom(c => c.Class.Name))
                .ForMember(c => c.Background, cfg => cfg.MapFrom(c => c.Background.Name));

            this.CreateMap<Class, CharacterClassViewModel>();

            this.CreateMap<Background, CharacterBackgroundView>();

            this.CreateMap<Game, GamePreviewModel>()
                .ForMember(g => g.PlayersCurrent, cfg => cfg.MapFrom(u => u.Users.Count));

            this.CreateMap<Game, GameDetailsModel>();

            this.CreateMap<Game, GameEditServiceModel>();
        }
    }
}
