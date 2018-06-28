using Microsoft.EntityFrameworkCore;
using System;

namespace SchoolApi.DataAccess
{
    public class SchoolContext : DbContext
    {
        public DbSet<Login> Login { get; set; }
    }
}
