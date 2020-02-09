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
        public int defenseNumber = 1000;
        public int attackPower = 250;
        public int healAmount = 300;
        public bool shieldUsed = false;
        public void DisplayAttributes()
        {
            Console.WriteLine(name);
            Console.WriteLine(defense + defenseNumber);
            Console.WriteLine(power + attackPower);
            Console.WriteLine();
        }
        public void Heal()
        {
            defenseNumber += healAmount;
        }
        public void ChangeAttackPower(int power)
        {
            attackPower = power;
        }
        public void ChangeDefense(int defense)
        {
            defenseNumber += defense;
        }
        public void Shield()
        {
            // if they haven't used the shield, use it
            if(shieldUsed == false)
            {
                defenseNumber += 600;
                // set the shieldUsed to true, so they can't use this again if they somehow called it
                shieldUsed = true;
            }
        }
    }

}
