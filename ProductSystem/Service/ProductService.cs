using AutoMapper;
using ProductSystem.Contracts.Repository;
using ProductSystem.Contracts.Service;
using ProductSystem.Models;
using ProductSystem.Utilities.DTOs;

namespace ProductSystem.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public ProductToDisplayDto CreateProduct(ProductToCreateDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productRepository.CreateProduct(product);
            var productCreated = _mapper.Map<ProductToDisplayDto>(product);
            return productCreated;
        }

        public async Task<IEnumerable<ProductToDisplayDto>> GetAllProduct()
        {
            var products = await _productRepository.GetAllProduct();
            var productDto = _mapper.Map<IEnumerable<ProductToDisplayDto>>(products);
            return productDto;
        }

        public async Task<ProductToDisplayDto> GetProductById(int id)
        {
            var product = await _productRepository.GetProductById(id);
            var productDto = _mapper.Map<ProductToDisplayDto>(product);
            return productDto;
        }

        public async Task RemoveProduct(int id)
        {
            var product = await _productRepository.GetProductById(id) ?? throw new Exception();
            _productRepository.RemoveProduct(product);
        }

        public async Task UpdateProduct(int id, ProductToUpdateDto productDto)
        {
            var productDb = await _productRepository.GetProductById(id)??throw new Exception();
            var product = _mapper.Map<Product>(productDto);
            _productRepository.UpdateProduct(product);
        }
    }
}
