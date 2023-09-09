using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Seller : BaseEntity
    {
        public string SellerName { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }

    }
}
