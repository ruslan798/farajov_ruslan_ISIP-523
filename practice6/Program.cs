namespace ISIP523_Faradjov

{ 
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();

            Console.WriteLine("\nСпасибо за игру!");
            Console.ReadKey();
        }
    }
}