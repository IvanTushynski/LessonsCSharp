using Lessons;

internal class Program
{
    private static void Main(string[] args)
    {
        //вывод в консоль
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        Scanner scanner = new Scanner();
        scanner.scanner();

        If_Else if_Else = new If_Else();
        if_Else.taskRandomSubscription();

        Test test = new Test();
        test.TestOne();

    }
}
