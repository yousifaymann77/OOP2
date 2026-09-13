using System;
using System.Collections.Generic;
using System.Text;

namespace oop2Assign
{
    internal class StandardShipment : Shipment
    {
        #region part 2 Q2 standardShipment with ctor chaining
        public StandardShipment(string trackingCode, string description, decimal deliveryFee, decimal weight, string destinantion)
            : base(trackingCode, description, deliveryFee, weight, destinantion)
        {
        } 
        #endregion




    }
}
