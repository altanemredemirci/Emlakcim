using Emlakcim.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Emlakcim.BLL.Abstract
{
    public interface IRepositoryService<T> where T:class
    {
        //Expression : i=> i.Id>3 --- filter=null: expression gelmezse filter'ı default null 
        List<T> GetAll(Expression<Func<T,bool>> filter=null); 
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
