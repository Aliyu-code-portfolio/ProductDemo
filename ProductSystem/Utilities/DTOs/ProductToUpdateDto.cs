using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductSystem.Utilities.DTOs
{
    public record ProductToUpdateDto
    {
        [Required(ErrorMessage = "Name is required"), MaxLength(20, ErrorMessage = "Cannot be more than 20 characters")]
        public string Name { get; init; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; init; }
    }
}
