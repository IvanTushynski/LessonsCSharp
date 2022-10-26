public class ClassAndMethods
{
    public void randomMethod()
    {
        //рандомное число--------------------
        Random dice = new Random();
        int roll = dice.Next(100, 7000);
        Console.WriteLine(roll);

        //макс число

        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine(largerValue);

        //Перегруженный метод определяется с использованием нескольких сигнатур.
        //С помощью перегрузок вы можете вызывать метод разными способами, передавая в него данные разных типов.
        int number = 7;
        string text = "seven";

        Console.WriteLine(number);
        Console.WriteLine();
        Console.WriteLine(text);

        Random dice2 = new Random();
        int roll1 = dice2.Next();
        int roll2 = dice2.Next(101);
        int roll3 = dice2.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");




        Person tom = new Person();  // создание объекта класса Person

        // Получаем значение полей в переменные
        string personName = tom.name;
        int personAge = tom.age;
        Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   // Имя: Undefined  Возраст: 0

        // устанавливаем новые значения полей
        tom.name = "Tom";
        tom.age = 37;

        // обращаемся к методу Print
        tom.Print();    // Имя: Tom  Возраст: 37


    }
}


class Person
{
    public string name = "Undefined";
    public int age;

    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}