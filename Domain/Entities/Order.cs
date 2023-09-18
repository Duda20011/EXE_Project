using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order :BaseEntity
    {
        public bool Status { get; set; } 

        public int Quantity { get; set; }

        public decimal Total {get; set; }

        public virtual OrderDetail OrderDetails { get; set; }

        public virtual Transaction Transaction { get; set; }

        public virtual Session Session { get; set; }

        /*public virtual Wallet Wallet { get; set; }*/
    }
}
