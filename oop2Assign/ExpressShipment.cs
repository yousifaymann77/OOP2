using System;
using System.Collections.Generic;
using System.Text;

namespace oop2Assign
{
    internal class ExpressShipment : Shipment
    {
        #region part 2 Q2 p2 ExpressShipment 
        public ExpressShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinantion, decimal extraFee)
            : base(trackingCode, description, deliveryFee, weight, destinantion)
        {
            this.extraFee = extraFee;
        }

        private decimal extraFee;
        public decimal ExtraFee
        {

            get
            {
                return extraFee;
            }
            set
            {
                if (extraFee >= 0)
                {
                    extraFee = value;
                }
            }
        }
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + extraFee;

            }

        } 
        #endregion
    }
            
        
}

