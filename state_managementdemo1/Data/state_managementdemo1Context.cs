using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using state_managementdemo1.Models;

namespace state_managementdemo1.Data
{
    public class state_managementdemo1Context : DbContext
    {
        public state_managementdemo1Context (DbContextOptions<state_managementdemo1Context> options)
            : base(options)
        {
        }

        public DbSet<state_managementdemo1.Models.Class> Class { get; set; } = default!;
    }
}
