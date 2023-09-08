namespace Hackathon
{
    class GuessGame
    {
      static void Main(string[] args)
      {
        do {
          PlayGame();
          Console.WriteLine("Would you play to another game? Y or N");
        } while (Console.ReadLine().ToLower() == "y");
      }
      private static void PlayGame()
      {
        Console.WriteLine("Pick a game to play. Enter '1' for Number guess, '2' for Animal Guess, or '3' for Higher or Lower: ");
        var game = Convert.ToInt32(Console.ReadLine());
        if (game == 1)
        {
          var random = new Random();
          int number = random.Next(1, 10);
          Console.WriteLine("Guess a number between 1 - 10: ");
          int Guess = 0;
          while (Guess != number)
          {
            Guess = Convert.ToInt32(Console.ReadLine());
            if (number == Guess)
            {
              Console.WriteLine("You guessed correctly, you win!");
            }
            else if (number != Guess)
            {
              Console.WriteLine("That wasn't it, guess again: ");
            };
          };
        }
        else if (game == 2)
        {
          string[] animals = {"DOG", "CAT", "MOUSE", "SNAKE", "BEAR", "PIG"};
          Random rand = new Random();
          int index = rand.Next(animals.Length);
          Console.WriteLine("I'm thinking of an animal. Guess what animal I'm thinking of. It can be a Dog, Cat, Mouse, Snake, Bear, or Pig");
          string Guess = "";
          string animal = animals[index];
          while (Guess != animal)
          {
            Guess = Console.ReadLine();
            Guess = Guess.ToUpper();
            if (Guess == animals[index])
            {
              Console.WriteLine("You guessed correctly, you win!");
            }
            else if (Guess != animal)
            {
              Console.WriteLine("That wasn't it, guess again: ");
            };
          };
        }
        else if (game == 3)
        {
          var random = new Random();
          int number = random.Next(1, 10);
          Console.WriteLine($"The value of the card drawn is {number}, will the next card be Higher, Lower, or Equal?: ");
          string Guess = Console.ReadLine();
          int next_number = random.Next(1, 10); 
          Guess = Guess.ToUpper();
          if (next_number < number && Guess == "LOWER" )
          {
            Console.WriteLine($"Next card is {next_number} you win!");
          }
          else if (next_number > number && Guess == "HIGHER")
          {
            Console.WriteLine($"Next card is {next_number} you win!");
          }
          else if (next_number == number && Guess == "EQUAL")
          {
            Console.WriteLine($"Next card is {next_number} you win!");
          }
          else
          {
            Console.WriteLine($"Next card is {next_number} you loose!");
          };
        };
      }
    }
}