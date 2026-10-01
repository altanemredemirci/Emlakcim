using Emlakcim.BLL.Abstract;
using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.BLL.Concrete
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IProductTypeDal _productTypeDal;

        public ProductTypeService(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }

        public void Create(ProductType entity)
        {
            _productTypeDal.Create(entity);
        }

        public void Delete(ProductType entity)
        {
            _productTypeDal.Delete(entity);
        }

        public List<ProductType> GetAll(Expression<Func<ProductType, bool>> filter = null)
        {
            return _productTypeDal.GetAll(filter);
        }

        public ProductType GetById(int id)
        {
           return _productTypeDal.GetById(id);
        }

        public void Update(ProductType entity)
        {
            _productTypeDal.Update(entity);
        }
    }
}
