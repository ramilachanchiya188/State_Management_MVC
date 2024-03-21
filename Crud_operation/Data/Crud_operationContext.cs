using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_operation.Models;

namespace Crud_operation.Data
{
    public class Crud_operationContext : DbContext
    {
        public Crud_operationContext (DbContextOptions<Crud_operationContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_operation.Models.User> User { get; set; } = default!;
    }
}
