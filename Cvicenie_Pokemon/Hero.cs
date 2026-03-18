using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie_Pokemon
{
    public class Hero
    {
        public int Health { get; set; }
        public int Health_Max { get; set; }
        public int Damage { get; set; }
        public int Energy { get; set; }
        public int Energy_Max { get; set; }

        public Hero(int health, int health_Max, int damage, int energy_Max = 100)
        {
            Health = health;
            Health_Max = health_Max;
            Damage = damage;
            Energy_Max = energy_Max;
            Energy = energy_Max;
        }
    }
}