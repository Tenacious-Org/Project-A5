using System.Collections.Generic;
using System.Linq;
using A5.Models;

namespace A5.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        //Methods
        public bool Create(T entity)
        {
            bool result = false;
            if(entity != null)
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Disable(T entity, int id)
        {
            bool result = false;
            if(entity != null && entity.Id == id)
            {
                var disable = _context.Set<T>().FirstOrDefault(nameof =>nameof.Id == id);
                disable.IsActive = false;
                _context.SaveChanges();
                result = true;
            }
            return result;
        }

        public bool Update(T entity, int id)
        {
            bool result = false;
            if(entity != null && entity.Id == id)
            {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
                result = true;
            }
            return result;
        }

        public T GetById(int id) => _context.Set<T>().FirstOrDefault(nameof =>nameof.Id == id);
        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();


    }
}