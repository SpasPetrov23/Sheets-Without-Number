using System;
using System.ComponentModel.DataAnnotations;

using static SWN.Data.DataConstants.Game;

namespace SheetsWithoutNumber.Models.Games
{
    public class GameCreateFormModel
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
