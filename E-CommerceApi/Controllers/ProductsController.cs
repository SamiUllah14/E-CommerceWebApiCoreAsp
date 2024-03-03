using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using E_CommerceApi.Data;
using E_CommerceApi.Models;
using E_CommerceApi.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using E_CommerceApi.Repository;

namespace E_CommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _dbProduct;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepository dbProduct, IMapper mapper)
        {
            _dbProduct = dbProduct;
            _mapper = mapper;
        }

        #region GET Methods

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<ActionResult<ApiResponse>> GetProductsDto()
        {
            try
            {
                var products = await _dbProduct.GetAllAsync();
                var results = _mapper.Map<List<ProductsDtos>>(products);
                return Ok(new ApiResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Results = results,
                });
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully, log them, and provide a user-friendly response
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "An error occurred while retrieving products." }
                });
            }
        }

        [HttpGet("{id:int}", Name = "GetProducts")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<ApiResponse>> GetProduct(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "Invalid ID." }
                });
            }

            try
            {
                var product = await _dbProduct.GetAsync(p => p.Id == id);

                if (product == null || product.Count == 0)
                {
                    return NotFound(new ApiResponse
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        IsSuccess = false,
                        ErrorMessages = new List<string> { "Product not found." }
                    });
                }

                var productDto = _mapper.Map<ProductsDtos>(product.FirstOrDefault());
                return Ok(new ApiResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Results = productDto
                });
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "An error occurred while retrieving product details." }
                });
            }
        }

        #endregion

        #region POST Method

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<ApiResponse>> CreateProduct([FromBody] ProductsCreateDtos product)
        {
            if (product == null)
            {
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "Product data is invalid." }
                });
            }

            try
            {
                var existingProduct = await _dbProduct.GetAsync(p => p.Name.ToLower() == product.Name.ToLower());

                if (existingProduct != null && existingProduct.Count > 0)
                {
                    return BadRequest(new ApiResponse
                    {
                        StatusCode = HttpStatusCode.BadRequest,
                        IsSuccess = false,
                        ErrorMessages = new List<string> { "Product already exists!" }
                    });
                }

                var model = _mapper.Map<ProductClass>(product);
                await _dbProduct.CreateAsync(model);
                await _dbProduct.SaveAsync();

                var productDto = _mapper.Map<ProductsDtos>(model);
                return CreatedAtAction(nameof(GetProduct), new { id = model.Id }, productDto);
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "An error occurred while creating the product." }
                });
            }
        }

        #endregion

        #region DELETE Method

        [HttpDelete("{id:int}", Name = "DeleteProducts")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "Invalid ID." }
                });
            }

            try
            {
                var product = await _dbProduct.GetAsync(p => p.Id == id);

                if (product == null || product.Count == 0)
                {
                    return NotFound(new ApiResponse
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        IsSuccess = false,
                        ErrorMessages = new List<string> { "Product not found." }
                    });
                }

                await _dbProduct.RemoveAsync(product.FirstOrDefault());
                await _dbProduct.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "An error occurred while deleting the product." }
                });
            }
        }

        #endregion

        #region PUT Method

        [HttpPut("{id:int}", Name = "UpdateProducts")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductsUpdateDtos updatedProduct)
        {
            if (id <= 0)
            {
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "Invalid ID." }
                });
            }

            if (updatedProduct == null)
            {
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "Product data is invalid." }
                });
            }

            try
            {
                var existingProduct = await _dbProduct.GetAsync(p => p.Id == id);

                if (existingProduct == null || existingProduct.Count == 0)
                {
                    return NotFound(new ApiResponse
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        IsSuccess = false,
                        ErrorMessages = new List<string> { "Product not found." }
                    });
                }

                var productToUpdate = existingProduct.FirstOrDefault();
                _mapper.Map(updatedProduct, productToUpdate);

                await _dbProduct.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "An error occurred while updating the product." }
                });
            }
        }

        #endregion

        #region PATCH Method

        [HttpPatch("{id:int}", Name = "PatchProducts")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> PatchProduct(int id, [FromBody] JsonPatchDocument<ProductsUpdateDtos> patchDoc)
        {
            if (id <= 0)
            {
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "Invalid ID." }
                });
            }

            if (patchDoc == null)
            {
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "Patch document is invalid." }
                });
            }

            try
            {
                var existingProduct = await _dbProduct.GetAsync(p => p.Id == id);

                if (existingProduct == null || existingProduct.Count == 0)
                {
                    return NotFound(new ApiResponse
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        IsSuccess = false,
                        ErrorMessages = new List<string> { "Product not found." }
                    });
                }

                var productToPatch = _mapper.Map<ProductsUpdateDtos>(existingProduct.FirstOrDefault());
                patchDoc.ApplyTo(productToPatch, ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _mapper.Map(productToPatch, existingProduct.FirstOrDefault());

                await _dbProduct.SaveAsync();

                return Ok(new ApiResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    IsSuccess = true,
                    Results = _mapper.Map<ProductsDtos>(existingProduct.FirstOrDefault())
                });
            }
            catch (Exception ex)
            {
                // Handle exceptions gracefully
                return BadRequest(new ApiResponse
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    IsSuccess = false,
                    ErrorMessages = new List<string> { "An error occurred while patching the product." }
                });
            }
        }

        #endregion
    }
}
