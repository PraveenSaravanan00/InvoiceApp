
using System.ComponentModel.DataAnnotations;

namespace InvoiceApplication.Models
{
    public class AddDetails
    {
        [Key]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }

        public int Gst { get; set; }

    }
}