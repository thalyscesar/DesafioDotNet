using CadastrosProdutos.Interfaces;
using CadastrosProdutos.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AspNetWebApiRest.Controllers
{
    public class ProductController : ControllerBase<ProductModel, IProductAppService>
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var products = _productAppService.GetAll();

            if (products.Count > 0) return Ok(products);

            return NotFound();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var product = _productAppService.GetById(id);

            if (product.Id > 0) return Ok(product);

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] ProductModel productModel)
        {
            
            if (!ModelState.IsValid) return IsValid(productModel);

            var productAdded = _productAppService.Add(productModel);

            if (productAdded) return Created("Product created", productModel);

            return BadRequest();
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody] ProductModel productModel)
        {
            if (!ModelState.IsValid) return IsValid(productModel);

            var productUpdated = _productAppService.Update(productModel);

            if (productUpdated) return Ok(productUpdated);

            return BadRequest();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var productDeleted = _productAppService.Remove(id);

            if (productDeleted) return Ok(productDeleted);

            return BadRequest();
        }

        [HttpPatch]
        [ActionName("PatchPrice")]
        public IHttpActionResult PatchPrice(int id, [FromBody] decimal price)
        {
            var updatePrice = _productAppService.UpdatePrice(id, price);

            if (updatePrice) return Ok(updatePrice);

            return BadRequest();
        }
    }
}
