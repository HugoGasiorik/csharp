namespace Cvicenie_Pokemon
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Health_Max { get; set; }
        public int Damage { get; set; }
        public string ImagePath { get; set; }

        public Enemy(string name, int health_Max, int damage, string imagePath)
        {
            Name = name;
            Health_Max = health_Max;
            Health = health_Max;
            Damage = damage;
            ImagePath = imagePath;
        }
    }
}