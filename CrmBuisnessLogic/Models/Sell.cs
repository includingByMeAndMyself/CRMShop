

namespace CrmBuisnessLogic.Models
{
    public class Sell
    {
        public int Id { get; set; }

        public int CheckId { get; set; }

        public int ProductId { get; set; }

        public Check Check { get; set; }

        public Product Product { get; set; }
    }
}
