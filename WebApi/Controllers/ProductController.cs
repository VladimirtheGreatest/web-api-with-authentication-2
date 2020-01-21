using ApiLogic.Models;
using ApiLogic.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        // GET api/product
        public List<ProductModel> Get()
        {
            ProductProcessor data = new ProductProcessor();

            return data.GetProducts();

        }
    }
}
