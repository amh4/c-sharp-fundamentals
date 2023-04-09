internal class Program
{
    private static void Main(string[] args)
    {
        string myString = " That summer we took threes across the board  ";

        myString = myString.Replace(" ", "--");

        Console.WriteLine(myString);
        Console.ReadLine();
    }
}