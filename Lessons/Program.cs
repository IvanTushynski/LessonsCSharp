internal class Program
{
    private static void Main(string[] args)
    {
        //вывод в консоль
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        testRandom();

        int a = 1;


        if (a == 1)
        {
            for (int i = 0; i < 20; i++)
            {
                a = a + 1;
                Console.WriteLine(a);
                Thread.Sleep(1000);
            }
        }
        else
        {
            Console.WriteLine("Dont Working!!!");
        }

    }

    static void testRandom()
    {
        var rand = new Random();
        var bytes = new byte[5];
        rand.NextBytes(bytes);
        Console.WriteLine("Five random byte values:");
        foreach (byte byteValue in bytes)
            Console.Write("{0, 5}", byteValue);
        Console.WriteLine();
    }
}

class Human
{
    string name = "Vova";
    int age = 10;
    double heigh = 174.5;
}