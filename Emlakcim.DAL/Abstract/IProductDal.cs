using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.DAL.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        List<Product> GetPopularAll();
    }
}
