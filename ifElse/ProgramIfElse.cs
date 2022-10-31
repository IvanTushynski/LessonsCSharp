internal class ProgramIfElse
{
    private static void Main(string[] args)
    {
        ProgramIfElse programIfElse = new ProgramIfElse();
        programIfElse.ifElseMethodTwo();
        programIfElse.ifElseTick();

        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if (total > 14)
        {
            Console.WriteLine("You win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }

    }

    public void ifElseMethodTwo()
    {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }
    }

    public void ifElseTick()
    {
        int a = 1;


        if (a == 1)
        {
            for (int i = 0; i < 5; i++)
            {
                a = a + 1;
                Console.WriteLine(a);
                Thread.Sleep(1000);//задержка
            }
        }
        else
        {
            Console.WriteLine("Dont Working!!!");
        }
    }
}