namespace oop2Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1 Q1 a) What is the difference between a class and a struct?
            // struct is a value type used for leight weigth data and stored in heap and does not support inheritance 
            // class is a reference type stored in heap and it is the main oop unit because it supports all the 4 pillars of oop
            #endregion

            #region part 1 Q1 b) Why are classes more suitable than structs for large applications?
            // Because class support inheritence which helps in reusability and organization of code in large projects
            // classes are refrence type so objects can be shared between diffrent parts of the App without copying the entire projects
            // Better for complex projects and reusable oop designs
            #endregion

            #region part 1 Q2 a) Which class is the parent class?
            // Shipment
            #endregion

            #region part 1 Q2 b) Which class is the child class?
            //ExpressShipment 
            #endregion

            #region part 1 Q2 c) What members are inherited by ExpressShipment?
            // The Tracking Code property
            #endregion

            #region  part 1 Q2 d) Why is inheritance better than duplicating the same code in multiple classes?
            // Because it acheives the Principles of reusability and Maintainability of the code , especially in large complicated projects
            #endregion



            #region Part 2 Q5 1&2
            DeliveryCenter deliveryCenter = new DeliveryCenter();

            Console.WriteLine("Enter Delivery Center Name : ");
            deliveryCenter.CenterName = Console.ReadLine();
            #endregion

            #region part 2 Q5 3,4,5,6,5
            Console.WriteLine("\n \n ");


            Console.WriteLine("\n\n");
            Console.WriteLine("-- Enter the Details for Standard Shipment --");

            string trackCode = default!;
            do
            {
                Console.Write("Enter the Tracking Code: ");
                trackCode = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(trackCode))
                {
                    Console.WriteLine("Invalid Tracking Code");
                }

            } while (string.IsNullOrWhiteSpace(trackCode));


            string description = default!;
            do
            {
                Console.Write("Enter the Description: ");
                description = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(description))
                {
                    Console.WriteLine("Invalid Description");
                }

            } while (string.IsNullOrWhiteSpace(description));


            decimal deliveryFee;
            bool isParsed1;

            do
            {
                Console.Write("Enter The Delivery Fee: ");
                isParsed1 = decimal.TryParse(Console.ReadLine(), out deliveryFee);

                if (!isParsed1 || deliveryFee <= 0)
                {
                    Console.WriteLine("Invalid Delivery Fee");
                }

            } while (!isParsed1 || deliveryFee <= 0);


            decimal weight;
            bool isParsed2;

            do
            {
                Console.Write("Enter The Weight: ");
                isParsed2 = decimal.TryParse(Console.ReadLine(), out weight);

                if (!isParsed2 || weight <= 0)
                {
                    Console.WriteLine("Invalid Weight");
                }

            } while (!isParsed2 || weight <= 0);


            string destination = default!;
            do
            {
                Console.Write("Enter the Destination: ");
                destination = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(destination))
                {
                    Console.WriteLine("Invalid Destination");
                }

            } while (string.IsNullOrWhiteSpace(destination));


            StandardShipment standardShipment =
                new StandardShipment(
                    trackCode,
                    description,
                    deliveryFee,
                    weight,
                    destination
                );

            deliveryCenter.AddShipment(standardShipment);

            Console.Clear();
            Console.WriteLine("Shipment Added Successfully ");

            Console.WriteLine("\n\n");
            Console.WriteLine("-- Enter the Details for Express Shipment --");

            trackCode = default!;


            do
            {
                Console.Write("Enter the Tracking Code: ");
                trackCode = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(trackCode))
                {
                    Console.WriteLine("Invalid Tracking Code");
                }

            } while (string.IsNullOrWhiteSpace(trackCode));


            description = default!;
            do
            {
                Console.Write("Enter the Description: ");
                description = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(description))
                {
                    Console.WriteLine("Invalid Description");
                }

            } while (string.IsNullOrWhiteSpace(description));


            deliveryFee = 0;
            do
            {
                Console.Write("Enter The Delivery Fee: ");
                isParsed1 = decimal.TryParse(Console.ReadLine(), out deliveryFee);

                if (!isParsed1 || deliveryFee <= 0)
                {
                    Console.WriteLine("Invalid Delivery Fee");
                }

            } while (!isParsed1 || deliveryFee <= 0);


            weight = 0;
            do
            {
                Console.Write("Enter The Weight: ");
                isParsed2 = decimal.TryParse(Console.ReadLine(), out weight);

                if (!isParsed2 || weight <= 0)
                {
                    Console.WriteLine("Invalid Weight");
                }

            } while (!isParsed2 || weight <= 0);


            destination = default!;
            do
            {
                Console.Write("Enter the Destination: ");
                destination = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(destination))
                {
                    Console.WriteLine("Invalid Destination");
                }

            } while (string.IsNullOrWhiteSpace(destination));


            decimal extraFee;
            bool isParsed3;

            do
            {
                Console.Write("Enter The Extra Fee: ");
                isParsed3 = decimal.TryParse(Console.ReadLine(), out extraFee);

                if (!isParsed3 || extraFee <= 0)
                {
                    Console.WriteLine("Invalid Extra Fee");
                }

            } while (!isParsed3 || extraFee <= 0);


            ExpressShipment expressShipment =
                new ExpressShipment(
                    trackCode,
                    description,
                    deliveryFee,
                    weight,
                    destination,
                    extraFee
                );

            deliveryCenter.AddShipment(expressShipment);



            Console.WriteLine("\n\n");
            Console.WriteLine("-- Enter the Details for International Shipment --");

            trackCode = default!;

            do
            {
                Console.Write("Enter the Tracking Code: ");
                trackCode = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(trackCode))
                {
                    Console.WriteLine("Invalid Tracking Code");
                }

            } while (string.IsNullOrWhiteSpace(trackCode));


            description = default!;
            do
            {
                Console.Write("Enter the Description: ");
                description = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(description))
                {
                    Console.WriteLine("Invalid Description");
                }

            } while (string.IsNullOrWhiteSpace(description));


            deliveryFee = 0;
            do
            {
                Console.Write("Enter The Delivery Fee: ");
                isParsed1 = decimal.TryParse(Console.ReadLine(), out deliveryFee);

                if (!isParsed1 || deliveryFee <= 0)
                {
                    Console.WriteLine("Invalid Delivery Fee");
                }

            } while (!isParsed1 || deliveryFee <= 0);


            weight = 0;
            do
            {
                Console.Write("Enter The Weight: ");
                isParsed2 = decimal.TryParse(Console.ReadLine(), out weight);

                if (!isParsed2 || weight <= 0)
                {
                    Console.WriteLine("Invalid Weight");
                }

            } while (!isParsed2 || weight <= 0);
            string destinationCountry = default!;
            do
            {
                Console.Write("Enter the Destination Country: ");
                destinationCountry = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(destinationCountry))
                {
                    Console.WriteLine("Invalid Destination Country");
                }

            } while (string.IsNullOrWhiteSpace(destinationCountry));


            decimal customsFee;
            bool isParsed4;

            do
            {
                Console.Write("Enter The Customs Fee: ");
                isParsed4 = decimal.TryParse(Console.ReadLine(), out customsFee);

                if (!isParsed4 || customsFee <= 0)
                {
                    Console.WriteLine("Invalid Customs Fee");
                }

            } while (!isParsed4 || customsFee <= 0);


            InternationalShipment internationalShipment =
                new InternationalShipment(
                    trackCode,
                    description,
                    deliveryFee,
                    weight,
                    destinationCountry,
                    customsFee,
                    destination
                );

            deliveryCenter.AddShipment(internationalShipment); 
            #endregion





        }

     
    }
}
