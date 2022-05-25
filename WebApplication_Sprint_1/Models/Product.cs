using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Sprint_1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Double UnitCost { get; set; }
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public string Description { get; set; }
       
        public Category Category { get; set; }
        



    }
}
