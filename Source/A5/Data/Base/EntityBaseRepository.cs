using System.Collections.Generic;
using System.Linq;

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
        public T GetById(int id) => _context.Set<T>().FirstOrDefault(nameof =>nameof.Id == id);
        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();


    }
}