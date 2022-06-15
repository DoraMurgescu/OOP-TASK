using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Planet
    {
        private Dictionary<Being, int> targets = new Dictionary<Being, int>();
        private bool containsLife;
        private int population;
        public bool ContainsLife { get => containsLife; set => containsLife = value; }
        public int Population { get => population; set => population = value; }
        public Dictionary<Being, int> Targets { get => targets; set => targets = value; }
    }
    class Earth : Planet
    {
        public Earth(int animalCount, int humanCount, int soldierCount)
        {
            ContainsLife = true;
            Human humans = new Human();
            Soldier soldiers = new Soldier();
            Animal animals = new Animal();

            Targets.Add(humans, humanCount);
            Targets.Add(soldiers, soldierCount);
            Targets.Add(animals, animalCount);

            Population = Targets[humans] + Targets[soldiers] + Targets[animals];
        }
    }

    class Mars : Planet
    {
        public Mars(int alienCount, int heroCount)
        {
            ContainsLife = true;

            Alien aliens = new Alien();
            Superhero heroes = new Superhero();

            Targets.Add(aliens, alienCount);
            Targets.Add(heroes, heroCount);

            Population = Targets[aliens] + Targets[heroes];
        }
    }

}