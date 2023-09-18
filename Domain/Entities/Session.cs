using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Session :BaseEntity
    {
        public string SessionName { get; set; }

       //public virtual List<Product> Products { get; set; }
       public virtual List<Customer> Customers{get;set;}
       public virtual List<Order> Orders { get; set; } 
    }
}
