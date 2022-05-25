using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Sprint_1.Models
{
    public class Customer
    {
        
        public int Id { get; set; }
        public string UserName { get; set; }
        public String Password { get; set; }
        public string Email { get; set; }
        public string DeliveryAddress { get; set; }
        
    }
}
