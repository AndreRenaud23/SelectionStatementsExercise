var r = new Random();
var randomNumber = r.Next(1, 100);

while (true)
{  
    Console.WriteLine("Guess the number: ");
    var userInput = int.Parse(Console.ReadLine());

    if (userInput < randomNumber)
    {
        Console.WriteLine("Too low! Guess again");
    }
    else if (userInput > randomNumber)
    {
        Console.WriteLine("Too high! Guess again");
    }
    else if (userInput == randomNumber)
    {
        Console.WriteLine("Congrats! You guessed correctly! WOOHOO! You need a cookie :)");
        break;
    }
}

Console.WriteLine("Press enter to continue to");
Console.ReadLine();

Console.WriteLine("What is your favorite school subject? Choose one below");
Console.WriteLine("CODING -- ELA --  HISTORY -- SPANISH -- MATH");
var favSchoolSubject = Console.ReadLine();
switch (favSchoolSubject.ToUpper())
{
    case "CODING":
        Console.WriteLine("That's cool! You should try TrueCoders!");
        break;

    case "ELA":
        Console.WriteLine("Good for you!");
        break;

    case "HISTORY":
        Console.WriteLine("That's cool! History is very interesting to learn!");
        break;

    case "SPANISH":
        Console.WriteLine("Good job! It is nice to know mulitiple languages!");
        break;

    case "MATH":
        Console.WriteLine("That's good! Math applies to a lot of things in life!");
        break;


    default:
        Console.WriteLine("Sorry... that isn't one of the choices");
        break;
}


