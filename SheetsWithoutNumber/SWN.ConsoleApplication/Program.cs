namespace SWN.ConsoleApplication
{
    using Microsoft.EntityFrameworkCore;
    using SWN.Data;
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            var db = new SWNDbContext();
            db.Database.Migrate();
        }
    }
}
