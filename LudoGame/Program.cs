
class LudoGame
{

  static  int MaxDice = 50;
  static  int PlayerOne = 0;
  static int PlayerTwo = 0;

  static  Random rand = new Random();


    static void Main(string[] args)
    {
        Console.WriteLine("welcome to Ludo Game");

        while (true)
        {
            Console.WriteLine(" /--- Player 1 turn ----/ ");
            PlayerOne = PlayerTurn(PlayerOne, "Anand");

            if(PlayerOne>=MaxDice)
            {
                Console.WriteLine("Player 1 wins");
                break;
            }

            Console.WriteLine(" /--- Player 1 turn ----/ ");
            PlayerTwo = PlayerTurn(PlayerTwo, "Divya");

            if (PlayerTwo >= MaxDice)
            {
                Console.WriteLine("Player 2 wins");
                break;
            }

        }
        Console.WriteLine("\n Game over. Press any key to exit");
        Console.ReadKey();

    }

    static int PlayerTurn(int position, string PlayerName)
    {
        Console.WriteLine("press Enter to roll to dice..");
        Console.ReadKey();
        int dicevalue = rand.Next(1, 7);
        Console.WriteLine(" Player "+ PlayerName +" Rolled : " + dicevalue);

        position += dicevalue;
        Console.WriteLine(" Player " + PlayerName + " Moves to the position : " + position);
        return position;

    }
}