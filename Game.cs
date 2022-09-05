using System.Reflection;

namespace OOP008RPG
{
    internal class Game
    {
        Data d = new Data();
        public Game()
        {
            AddMonsters();
            ShowAllMonsters();
            Character c = CreateNewCharacter();
            AddItems(c);
            c.ShowItems();

        }

        private void ShowAllMonsters()
        {
            foreach (var monster in d.MonsterList)
            {
                Console.WriteLine($"{monster.Name} ({nameof(monster)})");

            }
        }

        private void AddMonsters()
        {
            Monsters monsters = new();
            if (monsters.GetType().GetFields() == null) return;
            foreach (FieldInfo? fieldInfo in monsters.GetType().GetFields())
            {
                Monster m = (Monster)fieldInfo.GetValue(monsters);
                if (m != null) d.MonsterList.Add(m);
            }
        }

        public Character CreateNewCharacter()
        {
            Character c = new Character();
            c.CreateAttributes();
            Console.Write("Name your character: ");
            c.Name = Console.ReadLine();
            c.Health = 30;

            Console.Write("Add character to party?");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                d.Party.Add(c);
            }
            return c;
        }

        public void AddItems(Character c)
        {
            c.Items = new List<Item>();
            c.Items.Add(new Weapon()
            {
                Name = "Sword",
                Damage = new int[] { 1, 10 },
                Health = 100,
                Price = 50
            });
            c.Items.Add(new Equipment()
            {
                Name = "Backpack",
                Health = 100,
                Price = 5,
                Weight = 10,
                Description = "A brand new Fjällräven backpack"
            });
        }
    }
}
