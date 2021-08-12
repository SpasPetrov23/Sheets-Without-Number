﻿namespace SheetsWithoutNumber.Services.Focus
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using SWN.Data;
    using SWN.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class FocusService : IFocusService
    {
        private readonly SWNDbContext data;
        private readonly IConfigurationProvider mapper;

        public FocusService(SWNDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper.ConfigurationProvider;
        }

        public int Add(int characterId, int focusId, int level)
        {
            var focus = data.Foci.Where(s => s.Id == focusId).FirstOrDefault();

            var characterFocus = new CharactersFoci
            {
                CharacterId = characterId,
                FocusId = focusId,
                FocusLevel = level,
                FocusName = focus.Name,
                FocusDescription = focus.Description
            };

            data.CharactersFoci.Add(characterFocus);

            data.SaveChanges();

            return characterFocus.Id;
        }

        public bool Edit(int level, int focusId, int characterFocusId)
        {
            var characterFocus = data.CharactersFoci.Where(cf => cf.Id == characterFocusId).FirstOrDefault();

            var focusName = this.GetFocusById(focusId).Name;

            characterFocus.FocusId = focusId;
            characterFocus.FocusLevel = level;
            characterFocus.FocusName = focusName;

            this.data.SaveChanges();

            return true;
        }
        public int Delete(int focusSkillId)
        {
            var characterFocus = data.CharactersFoci
                .Where(cf => cf.Id == focusSkillId)
                .FirstOrDefault();

            data.CharactersFoci.Remove(characterFocus);

            data.SaveChanges();

            return characterFocus.Id;
        }

        public IEnumerable<FocusServiceListingViewModel> GetFociListing()
            => this.data
             .Foci
             .ProjectTo<FocusServiceListingViewModel>(this.mapper)
             .OrderBy(f => f.Name)
             .ToList();

        public bool FocusExists(int focusId)
            => this.data
            .Foci
            .Any(f => f.Id == focusId);

        public bool FocusIsLearned(int focusId, int characterId)
            => this.data
            .CharactersFoci
            .Any(cf => cf.FocusId == focusId && cf.CharacterId == characterId);

        public CharacterFocusServiceModel GetCharacterFocusById(int characterFocusId)
        {
            var characterFocus = data.CharactersFoci
                .Where(cf => cf.Id == characterFocusId)
                .ProjectTo<CharacterFocusServiceModel>(this.mapper)
                .FirstOrDefault();

            return characterFocus;
        }

        public FocusServiceListingViewModel GetFocusById(int focusId)
        {
            var focus = data.Foci
                .Where(f => f.Id == focusId)
                .ProjectTo<FocusServiceListingViewModel>(this.mapper)
                .FirstOrDefault();

            return focus;
        }
    }
}
