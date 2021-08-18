namespace SheetsWithoutNumber.Models.Games
{
    using SheetsWithoutNumber.Services.Game;
    using System.ComponentModel.DataAnnotations;

    using static SWN.Data.DataConstants.GameData;

    public class GameFormModel : IGameModel
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
