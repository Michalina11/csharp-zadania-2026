using System;
using System.Collections.Generic;

namespace RPGInheritance
{
    public class Warrior : Character
    {
        public Warrior(string name)
            : base(name, 120, 25)
        {
        }

        public override void Attack(Character target)
        {
            int damage = AttackPower + 10;

            Console.WriteLine($"{Name} wykonuje silny atak mieczem!");

            target.TakeDamage(damage);
        }
    }
}
