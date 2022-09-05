namespace OOP008RPG 
{
    internal class Creature : SuperGrandParentBase
    {
        public List<Item>? Items { get; set; }

        public void ShowHealth()
        {
            Console.WriteLine("Health : " + Health);
        }
        public void Damage(int damage)
        {
            Health -= damage;
            if (Health < 0) Console.WriteLine("You are dead!");
        }

        public void ShowItems()
        {
            Console.WriteLine("\nITEM LIST...");
            if (Items == null) return;
            foreach (var item in Items)
            {
                if (item.GetType().Name == "Weapon")
                {
                    Weapon weapon = (Weapon)item;
                    Console.WriteLine($"{weapon.Name}  Damage: {weapon.Damage[0]} - {weapon.Damage[1]}");
                }
                else
                { Console.WriteLine(item.Name); }

            }
        }
    }
}
