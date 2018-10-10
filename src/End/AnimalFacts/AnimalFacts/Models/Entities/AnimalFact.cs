using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalFacts.Models
{
    public class AnimalFact
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public string Fact { get; set; }
    }
}
