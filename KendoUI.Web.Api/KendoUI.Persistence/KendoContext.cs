using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoUI.Persistence
{
    public class KendoContext<TContext>: DbContext where TContext: DbContext
    {
        protected KendoContext() : base("name=KendoEntity")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = true;
        }
    }
}
