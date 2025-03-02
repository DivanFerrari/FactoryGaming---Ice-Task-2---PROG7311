namespace FactoryGaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamingFactory factory = new GamingFactory();
            Console.WriteLine("Please enter your game:");
            String selectedGame = Console.ReadLine();
            IGame game  = factory.getGame(selectedGame);
            Console.WriteLine("The name of the game is {0} with a rating of {1}. an{2}",
                game.getName(), game.getRating(), game.getDescription());
        }
    }
}
