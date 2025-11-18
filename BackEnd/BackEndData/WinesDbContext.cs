using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEndData.Models;

namespace BackEndData
{
    public class WinesDbContext:DbContext
    {
        public DbSet<Wines> Wines { get; set; }
        public WinesDbContext(DbContextOptions<WinesDbContext> ctx) : base(ctx)
        {
        }
       
    }
}
