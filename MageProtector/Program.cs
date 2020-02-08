using System;

namespace MageProtector
{
    class Program
    {
        static void Main(string[] args)
        {
            //updated 
            Introduction intro = new Introduction();
            PlayerMage Player = new PlayerMage();
            EnemyMage EasyEnemy = new EnemyMage();
            Fight(Player, EasyEnemy);
        }
        static void Fight(PlayerMage player, EnemyMage enemy)
        {
            player.DisplayAttributes();
            enemy.DisplayAttributes();
        }
    }
}
