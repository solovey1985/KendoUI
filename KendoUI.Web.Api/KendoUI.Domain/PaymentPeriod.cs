using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KendoUI.Infrastructure;

namespace KendoUI.Domain
{
    public class PaymentPeriod: ValueObject<PaymentPeriod>
    {
        public DateTime Since { get; set; }

        public DateTime Till { get; set; }

        #region ValueObject
        public override bool Equals(PaymentPeriod other)
        {
            if (other == null)
            {
                return false;
            }

            return Till == other.Till && Since == other.Since;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            PaymentPeriod other = obj as PaymentPeriod;
            if (other == null )
            {
                return false;
            }

            return Equals(other);
        }

        public override int GetHashCode()
        {
            int shift = 4;

            return  shift*Since.GetHashCode()*Till.GetHashCode();
        }
        #endregion
    }
}
