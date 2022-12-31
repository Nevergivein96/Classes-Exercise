namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            var dodge = new Car();

            dodge.Make = "Dodge";
            dodge.Model = "1500";
            dodge.Year = 2003;

            var ford = new Car()
            {
                Make = "Ford",
                Model = "F-150",
                Year = 1998,
            };

            var carList = new List<Car>() { dodge, ford};

            foreach(var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
            
        }
    }
}
