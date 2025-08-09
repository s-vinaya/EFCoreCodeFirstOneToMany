using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFMVCLastDayPractise.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public string Item { get; set; }

        public decimal Price { get; set; }

        public int HotelId { set; get; }
        [ForeignKey("HotelId")]
        public Hotel Hotel { get; set; }
    }
}
