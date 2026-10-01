using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.DAL.Concrete.EfCore
{
    public class EfCoreSliderDal : ISliderDal
    {
        
        public Slider GetByPage(Expression<Func<Slider, bool>> filter)
        {
            using(var context = new DataContext())
            {
                return context.Sliders.Where(filter).FirstOrDefault();
            }            
        }
    }
}
