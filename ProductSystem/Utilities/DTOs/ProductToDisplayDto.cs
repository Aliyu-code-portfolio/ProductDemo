using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductSystem.Utilities.DTOs
{
    public record ProductToDisplayDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
