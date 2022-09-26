using System.ComponentModel.DataAnnotations;

namespace EFCustomerLibrary.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
       // public List<Address> Addresses { get; set; } = new List<Address>();

        [Phone]
        public string? PhoneNumber { get; set; } = string.Empty;

        [EmailAddress]
        [MaxLength(50)]
        public string? Email { get; set; } = string.Empty;

        //public List<Note> Notes { get; set; } = new List<Note>();

        public decimal? TotalPurchasesAmount { get; set; } = 0;


    }
}
