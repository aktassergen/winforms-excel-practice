using SA.AUTApp.BLL.Abstract;
using SA.AUTApp.DAL.Concrete;
using SA.AUTApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.BLL.Concrete
{
    public class BaseService<T> : IService<T> where T : class, IEntity
    {
        protected BaseRepo<T> _repo;
        public BaseService(BaseRepo<T> baseRepo)
        {
            _repo = baseRepo;
        }
        public  T GetById(int id)
        {
            return _repo.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repo.GetAll();
        }

        public  void Insert(T entity)
        {
            _repo.Insert(entity);
        }

        public  void Update(T entity)
        {
            _repo.Update(entity);
        }

        public void Delete(T entity)
        {
            _repo.Delete(entity);
        }
    }
}
