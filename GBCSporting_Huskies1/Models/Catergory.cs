using System.ComponentModel.DataAnnotations;

namespace GBCSporting_Huskies1.Models
{
    public class Catergory
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }
    }
}
