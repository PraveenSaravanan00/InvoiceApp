using System.ComponentModel.DataAnnotations;

namespace InvoiceApplication.Models
{
    public class InvoiceForm
    {
        [Key]
        public int IFId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public int Gst { get; set; }

        public int Amount { get; set; }
    }
}
