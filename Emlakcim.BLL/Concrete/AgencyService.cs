using Emlakcim.BLL.Abstract;
using Emlakcim.DAL.Abstract;
using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.BLL.Concrete
{
    public class AgencyService : IAgencyService
    {
        private readonly IAgencyDal _agencyDal;

        public AgencyService(IAgencyDal agencyDal)
        {
            _agencyDal = agencyDal;
        }

        public void Create(Agency entity)
        {
            _agencyDal.Create(entity);
        }

        public void Delete(Agency entity)
        {
            _agencyDal.Delete(entity);
        }

        public List<Agency> GetAll(Expression<Func<Agency, bool>> filter = null)
        {
            return _agencyDal.GetAll(filter);
        }

        public Agency GetById(int id)
        {
            return _agencyDal.GetById(id);
        }        

        public void Update(Agency entity)
        {
            _agencyDal.Update(entity);
        }
    }
}
