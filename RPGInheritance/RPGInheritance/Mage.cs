using System;
using System.Collections.Generic;

namespace RPGInheritance
{
    public class Mage : Character
    {
        public Mage(string name)
            : base(name, 90, 30)
        {
        }

        public override void Attack(Character target)
        {
            int bonus = Random.Shared.Next(5, 16);

            int damage = AttackPower + bonus;

            Console.WriteLine($"{Name} rzuca zaklęcie magiczne!");

            target.TakeDamage(damage);
        }
    }
}
