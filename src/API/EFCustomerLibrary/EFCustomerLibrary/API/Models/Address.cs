using EFCustomerLibrary.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCustomerLibrary.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstLine { get; set; } = String.Empty;

        [MaxLength(100)]
        public string SecondLine { get; set; } = String.Empty;

        [EnumDataType(typeof(AddressType), ErrorMessage = "Please enter 'Shipping' or 'Billing'")]
        public AddressType Type { get; set; } = AddressType.Billing;

        [MaxLength(50)]
        [Required]
        public string City { get; set; } = String.Empty;

        [MaxLength(6)]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter only digits")]
        public string PostalCode { get; set; } = String.Empty;

        [MaxLength(20)]
        [Required]
        public string State { get; set; } = String.Empty;

        [EnumDataType(typeof(AvailableCountries))]
        public AvailableCountries Country { get; set; } = AvailableCountries.Canada;

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
