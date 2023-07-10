using Microsoft.AspNetCore.Mvc;
using ProductSystem.Contracts.Service;
using ProductSystem.Utilities.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productService.GetAllProduct();
            return Ok(result);  
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var result =await _productService.GetProductById(id);
            return Ok(result);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductToCreateDto productToCreate)
        {
            var result = _productService.CreateProduct(productToCreate);
            return CreatedAtAction(nameof(GetById), new {id=result.Id},result);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProductToUpdateDto productToUpdateDto)
        {
            await _productService.UpdateProduct(id, productToUpdateDto);
            return NoContent();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.RemoveProduct(id);
            return NoContent(); 
        }
    }
}
