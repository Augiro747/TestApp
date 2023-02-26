using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Order
    {
        public int id { get; set; }
        [Required]
        public string recipient_city { get; set; }
        [Required]
        public string recipient_adress { get; set; }
        [Required]
        public string sender_city { get; set; }
        [Required]
        public string sender_adress { get; set; }
        [Required]
        public float weight { get; set; }
        [Required]
        public DateTime pickup_date { get; set; }
    }
}
