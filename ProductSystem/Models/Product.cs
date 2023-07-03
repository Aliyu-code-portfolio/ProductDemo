using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required"), MaxLength(20,ErrorMessage ="Cannot be more than 20 characters")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
    }
}
