using SA.AUTApp.DAL.Abstruct;
using SA.AUTApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.BLL.Abstract
{
    public interface IService<T> where T : IEntity
    {
        T GetById(int id);


        IEnumerable<T> GetAll();


        void Insert(T entity);


        void Update(T entity);



        void Delete(T entity);

      
    }
}
