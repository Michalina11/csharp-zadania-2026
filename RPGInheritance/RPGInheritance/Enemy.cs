using System;
using System.Collections.Generic;

namespace RPGInheritance
{
    public class Enemy : Character
    {
        public Enemy(string name)
            : base(name, 150, 20) 
        {
        }
        
        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} atakuje przecinika!");

            target.TakeDamage(AttackPower);
        }
    }
}
