internal class Program
{
    private static string k = "";

    private static void Main(string[] args)
    {
        string j = "";
        for (int i = 0; i < 10; i++)
        {
            j = i.ToString();
            k = i.ToString();
            Console.WriteLine(i);

            if (i == 9)
            {
                string l = i.ToString();
            }
            //Console.WriteLine(l);
        }
        Console.WriteLine("Outside of for loop " + j);
        Console.WriteLine("k Outside of for loop " + k);
        HelperMethod();
        Console.ReadLine();
    }

    static void HelperMethod()
    {
        Console.Write("Value of k from the helpermethod(): " + k);
    }
}