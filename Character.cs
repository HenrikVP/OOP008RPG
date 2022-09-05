namespace OOP008RPG
{
    internal class Character : SuperGrandParentBase
    {
        public int Age { get; set; }

        public List<Item> Items { get; set; }
        public Attributes Attributes { get; set; }
        public Character()
        {

        }
        void ShowHealth()
        {
            Console.WriteLine("Health : " + Health);
        }
        public void Damage(int damage)
        {
            Health -= damage;
            if (Health < 0) Console.WriteLine("You are dead!");
        }

        public Attributes CreateAttributes()
        {
            Random random = new Random();
            Attributes attributes = new();
            foreach (var item in attributes.GetType().GetProperties())
            {
                int die = random.Next(3, 19);

                item.SetValue(attributes, die);
                Console.WriteLine(item.Name + " " + item.GetValue(attributes));
            }
            return attributes;
        }

        public void ShowItems()

        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }



    }
}
