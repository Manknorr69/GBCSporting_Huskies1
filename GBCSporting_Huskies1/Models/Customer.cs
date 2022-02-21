using System.ComponentModel.DataAnnotations;

namespace GBCSporting_Huskies1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]

        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please Enter City")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Please Enter State")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Please Enter Postalcode")]
        public string? Postalcode { get; set; }

        public DateTime DateAdded { set; get; }

        public int CategoryId { set; get; }

        [Range(1, 10, ErrorMessage = "Please select a Country")]
        public Catergory? Catergory { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public String Slug => Firstname?.Replace(' ','-').ToLower()
            + '-'+ Lastname?.Replace(' ','-').ToLower();
    }
}
