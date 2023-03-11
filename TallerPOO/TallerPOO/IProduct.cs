using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal interface IProduct
    {
        #region Methods
        public decimal CalculateDiscount();

        public decimal CalculateTax();

        public decimal CalculateValueToPay();
        #endregion
    }
}
