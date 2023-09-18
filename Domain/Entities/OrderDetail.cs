using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderDetail :BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

       // public virtual List<Products> Products { get; set; }
    }
}
