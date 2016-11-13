using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KendoUI.Infrastructure;
using KendoUI.Infrastructure.Enum;

namespace KendoUI.Domain
{
    public class Rate:Entity
    {
        public string EmployeePosition { get; set; }
        public decimal AmountPerPeriod { get; set; }
        public Period Period { get; set; }

    }
}
