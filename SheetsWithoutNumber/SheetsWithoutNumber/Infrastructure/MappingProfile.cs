namespace SheetsWithoutNumber.Infrastructure
{
    using AutoMapper;
    using SheetsWithoutNumber.Models.Characters;
    using SheetsWithoutNumber.Models.Equipments;
    using SheetsWithoutNumber.Models.Foci;
    using SheetsWithoutNumber.Models.Games;
    using SheetsWithoutNumber.Models.Skills;
    using SheetsWithoutNumber.Services.Equipments;
    using SheetsWithoutNumber.Services.Focus;
    using SheetsWithoutNumber.Services.Game;
    using SheetsWithoutNumber.Services.Skills;
    using SWN.Data.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<CharacterDetailsModel, CharacterEditFormModel>();

            this.CreateMap<Character, CharacterListingModel>()
                .ForMember(c => c.Class, cfg => cfg.MapFrom(c => c.Class.Name))
                .ForMember(c => c.Background, cfg => cfg.MapFrom(c => c.Background.Name));

            this.CreateMap<Character, CharacterDetailsModel>()
                .ForMember(c => c.Class, cfg => cfg.MapFrom(c => c.Class.Name))
                .ForMember(c => c.Background, cfg => cfg.MapFrom(c => c.Background.Name));

            this.CreateMap<Character, CharacterOwnerModel>();

            this.CreateMap<Class, CharacterClassViewModel>();

            this.CreateMap<Background, CharacterBackgroundViewModel>();

            this.CreateMap<Game, GamePreviewModel>()
                .ForMember(g => g.PlayersCurrent, cfg => cfg.MapFrom(u => u.Users.Count));
            
            this.CreateMap<GameDetailsModel, GameFormModel>();

            this.CreateMap<Game, GameDetailsModel>();

            this.CreateMap<Game, GameEditServiceModel>();

            this.CreateMap<Skill, SkillServiceListingViewModel>();

            this.CreateMap<SkillServiceListingViewModel, SkillFormModel>();

            this.CreateMap<CharacterSkillServiceModel, SkillFormModel>()
                .ForMember(sf => sf.Name, cfg => cfg.MapFrom(cs => cs.SkillName))
                .ForMember(sf => sf.Level, cfg => cfg.MapFrom(cs => cs.SkillLevel))
                .ForMember(sf => sf.CharacterSkillId, cfg => cfg.MapFrom(cs => cs.Id));

            this.CreateMap<CharactersSkills, CharacterSkillServiceModel>();

            this.CreateMap<Focus, FocusServiceListingViewModel>();

            this.CreateMap<CharactersFoci, CharacterFocusServiceModel>();

            this.CreateMap<CharacterFocusServiceModel, FocusFormModel>()
                .ForMember(ff => ff.Name, cfg => cfg.MapFrom(cf => cf.FocusName))
                .ForMember(ff => ff.Level, cfg => cfg.MapFrom(cf => cf.FocusLevel))
                .ForMember(ff => ff.CharacterFocusId, cfg => cfg.MapFrom(cf => cf.Id));

            this.CreateMap<Equipment, EquipmentServiceListingViewModel>();

            this.CreateMap<CharactersEquipments, CharacterEquipmentServiceModel>();

            this.CreateMap<CharacterEquipmentServiceModel, EquipmentFormModel>()
                .ForMember(ef => ef.Name, cfg => cfg.MapFrom(ce => ce.EquipmentName))
                .ForMember(ef => ef.Count, cfg => cfg.MapFrom(ce => ce.EquipmentCount))
                .ForMember(ef => ef.Location, cfg => cfg.MapFrom(ce => ce.EquipmentLocation))
                .ForMember(ef => ef.CharacterEquipmentId, cfg => cfg.MapFrom(ce => ce.Id));
        }
    }
}
