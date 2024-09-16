// See https://aka.ms/new-console-template for more information
using AnaClos.MathGame.Models;
using System.Runtime.CompilerServices;
int max = 5;
int score = 0;
string choice = "q";
List<Game> games = new List<Game>();

choice = Menu();

while (choice!="q")
{
    switch (choice)
    {
        case "a":
            score=Add();
            games.Add(new Game { Name ="Add",Date=DateTime.Now,Score=score*100/max});
            break;
        case "s":
            score=Subtract();
            games.Add(new Game { Name = "Dubtract", Date = DateTime.Now, Score = score * 100 / max });
            break;
        case "m":
            score=Multiply();
            games.Add(new Game { Name = "Multiply", Date = DateTime.Now, Score = score * 100 / max });
            break;
        case "d":
            score=Divide();
            games.Add(new Game { Name = "Divide", Date = DateTime.Now, Score = score * 100 / max });
            break;
        case "l":
            PrintList(games);
            break;
        case "q":
            Console.WriteLine("By!!!");
            break;
    }
    Console.WriteLine("-----------------------------------");

    choice = Menu();
}

string Menu()
{
    string choice=string.Empty;

    Console.WriteLine("Select your choice");
    Console.WriteLine("(a) Addition");
    Console.WriteLine("(s) Subtraction");
    Console.WriteLine("(m) Multiplication");
    Console.WriteLine("(d) Divition");
    Console.WriteLine("(l) List");
    Console.WriteLine("(q) Quit");

    choice = Console.ReadLine().ToLower().Trim();

    return choice;
}
int Add()
{
    var random = new Random();
    int number1 =random.Next(1,9);
    int number2 =random.Next(1,9);
    int response;
    int counterOk = 0;

    for(int i=0;i<max;i++)
    {
        number1 = random.Next(1, 9);
        number2 = random.Next(1, 9);
        Console.WriteLine($"{number1} + {number2} = ?");

        try
        {
            response = Int32.Parse(Console.ReadLine());

            if (response == number1 + number2)
            {
                Console.WriteLine("Very Good :)");
                counterOk++;
            }
            else
            {
                Console.WriteLine("Bad result :(");
            }           
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Result is not a number");
        }
        Console.WriteLine("-----------------------------------");
    }

    return counterOk;   
}
int Subtract()
{
    var random = new Random();
    int number1;
    int number2;
    int response;
    int counterOk = 0;

    for (int i = 0; i < max; i++)
    {
        number1 = random.Next(1, 9);
        number2 = random.Next(1, 9);
        Console.WriteLine($"{number1} - {number2} = ?");
        try
        {
            response = Int32.Parse(Console.ReadLine());

            if (response == number1 - number2)
            {
                Console.WriteLine("Very Good :)");
                counterOk++;
            }
            else
            {
                Console.WriteLine("Bad result :(");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Result is not a number");
        }
    }
    return counterOk;
}

int Multiply()
{
    var random = new Random();
    int number1 ;
    int number2 ;
    int response;
    int counterOk = 0;

    for (int i = 0; i < max; i++)
    {
        number1 = random.Next(1, 9);
        number2 = random.Next(1, 9);
        Console.WriteLine($"{number1} * {number2} = ?");
        try
        {
            response = Int32.Parse(Console.ReadLine());

            if (response == number1 * number2)
            {
                Console.WriteLine("Very Good :)");
                counterOk++;
            }
            else
            {
                Console.WriteLine("Bad result :(");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Result is not a number");
        }
    }
   
    return counterOk;
}
int Divide()
{
    var random = new Random();
    int number1 ;
    int number2;
    int response;
    int counterOk = 0;

    for (int i = 0; i < max; i++)
    {
        number1 = random.Next(0, 100);
        number2 = random.Next(1, 9);
        while (number1 % number2 != 0)
        {
            number1 = random.Next(0, 100);
            number2 = random.Next(1, 9);
        }
        Console.WriteLine($"{number1} / {number2} = ?");
        try
        {
            response = Int32.Parse(Console.ReadLine());

            if (response == number1 / number2)
            {
                Console.WriteLine("Very Good :)");
                counterOk++;
            }
            else
            {
                Console.WriteLine("Bad result :(");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Result is not a number");
        }
    }
    return counterOk;
}
void PrintList(List<Game> games)
{
    foreach(var game in games)
    {
        Console.WriteLine(game.ToString());
    }
    Console.WriteLine("-----------------------------------");
}

