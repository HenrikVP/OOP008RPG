namespace OOP008RPG
{
    internal class Weapon : Item
    {
        public int[] Damage { get; set; } = new int[2];
        public int Bonus { get; set; }
        public bool Innate { get; set; }

        public int DamageDone()
        {
            return new Random().Next(Damage[0], Damage[1]) + Bonus;
        }
    }
}
