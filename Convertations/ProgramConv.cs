using System.Globalization;
using System.Linq.Expressions;

internal class ProgramConv
{
    private static void Main(string[] args)
    {
        //Сонвертация строки в число!!!!!!!!!!!!!!!!-----------------------------------------------------------------------
        String strOne = "5";
        String strTwo = "2";

        int a = Convert.ToInt32(strOne);
        int b = Convert.ToInt32(strTwo);

        Console.WriteLine(a + b);

        String str;
        int ay, by;

        Console.WriteLine("Enter First Number");
        str = Console.ReadLine();
        ay = Convert.ToInt32(str);

        Console.WriteLine("Enter Second Number");
        str = Console.ReadLine();
        by = Convert.ToInt32(str);
        int ser = ay + by;

        Console.WriteLine("Answer" + ser);


        //Сонвертация строки в число через парс!!!!!!!!!!!!!!!!------------------------------------------------------------------------
        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()//Указывает какой разделитель будет - либо точка либо запятая!
        {
            NumberDecimalSeparator = ".",
        };

        String str2 = "5";
        int a2 = int.Parse(str2);
        String strTwo2 = "5.1";
        Double b2 = double.Parse(strTwo2, numberFormatInfo);
        Console.WriteLine(a);
        Console.WriteLine(b);

        String strThree = "2 qweqweqwe";
        int num;
        bool result = int.TryParse(strThree, out num);

        if (result == true)
        {
            Console.WriteLine("Удaлось распарсить. Результат = " + num);
        }
        else
        {
            Console.WriteLine("Не удалось распарсить");
        }

        
        //---------------------------------------------------------------------
        String argo = "1";
        //что бы не выбивало ошибку!!!!!!!!!!!!!!!!!! Трай кэтч
        try
        {
            int a3 = Convert.ToInt32(argo);
            Console.WriteLine("Succesfully!!!");
        } catch (Exception)
        {
            Console.WriteLine("Not Succesfully!!!");
        }
    }
}