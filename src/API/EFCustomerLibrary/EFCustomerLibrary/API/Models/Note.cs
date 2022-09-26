using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCustomerLibrary.Models
{

        public class Note
        {
            [Key]
            public int Id { get; set; }

            [ForeignKey("Customer")]
            public int CustomerId { get; set; }

            [MaxLength(50)]
            public string NoteLine { get; set; }



        }
    }
