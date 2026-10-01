using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.DAL.Abstract
{
    //<T> Generic Type: Kendisine Miras yoluyla bir class tanımı gönderilecek. Gönderilen class a görem metotlar çalışacak.
    public interface IRepository<T> where T : class
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
