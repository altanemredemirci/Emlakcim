using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.DAL.Concrete.EfCore
{
    public class EfCoreProductTypeDal:EfCoreGenericRepository<ProductType, DataContext>,IProductTypeDal
    {
        public override List<ProductType> GetAll(Expression<Func<ProductType, bool>> filter)
        {
            using(var context = new DataContext())
            {
                //AsNoTracking(): Okuma işlemi sonrası bu komutu unut.
                //AsQueryable(): Komutu SQL'e taşıma çünkü daha tamamlanmadı.
                var productTypes = context.ProductTypes.Include(i => i.Products).AsNoTracking().AsQueryable();

                if(filter != null)
                {
                    productTypes = productTypes.Where(filter);
                }

                return productTypes.ToList();
            }
            
        }
    }
}
