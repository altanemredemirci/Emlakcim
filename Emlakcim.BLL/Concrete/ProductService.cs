using Emlakcim.BLL.Abstract;
using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.BLL.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;

        //Injection : Başka bir katmandan bu class'a bir yapıyı enjekte ettik.
        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
