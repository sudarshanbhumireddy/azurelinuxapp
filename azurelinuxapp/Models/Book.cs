using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azurelinuxapp.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string description { get; set; }

        public double cost { get; set; }
    }
}
