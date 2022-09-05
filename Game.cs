namespace OOP008RPG
{
    internal class Game
    {
        Data d = new Data();
        public Game()
        {
            CreateNewCharacter();
        }

        public Character CreateNewCharacter()
        {
            Character c = new Character();
            c.CreateAttributes();
            c.Name = Console.ReadLine();

            Console.Write("Add character to party?");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                d.Party.Add(c);
            }
            
            return c;
        }
    }
}
