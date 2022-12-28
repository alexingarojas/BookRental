using Microsoft.EntityFrameworkCore;
using System;


namespace Infrastucture.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        { 
            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}
