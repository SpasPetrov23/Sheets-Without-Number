namespace SheetsWithoutNumber.Infrastructure
{
    using SheetsWithoutNumber.Services.Character;
    using SheetsWithoutNumber.Services.Game;

    public static class ModelExtensions
    {
        public static string GetGameUrlInfo(this IGameModel game)
            => game.Name + "-" + game.PlayersMax;

        public static string GetCharacterUrlInfo(this ICharacterModel character)
            => character.Name + "-" + character.Background + " " + character.Class;
    }
}
