using Muhasebe.DataAccessLayer.Abstarct;
using Muhasebe.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T entity)
        {
            using var _context = new Context();
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var _context = new Context();
            //var dene= _context.Set<T>().ToList();

            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var _context = new Context();
            

            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            using var _context = new Context();
            _context.Add(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using var _context = new Context();
            
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            using var _context = new Context();
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
