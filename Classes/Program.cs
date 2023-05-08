namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Create a new instance of the Car class
 Set values in the properties for the object
 Print the values of each property to the Console*/
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Year = 2013;
            myCar.Model = "Corolla";
            Console.WriteLine($"My car is {myCar.Make} {myCar.Model} made in {myCar.Year}");
        }
    }
}
