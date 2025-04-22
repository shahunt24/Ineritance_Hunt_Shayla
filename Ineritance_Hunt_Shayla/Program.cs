namespace Ineritance_Hunt_Shayla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An instance of the Platform class is created with the title "Super Mario Bros." and ESRB rating "E".
            Platform myPlatform = new Platform("E", "Super Mario Bros.");

            // The Describe method is called on the myPlatform inztance, which returns a string describing the game.
            Console.WriteLine(myPlatform.Describe()); 
            myPlatform.PlayGame();

            // An instance of the Platform class is creating with the title "Sonic the Hedgehog" and ESRB rating "PG".
            Platform CSgO = new Platform("PG", "Sonic the Hedgehog");
            Console.WriteLine(CSgO.Describe());
            myPlatform.PlayGame();
        }
    }
}
