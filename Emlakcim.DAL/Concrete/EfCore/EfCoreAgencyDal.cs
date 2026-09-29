using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.DAL.Concrete.EfCore
{
    public class EfCoreAgencyDal : EfCoreGenericRepository<Agency,DataContext>, IAgencyDal
    {
        
    }
}
