using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.DAL.Concrete.EfCore
{
    internal class EfCoreProductDetailDal:EfCoreGenericRepository<ProductDetail,DataContext>,IProductDetailDal
    {
    }
}
