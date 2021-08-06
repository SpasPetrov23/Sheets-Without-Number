namespace SheetsWithoutNumber.Services.User
{
    using SWN.Data.Models;

    public interface IUserService
    {
        public User GetUserById(string userId);
    }
}
