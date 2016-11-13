using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using KendoUI.Infrastructure;

namespace KendoUI.Domain
{
    public class Employee:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
