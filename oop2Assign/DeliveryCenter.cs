using System;
using System.Collections.Generic;
using System.Text;

namespace oop2Assign
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;

        public string CenterName { get; set; }

        public DeliveryCenter()
        {
            this.shipments = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                else return default!;
            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }
                return default!;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            
            for(int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        #region part 2 Q3 DeliveryCenter Modification 
        public bool RemoveShipment(string delCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == delCode)
                {
                    for (int j = i; j < shipments.Length - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[shipments.Length - 1] = null!;

                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipmints()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode != null)
                {
                    Console.WriteLine($"------Shipment {i + 1} Info----------");
                    Console.WriteLine($"Tracking Code: {shipments[i].TrackingCode} \n-Description: {shipments[i].Description} \n-Weight: {shipments[i].Weight} kg \n-Delivery Fee: ${shipments[i].DeliveryFee} \n-Destination: {shipments[i].Destination}");
                }
            }
        } 
        #endregion
    }
}
