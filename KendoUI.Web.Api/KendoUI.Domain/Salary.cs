using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KendoUI.Infrastructure;

namespace KendoUI.Domain
{
    public class Salary:Entity
    {
        public PaymentPeriod Period { get; set; }

        public int RateId { get; set; }
        
       
    }
}
