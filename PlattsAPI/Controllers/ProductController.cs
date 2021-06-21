using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlattsAPI.Models;
using Amazon.DynamoDBv2.DataModel;

namespace PlattsAPI.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {        

        private readonly ILogger<ProductController> _logger;
        private readonly IDynamoDBContext _dynamoDBContext;

        public ProductController(IDynamoDBContext dynamoDBContext, ILogger<ProductController> logger)
        {
            _logger = logger;
            _dynamoDBContext = dynamoDBContext;
        }

        [HttpGet("getproduct/{productId}")]
        public async Task<IEnumerable<Product>> Get(int productId)
        {
            return await _dynamoDBContext.QueryAsync<Product>(productId).GetRemainingAsync();            

        }


    }
}
