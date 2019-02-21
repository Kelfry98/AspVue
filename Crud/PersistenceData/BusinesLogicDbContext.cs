using Crud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.PersisteceData
{
    public class BusinesLogicDbContext: DbContext
    {
        public BusinesLogicDbContext(DbContextOptions<BusinesLogicDbContext> options) 
            : base(options) { }
        public DbSet<Person> Persons { get; set; }
    }

}
