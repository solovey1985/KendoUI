using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KendoUI.Domain;

namespace KendoUI.Persistence
{
    public class EmployeeRepository
    {
        private EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }


    }
}
