using System;
using System.Collections.Generic;

namespace CrmBuisnessLogic.Models
{
    public class Check
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int SellerId { get; set; }

        public Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{Id} from {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
