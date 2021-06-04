using ProjAspNet.Data;
using System.Linq;
using System.Collections.Generic;
using ProjAspNet.Models;

namespace ProjAspNet.Services
{
    public class DepartamentServices
    {   
        private readonly ProjAspNetContext _context;

        public DepartamentServices(ProjAspNetContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
