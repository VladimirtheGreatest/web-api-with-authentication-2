using ApiLogic.Internal;
using ApiLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLogic.DataAccess
{
    public class ProductProcessor
    {
            public List<ProductModel> GetProducts()
            {
                SqlDataAccess sql = new SqlDataAccess();

                //passing stored procedure, and choosing the database for our querie, check sqldataaccess
                var output = sql.LoadData<ProductModel, dynamic>("spProduct_GetAll", new { }, "Database1");

                return output;
            }
        
    }
}
