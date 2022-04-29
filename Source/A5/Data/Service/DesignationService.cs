using System.Collections.Generic;
using System.Linq;
using A5.Models;
using A5.Data.Base;

namespace A5.Data.Service
{
    public class DesignationService : EntityBaseRepository<Designation>, IDesignationService
    {
        private readonly AppDbContext _context;
        public DesignationService(AppDbContext context) : base(context) { }

        
        public IEnumerable<Designation> GetByDepartmentId(int id) => _context.Set<Designation>().FirstOrDefault(nameof =>nameof.DepartmentId == id);
    
        
    }

}