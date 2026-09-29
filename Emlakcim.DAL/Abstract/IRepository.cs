using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakcim.DAL.Abstract
{
    //<T> Generic Type
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
