using Methods;

internal class ProgramMethods
{
    private static void Main(string[] args)
    {
        //методы-------------------------------------------
        HomeWorks homeWorks = new HomeWorks();
        int a, b, c;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        //вызываем методы из другого класса----------------
        c = homeWorks.TotalSum(a, b);
        homeWorks.PrintResult(c);
    }
}