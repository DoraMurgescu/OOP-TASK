using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    abstract class Being
    {
        private int health;
        private int attack;
        private int speed;
        private int defense;
        private int initialHealth;
        public Being(int health, int attack, int speed, int defense)
        {
            this.health = health;
            this.attack = attack;
            this.speed = speed;
            this.defense = defense;
        }
        public Being() { }
        public int Health { get => health; set => health = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Defense { get => defense; set => defense = value; }
        public int InitialHealth { get => initialHealth; set => initialHealth = value; }
    }
    class Alien : Being
    {
        public Alien()
        {
            Health = 150;
            Attack = 20;
            Defense = 20;
            Speed = 5;
            InitialHealth = Health;
        }
        public void Rush()
        {
            Speed = 30;
        }
    }
    class Animal : Being
    {
        public Animal()
        {
            Health = 50;
            Attack = 5;
            Defense = 0;
            Speed = 20;
            InitialHealth = Health;
        }
    }
    class Human : Being
    {
        public Human()
        {
            Health = 100;
            Attack = 1;
            Speed = 50;
            Defense = 10;
            InitialHealth = Health;
        }
        public void Beg()
        {
            Console.WriteLine("People beg for mercy!");
        }
    }

    class Soldier : Human
    {
        public Soldier()
        {
            Health = 100;
            Attack = 10;
            Speed = 70;
            Defense = 20;
            InitialHealth = Health;
        }
        public void Backup()
        {
            Console.WriteLine("Soldiers are requesting backup!");
        }
    }
    class Superhero : Human
    {
        public Superhero()
        {
            Health = 200;
            Attack = 50;
            Speed = 100;
            Defense = 50;
            InitialHealth = Health;
        }
        public void Fight()
        {
            Health *= 2;
            Attack *= 2;
            Speed *= 2;
            Defense *= 2;
        }
    }

}