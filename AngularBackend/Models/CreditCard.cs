using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularBackend.Models
{
    public class CreditCard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="varchar(16)")]
        public string Holder { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string NoCard{ get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpiredDate{ get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}
