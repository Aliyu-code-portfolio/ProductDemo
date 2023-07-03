using Microsoft.EntityFrameworkCore;
using ProductSystem.Contracts.Repository;
using ProductSystem.Models;

namespace ProductSystem.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public ProductRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void CreateProduct(Product product)
        {
            _repositoryContext.Set<Product>().Add(product);
            _repositoryContext.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
           return await _repositoryContext.Set<Product>().ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _repositoryContext.Set<Product>()
                .Where(item => item.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public void RemoveProduct(Product product)
        {
            _repositoryContext.Set<Product>().Remove(product);
            _repositoryContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _repositoryContext.Set<Product>().Update(product);
            _repositoryContext.SaveChanges();
        }
    }
}
