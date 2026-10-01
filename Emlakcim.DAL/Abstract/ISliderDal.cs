using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.DAL.Abstract
{
    public interface ISliderDal
    {
        Slider GetByPage(Expression<Func<Slider, bool>> filter = null); 
    }
}
