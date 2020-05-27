using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewTrashCol.Models;

namespace NewTrashCol.Data
{
    public class NewTrashColContext : DbContext
    {
        public NewTrashColContext (DbContextOptions<NewTrashColContext> options)
            : base(options)
        {
        }

        public DbSet<NewTrashCol.Models.Customer> Customer { get; set; }

        public DbSet<NewTrashCol.Models.Employee> Employee { get; set; }
    }
}
