internal class Program
{
    private static void Main(string[] args)
    {
        //вывод в консоль
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        testRandom();
        DataVariables dataVariables = new DataVariables();
        dataVariables.OneTwo();

        int a = 1;


        if (a == 1)
        {
            for (int i = 0; i < 5; i++)
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
}

class DataVariables
{
    //string используется для вывода слов, фраз и любых других буквенно-цифровых данных, но не для выполнения вычислений с ними;
    //char представляет отдельную букву или цифру;
    //int представляет целое число;
    //decimal представляет число с десятичной дробью;
    //bool представляет значения "истина" или "ложь".
    string name = "Vova";
    int age = 10;
    double heigh = 174.5;
    bool liam = true;
    decimal liamTwo = 123.425m;


    public void OneTwo()
    {
        Console.WriteLine(name + " string");
        Console.WriteLine(age + " int");
        Console.WriteLine(heigh + " double");
        Console.WriteLine(liam + " bool");
        Console.WriteLine(liamTwo + " decimal");
        //ключевое слово var указывает компилятору на необходимость выведения типа данных переменной на основе значения, используемого при инициализации;
        //Ключевое слово var можно встретить и в других примерах кода, но по возможности следует использовать фактический тип данных.
        //вар используется только внутри методов или циклов!!!
        var altima = 34;
        Console.WriteLine(altima + " var");
    }
}
