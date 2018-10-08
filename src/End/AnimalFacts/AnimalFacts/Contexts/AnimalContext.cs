using AnimalFacts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFacts.Contexts
{
    public class AnimalContext : DbContext
    {
        public DbSet<AnimalFact> AnimalFacts { get; set; }
        public AnimalContext(DbContextOptions options)
            : base(options)
        {

        }

        public AnimalContext()
        {

        }
    }
}
