using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinAPPcial.Api.Models
{
    public class FinAPPcialContext : DbContext
    {
        public FinAPPcialContext(DbContextOptions<FinAPPcialContext> options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
