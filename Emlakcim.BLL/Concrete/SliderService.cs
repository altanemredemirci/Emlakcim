using Emlakcim.BLL.Abstract;
using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.BLL.Concrete
{
    public class SliderService : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderService(ISliderDal sliderDal)
        {
            _sliderDal=sliderDal;
        }

        public Slider GetByPage(Expression<Func<Slider, bool>> filter)
        {
            return _sliderDal.GetByPage(filter);
        }
    }
}
