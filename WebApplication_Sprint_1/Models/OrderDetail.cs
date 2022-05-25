using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Sprint_1.Models
{
    
    public class OrderDetail
    {
       [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
        public Double UnitCost { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }

    }
}
