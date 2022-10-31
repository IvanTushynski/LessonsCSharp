﻿internal class ProgramLiterals
{
    private static void Main(string[] args)
    {
        //string используется для вывода слов, фраз и любых других буквенно-цифровых данных, но не для выполнения вычислений с ними;
        //char представляет отдельную букву или цифру;
        //int представляет целое число;
        //decimal представляет число с десятичной дробью;
        //bool представляет значения "истина" или "ложь".
        string name = "Vova";
        int age = 999999999;
        long age2 = 999999999999999999;
        short age3 = 9999;
        double heigh = 174.5;
        bool liam = true;
        decimal liamTwo = 123.425m;


        void OneTwo()
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
            //-------------------------------------------------
            string firstName = "Bob";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
            //-------------------------------------------------------------------------------------
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            //--------------------------------------------------------------------
            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine("Decimal quotient: " + decimalQuotient);
            //-----------------------------------------------------------------------------
            int first = 7;
            int second = 5;
            decimal quot = (decimal)first / (decimal)second;
            Console.WriteLine(quot);
            //------------------------------------------------------
            int arm = 50 % 10;
            Console.WriteLine(arm + " ostatok ot deleniya");
            //-------------------------------------------------------------------------------------------
            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            //------------------------------------------------------------
            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);
            Console.WriteLine(5 / 10);
        }
    }
}