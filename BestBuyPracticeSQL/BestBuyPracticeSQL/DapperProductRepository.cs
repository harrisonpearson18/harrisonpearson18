using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace BestBuyPracticeSQL
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;

        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
        }

        public void AddProduct(string newProductName)
        {
            _connection.Execute("INSERT INTO PRODUCT (Name) VALUES (@productName);",
             new { productName = newProductName });
        }


    }
}
