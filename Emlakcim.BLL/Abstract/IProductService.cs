using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.BLL.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);

        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
