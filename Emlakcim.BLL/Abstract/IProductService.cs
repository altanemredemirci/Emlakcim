using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.BLL.Abstract
{
    public interface IProductService:IRepositoryService<Product>
    {
        List<Product> GetPopularAll();
    }
}
