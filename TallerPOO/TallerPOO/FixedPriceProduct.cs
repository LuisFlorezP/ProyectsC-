using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class FixedPriceProduct : Product
    {
        #region Attributes
        private decimal _price;
        #endregion

        #region Properties
        public decimal Price 
        {
            get => _price; 
            set => _price = ValidateGreatherThanZero(value); 
        }
        #endregion

        #region Methods
        public override decimal CalculateDiscount()
        {
            return Price * (((decimal)DiscountPercentaje) / 100);
            
        }

        public override decimal CalculateTax()
        {
            return Price * (((decimal)TaxPercentaje) / 100);
        }

        public override decimal CalculateValueToPay()
        {
            return Price - CalculateDiscount() + CalculateTax();
        }

        public override string? ToString()
        {
            return
                $"{Id}        {Name}\r\n" +
                    $"         % Discount...........: {DiscountPercentaje,26:C2}%\r\n" +
                        $"         % Tax................: {TaxPercentaje,26:C2}%\r\n" +
                            $"         Price................: {Price,27:C2}\r\n" +
                                $"         Discount value.......: {CalculateDiscount(),27:C2}\r\n" +
                                    $"         Tax value............: {CalculateTax(),27:C2}\r\n" +
                                        $"         Value to pay.........: {CalculateValueToPay(),27:C2}\r\n";
        }

        private decimal ValidateGreatherThanZero(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("The price is not valid");
            }
            return value;
        }
        #endregion
    }
}
