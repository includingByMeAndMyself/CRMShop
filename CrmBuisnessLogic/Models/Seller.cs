using System.Collections.Generic;


namespace CrmBuisnessLogic.Models
{
    public class Seller
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
