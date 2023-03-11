using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal abstract class Product : IProduct
    {
        #region Attributes
        private float _discountPercentaje;
        private float _taxPercentaje;
        #endregion

        #region Properties
        public float DiscountPercentaje 
        {
            get => _discountPercentaje; 
            set => _discountPercentaje = ValidatePercentaje(value); 
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public float TaxPercentaje 
        {
            get => _taxPercentaje;
            set => _taxPercentaje = ValidatePercentaje(value);
        }
        #endregion

        #region Methods
        public abstract decimal CalculateDiscount();

        public abstract decimal CalculateTax();

        public abstract decimal CalculateValueToPay();

        public override string? ToString()
        {
            return base.ToString();
        }

        private float ValidatePercentaje(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("The percentaje is not valid");
            }
            return value * 100;
        }
        #endregion
    }
}
