using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KendoUI.Infrastructure
{

    public abstract class ValueObject<T> : IEquatable<T> where T : ValueObject<T>
    {
        public abstract bool Equals(T other);
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();

    }
}
