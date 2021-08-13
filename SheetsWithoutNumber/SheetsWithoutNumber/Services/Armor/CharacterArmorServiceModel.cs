using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheetsWithoutNumber.Services.Armor
{
    public class CharacterArmorServiceModel
    {
        public int Id { get; init; }

        public int CharacterId { get; set; }

        public int ArmorId { get; set; }

        public string ArmorName { get; init; }

        public int ArmorClass { get; set; }

        public string ArmorLocation { get; set; }
    }
}
