using Emlakcim.BLL.Abstract;
using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.BLL.Concrete
{
    public class WhoWeAreService : IWhoWeAreService
    {
        private readonly IWhoWeAreDal _whoWeAreDal;

        public WhoWeAreService(IWhoWeAreDal whoWeAreDal)
        {
            _whoWeAreDal = whoWeAreDal;
        }

        public WhoWeAre GetOne()
        {
            return _whoWeAreDal.GetOne();
        }

        public void Update(WhoWeAre entity)
        {
            _whoWeAreDal.Update(entity);
        }
    }
}
