namespace SheetsWithoutNumber.Services.Game
{
    public interface IGameService
    {
        public int Create(string name, string description, int maxPlayers, string gameImage, string gameMasterId);
    }
}
