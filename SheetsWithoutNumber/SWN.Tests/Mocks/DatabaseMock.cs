namespace SWN.Tests.Mocks
{
    using System;
    using SWN.Data;
    using Microsoft.EntityFrameworkCore;

    public static class DatabaseMock
    {
        public static SWNDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<SWNDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;

                return new SWNDbContext(dbContextOptions);
            }
        }
    }
}
