using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForagingJoeAI
{
    class AI
    {
        static void Main(string[] args)
        {
            // Test movement using psuedo positional values
            Random RandomNumber = new Random();
            int playerRandomPOS = RandomNumber.Next(0, 40);
            int enemyRandomPOS = RandomNumber.Next(0, 40);
            int playerEnemyDiff = 0;
            do
            {
                //playerRandomPOS = RandomNumber.Next(0, 40);
                //enemyRandomPOS = RandomNumber.Next(0, 40);
                playerEnemyDiff = playerRandomPOS - enemyRandomPOS;
                if (playerEnemyDiff < 0)
                {
                    playerEnemyDiff *= 1;
                }
                    
                Console.WriteLine("Current Player Position: {0}", playerRandomPOS);
                Console.WriteLine("Current Enemy Position: {0}", enemyRandomPOS);
            }

            while (enemyRandomPOS != playerRandomPOS);

            Console.WriteLine("Enemy has reached Player");
        }
    }
}
