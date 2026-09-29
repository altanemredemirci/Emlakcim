using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.DAL.Concrete.EfCore
{
    internal class EfCoreSliderDal : ISliderDal
    {
        private readonly DataContext _context;

        public EfCoreSliderDal(DataContext context)
        {
            _context = context;
        }

        public List<Slider> GetAll()
        {
            return _context.Sliders.ToList();
        }
    }
}
