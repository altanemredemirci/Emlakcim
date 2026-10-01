using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.BLL.Abstract
{
    public interface ISliderService
    {
        Slider GetByPage(Expression <Func<Slider,bool>> filter=null);
    }
}
