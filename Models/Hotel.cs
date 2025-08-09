using System.ComponentModel.DataAnnotations;

namespace EFMVCLastDayPractise.Models
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        [Required]
        public string HotelName { get; set; }

        public string? Location { get; set; }

        // Navigation Property - One Hotel has many Orders
        public ICollection<Order> Orders { get; set; }

    }
}
