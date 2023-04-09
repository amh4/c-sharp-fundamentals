using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Car car1 = new Car();
        //car1.Make = "Ford";
        //car1.Model = "Fiesta";
        //car1.VIN = "123asd";

        //Car car2 = new Car();
        //car2.Make = "Aston Martin";
        //car2.Model = "Vantage";
        //car2.VIN = "456fgh";

        //Book b1 = new Book();
        //b1.Title = "Extreme Ownership";
        //b1.Author = "Jocko Willink";
        //b1.ISBN = "0-000-00000-0";

        //ArrayList myArrayList = new ArrayList();
        //myArrayList.Add(car1);
        //myArrayList.Add(car2);
        //myArrayList.Add(b1);
        //myArrayList.Remove(b1);

        //foreach (Car car in myArrayList)
        //{
        //    Console.WriteLine(car.Make);
        //}


        //List<Car> myList = new List<Car>();
        //myList.Add(car1);
        //myList.Add(car2);

        //foreach (Car car in myList)
        //{
        //    Console.WriteLine(car.Make);
        //}

        //Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
        //myDictionary.Add(car1.VIN, car1);
        //myDictionary.Add(car2.VIN, car2);

        //Console.WriteLine(myDictionary["456fgh"].Make);

        //Car car1 = new Car()
        //{
        //    Make = "Ferrari",
        //    Model = "F40",
        //    VIN = "A1"

        //};

        //Car car2 = new Car()
        //{
        //    Make = "Ferrari",
        //    Model = "F50",
        //    VIN = "B2"

        //};

        List<Car> myList = new List<Car>()
        {
            new Car {Make = "Ferrari", Model = "F430", VIN = "A1"},
            new Car {Make = "Lamborghini", Model = "Gallardo", VIN = "B2"}
        };

        Console.ReadLine();

    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}