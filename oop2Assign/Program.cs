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
        }
    }
}
