using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPOO
{
    internal class VariablePriceProduct : Product
    {
        #region Attributes
        private decimal _pricePerUnitOfMeasure;
        private float _quantity;
        #endregion

        #region Properties
        public decimal PricePerUnitOfMeasure 
        { 
            get => _pricePerUnitOfMeasure; 
            set => _pricePerUnitOfMeasure = ValidateGreatherThanZero(value); 
        }

        public float Quantity 
        { 
            get => _quantity; 
            set => _quantity = ValidateGreatherThanZero(value); 
        }

        public string UnitOfMeasure { get; set; }
        #endregion

        #region Methods
        public override decimal CalculateDiscount()
        {
            return (PricePerUnitOfMeasure * ((decimal)Quantity)) * (((decimal)DiscountPercentaje) / 100);
        }

        public override decimal CalculateTax()
        {
            return (PricePerUnitOfMeasure * ((decimal)Quantity)) * (((decimal)TaxPercentaje) / 100);
        }

        public override decimal CalculateValueToPay()
        {

            return (PricePerUnitOfMeasure * ((decimal)Quantity)) - CalculateDiscount() + CalculateTax();
        }

        public override string? ToString()
        {
            return
                $"{Id}        {Name}\r\n" +
                    $"         % Discount...........: {DiscountPercentaje,26:C2}%\r\n" +
                        $"         % Tax................: {TaxPercentaje,26:C2}%\r\n" +
                            $"         Unit of eeasure......: {UnitOfMeasure,2:C2}\r\n" +
                                $"         Quantity.............: {Quantity,27:C2}\r\n" +
                                    $"         Price................: {PricePerUnitOfMeasure,27:C2}\r\n" +
                                        $"         Discount value.......: {CalculateDiscount(),27:C2}\r\n" +
                                            $"         Tax value............: {CalculateTax(),27:C2}\r\n" +
                                                $"         Value to pay.........: {CalculateValueToPay(),27:C2}\r\n";
        }

        private decimal ValidateGreatherThanZero(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("The price per unit of measure is not valid");
            }
            return value;
        }

        private float ValidateGreatherThanZero(float value)
        {
            if (value < 0)
            {
                throw new ArgumentException("The quantity is not valid");
            }
            return value;
        }
        #endregion
    }
}
