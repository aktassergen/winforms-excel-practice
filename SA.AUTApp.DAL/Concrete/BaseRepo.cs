using Microsoft.EntityFrameworkCore;
using SA.AUTApp.DAL.Abstruct;
using SA.AUTApp.DAL.Context;
using SA.AUTApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.DAL.Concrete
{
    public class BaseRepo<T> : IRepo<T> where T : class, IEntity
    {
        private SA_AUTAppDbContext _dbContext { get; set; }
        protected DbSet<T> _dbSet;
        public BaseRepo(SA_AUTAppDbContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();

        }
        public BaseRepo()
        {
        }

    

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            _dbContext.Add(entity);    
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            SaveChanges();
        }
       // public IQueryable<T> GetQueryable() => _dbSet.AsQueryable<T>();
    }
}
