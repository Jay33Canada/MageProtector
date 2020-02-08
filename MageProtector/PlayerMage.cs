using System;
using System.Collections.Generic;
using System.Text;

namespace MageProtector
{
    class PlayerMage : Mage
    {
        public PlayerMage()
        {
            Console.Clear();
            Console.Write("Please enter your Mages name: ");
            name = Console.ReadLine();
            Console.Clear();
            ChangeAttackPower(250);
            ChangeDefense(2000);
        }

    }
}
