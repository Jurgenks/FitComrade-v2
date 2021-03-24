using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitComradeV2.Data
{
    public class FitComradeV2Context: DbContext
    {
        public FitComradeV2Context()
        {
        }
        public FitComradeV2Context(DbContextOptions<FitComradeV2Context> options)
            : base(options)
        {
        }

        public DbSet<Models.Profile> Profiles { get; set; }

        public DbSet<Models.Customer> Customers { get; set; }

        public DbSet<Models.Order> Orders { get; set; }

        public DbSet<Models.OrderDetail> OrderDetails { get; set; }
    }
}
