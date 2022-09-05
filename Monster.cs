namespace OOP008RPG
{
    enum RaceEnum { Orc, Dragon, Mantis, Beholder }

    internal class Monster : Creature
    {
        public string? Description { get; set; }
        public int? Xp { get; set; }
        public RaceEnum? Race { get; set; }
    }

    internal class Monsters : Monster
    {
        public Monster Orc = new()
        {
            Name = "GrubDoom",
            Race = RaceEnum.Orc,
            Health = 20,
            Items = new List<Item>()
            { new Weapon() { Name = "Battle Axe", Damage = new int[] { 2, 12 } }
            }
        };

        public Monster Dragon = new()
        {
            Name = "Felix The Dragon",
            Race = RaceEnum.Dragon,
            Health = 2000,
            Items = new List<Item>()
            { new Weapon() { Name = "Claw", Damage = new int[] { 5, 50 } }
            }
        };

    }
}
