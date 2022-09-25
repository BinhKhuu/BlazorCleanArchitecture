using BlazorProducts.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProducts.Core.Repositories
{
    public interface IProductHttpRepository
    {
        Task<List<Product>> GetProducts();
    }
}
