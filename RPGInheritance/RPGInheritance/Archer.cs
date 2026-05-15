using System;
using System.Collections.Generic;

namespace RPGInheritance
{
    public class Archer : Character
    {
        public Archer(string name)
            : base(name, 100, 20)
        {
        }

        public override void Attack(Character target)
        {
            int damage = AttackPower;

            int chance = Random.Shared.Next(1, 101);

            if (chance <= 20)
            {
                damage *= 2;

                Console.WriteLine($"{Name} trafia podwójnie!");
            }
            else
            {
                Console.WriteLine($"{Name} strzela z łuku!");
            }

            target.TakeDamage(damage);
        }
    }
}
