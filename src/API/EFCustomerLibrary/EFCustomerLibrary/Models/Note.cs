using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCustomerLibrary.Models
{

        public class Note
        {
            public int Id { get; set; }

            [ForeignKey("CustomerClass")]
            public int CustomerId { get; set; }

            [MaxLength(50)]
            public string NoteLine { get; set; }

            [Key]
            public int NoteId { get; set; }


        }
    }
