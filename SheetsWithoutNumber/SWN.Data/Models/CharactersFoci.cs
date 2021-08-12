namespace SWN.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CharactersFoci
    {
        [Required]
        public int Id { get; set; }

        public int CharacterId { get; set; }

        public Character Character { get; set; }

        public int FocusId { get; set; }

        public Focus Focus { get; set; }

        [Required]
        public string FocusName { get; set; }

        public int FocusLevel { get; set; }

        [Required]
        public string FocusDescription { get; set; }
    }
}
