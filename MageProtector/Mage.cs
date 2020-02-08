using System;
using System.Collections.Generic;
using System.Text;

namespace MageProtector
{
    abstract class Mage
    {
        public string name = "Mage";
        public string defense = "Defense: ";
        public string power = "Attack Power: ";
        private int defenseNumber = 1000;
        private int attackPower = 100;
        private int healAmount = 300;

        public void Heal()
        {
            defenseNumber += 300;
            Console.WriteLine("\n{0} healed for {1}'n", name, healAmount);
        }
        public void Attack()
        {
        }
        public void Shield()
        {
            defenseNumber += 600;
        }
    }

}
