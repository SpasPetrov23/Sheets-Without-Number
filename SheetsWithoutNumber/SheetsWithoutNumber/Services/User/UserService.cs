namespace SheetsWithoutNumber.Services.User
{
    using SWN.Data;
    using SWN.Data.Models;
    using System.Linq;

    public class UserService : IUserService
    {
        private readonly SWNDbContext data;

        public UserService(SWNDbContext data)
        {
            this.data = data;
        }

        public User GetUserById(string userId)
        {
            var user = data.Users.FirstOrDefault(u => u.Id == userId);

            return user;
        }
    }
}
