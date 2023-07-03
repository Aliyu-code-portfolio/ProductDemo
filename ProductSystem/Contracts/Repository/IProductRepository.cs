using ProductSystem.Models;

namespace ProductSystem.Contracts.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> GetProductById(int id);
        void RemoveProduct(Product product);
        void UpdateProduct(Product product);
        void CreateProduct(Product product);    
    }
}
