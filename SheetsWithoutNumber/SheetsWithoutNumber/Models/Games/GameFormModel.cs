using System;
using System.ComponentModel.DataAnnotations;

using static SWN.Data.DataConstants.GameData;

namespace SheetsWithoutNumber.Models.Games
{
    public class GameFormModel
    {
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Display(Name = "Maximum Players")]
        public int PlayersMax { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [Url]
        [Display(Name = "Image")]
        public string GameImage { get; set; }
    }
}
