internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();

        Car.MyMethod();
        /*
        myCar.Make = "Ford";
        myCar.Model = "Fiesta";
        myCar.Colour = "White";
        myCar.Year = 2010;
        */

        //Car myOtherCar;
        //myOtherCar = myCar;

        //Console.WriteLine("{0} {1} {2} {3}",
        //    myOtherCar.Make,
        //    myOtherCar.Model,
        //    myOtherCar.Year,
        //    myOtherCar.Colour);

        //myOtherCar.Model = "Fiesta ST";
        //Console.WriteLine("{0} {1}",
        //myCar.Model,
        //myOtherCar.Model);
        

        Console.ReadLine();
          
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Colour { get; set; }

    /*
    public Car()
    {
        Make = "Nissan";
    }

    public Car(string make, string model, int year, string colour)
    {
        Make = make;
        Model = model;
        Year = year;
        Colour = colour;
    }
    */

    public static void MyMethod()
    {
        Console.WriteLine("Called static method");
    }

}