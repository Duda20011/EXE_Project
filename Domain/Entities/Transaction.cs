using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Transaction :BaseEntity
    {
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        //public virtual Order Order { get; set; }
    }
}
