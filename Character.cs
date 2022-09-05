namespace OOP008RPG
{
    internal class Character : Creature
    {
        public int Age { get; set; }

        public Attributes? Attributes { get; set; }

        public Attributes CreateAttributes()
        {
            Random random = new Random();
            Attributes attributes = new();
            foreach (var property in attributes.GetType().GetProperties())
            {
                int die = random.Next(3, 19);

                property.SetValue(attributes, die);
                Console.WriteLine(property.Name + " " + property.GetValue(attributes));
            }
            return attributes;
        }
    }
}
