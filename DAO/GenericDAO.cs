using MovieWinform.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWinform.DAO
{
    public class GenericDAO<T> where T : class
    {
        private DbSet<T> _entities;

        private DbContext _context;

        public DbSet<T> Entities { get { return _entities; } }
        public GenericDAO(DbContext context) 
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public T Insert(T entity)
        {
            var result = _entities.Add(entity);
            return result;
        }

        public T Update(T entity)
        {
            _entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public T Delete(T entity)
        {
            _entities.Remove(entity);
            return entity;
        }

        public DbSet<T> GetDBSet()
        {
            return _entities;
        }

        public T Find(int id)
        {
            var result = _entities.Find(id);
            return result as T;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
