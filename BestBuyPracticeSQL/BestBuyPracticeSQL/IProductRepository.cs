using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyPracticeSQL
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAllProducts(); //Stubbed out method
        void AddProduct(string newProductName);

    }
}
