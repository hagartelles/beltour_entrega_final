using beltour.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace beltour.Context
{
    public class DbContextDestiny : DbContext
    {
        public DbContextDestiny(DbContextOptions<DbContextDestiny> options) : base(options)
        { }

        public DbSet<Destiny>? Destinies { get; set; }
    }
}
