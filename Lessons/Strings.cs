public class Strings
{
    public void StringWork()
    {
        string greeting = "Hello";
        string firstName = "Ivan";
        string message = greeting + " " + firstName + "!";
        //string message = $"{greeting} {firstName}!";
        Console.WriteLine(message);
        //----------------------------------------------------------
        string cat = "Venya";
        string dog = "Sharik";
        string animals = $"{cat} {dog}";
        Console.WriteLine(animals);
        //----------------------------------------------------------
        string projectName = "First-Project";
        Console.WriteLine($@"C:\Output\{projectName}\Data");
    }

}
