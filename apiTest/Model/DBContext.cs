using System;

using Microsoft.EntityFrameworkCore;

namespace apiTest.Model
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
       // public DbSet<Book> Books { get; set; }
    }
}

