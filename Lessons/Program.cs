﻿using Lessons;

internal class Program
{
    private static void Main(string[] args)
    {
        //вывод в консоль
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        LiteralsAndvariables dataVariables = new LiteralsAndvariables();
        dataVariables.OneTwo();
        Strings strings = new Strings();
        strings.StringWork();
        ClassAndMethods classAndMethods = new ClassAndMethods();
        classAndMethods.randomMethod();
        Scanner scanner = new Scanner();
        scanner.scanner();
        If_Else if_Else = new If_Else();
        if_Else.taskRandomSubscription();

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

        Test test = new Test();
        test.TestOne();

    }
}
