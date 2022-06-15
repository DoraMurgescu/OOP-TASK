using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    abstract class Weapon
    {
        private int power;
        private int cooldown;
        private int range;
        protected Weapon(int power, int cooldown, int range)
        {
            this.power = power;
            this.cooldown = cooldown;
            this.range = range;
        }
        public int Power { get => power; set => power = value; }
        public int Cooldown { get => cooldown; set => cooldown = value; }
        public int Range { get => range; set => range = value; }
        public void Shoot(Being target, Planet planet)
        {
            target.Health = target.Health - (power - target.Speed + range);
            if (target.Health <= 0)
            {
                planet.Targets[target]--;
                planet.Population--;
                target.Health = target.InitialHealth;
            }
        }
        abstract public void Sound();
    }
    class Laser : Weapon
    {
        public Laser(int power, int cooldown, int range)
        : base(power, cooldown, range) { }
        public override void Sound()
        {
            Console.WriteLine("Laser activated!");
        }
    }
    class Chainsaw : Weapon
    {
        public Chainsaw(int power, int cooldown, int range)
        : base(power, cooldown, range) { }
        public override void Sound()
        {
            Console.WriteLine("brumm-brumm-bruumm!");
        }
    }
    class Sword : Weapon
    {
        public Sword(int power, int cooldown, int range)
        : base(power, cooldown, range)
        { }
        public override void Sound()
        {
            Console.WriteLine("Slash!");
        }
    }
    class RocketLauncher : Weapon
    {
        public RocketLauncher(int power, int cooldown, int range)
        : base(power, cooldown, range) { }
        public override void Sound()
        {
            Console.WriteLine("BOOM!");
        }
    }
}
