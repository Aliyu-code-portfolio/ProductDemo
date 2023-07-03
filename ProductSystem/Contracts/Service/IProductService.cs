using ProductSystem.Models;
using ProductSystem.Utilities.DTOs;

namespace ProductSystem.Contracts.Service
{
    public interface IProductService
    {
        Task<IEnumerable<ProductToDisplayDto>> GetAllProduct();
        Task<ProductToDisplayDto> GetProductById(int id);
        Task RemoveProduct(int id);
        Task UpdateProduct(int id, ProductToUpdateDto product);
        ProductToDisplayDto CreateProduct(ProductToCreateDto product);
    }
}
