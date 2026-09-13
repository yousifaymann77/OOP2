using System;
using System.Collections.Generic;
using System.Text;

namespace oop2Assign
{
    internal class InternationalShipment :Shipment
    {
        #region Part 2 Q2 p3 InternationalShipment 
        private string destinationCountry = default!;
        private decimal customFee;

        public InternationalShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinationCountry, decimal customFee, string destination)
            : base(trackingCode, description, deliveryFee, weight,destination)
        {
            this.customFee = customFee;
            this.destinationCountry = destinationCountry;
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (string.IsNullOrWhiteSpace(destinationCountry))
                {
                    destinationCountry = value;
                }
            }
        }
        public decimal CustomFee
        {
            get { return customFee; }
            set
            {
                if (customFee >= 0)
                {
                    customFee = value;
                }
            }
        }

        public override decimal EstimatedCost => base.EstimatedCost + customFee; 
        #endregion
    }
}
