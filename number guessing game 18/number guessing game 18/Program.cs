Random random = new Random();
bool playagain = true;
int min = 1;
int max = 100;
int guess;
int number;
int guesses;
string response;

while (playagain)
{
    guess = 0;
    guesses = 0;
    number = random.Next(min, max + 1);
    response = "";

    while (guess != number)
    {
        Console.WriteLine("Guess the number between " + min + " - " + max + " :");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine(guess + " is too high");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is too low");
        }
        guesses++;
    }
    Console.WriteLine("number: " + number);
    Console.WriteLine("YOU WON!");
    Console.WriteLine("guesses : " + guesses);

    Console.WriteLine("Would you like to play again (Y/N) :");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playagain = true;
    }
    else
    {
        playagain = false;
    }
    Console.WriteLine("thanks for playing");
}
Console.ReadKey();