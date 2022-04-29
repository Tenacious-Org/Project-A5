using System.Collections.Generic;
using System.Linq;
using A5.Models;
using A5.Data.Base;

namespace A5.Data.Service
{
    public class DesignationService : EntityBaseRepository<Designation>, IDesignationService
    {
        public DesignationService(AppDbContext context) : base(context) { }

        public Designation GetByDepartmentId(int id) => _context.Set<T>().FirstOrDefault(nameof =>nameof.DepartmentId == id);
    
        
    }

}