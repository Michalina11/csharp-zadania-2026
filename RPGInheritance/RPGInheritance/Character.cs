using System;
using System.Collections.Generic;

namespace RPGInheritance
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Character(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public abstract void Attack(Character target);

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
            }
            Console.WriteLine($"{Name} otrzymał {damage} obrażeń.");
        }
    }
}
