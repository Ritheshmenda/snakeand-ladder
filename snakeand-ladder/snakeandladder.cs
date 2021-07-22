using System;
using System.Collections.Generic;
using System.Text;

namespace snakeandladder
{
    class snakeandladder
    {
            
        public void gamestarts()
        {
            int initial = 0;
            Random random = new Random();
            int firstroll = random.Next(1, 7);
            int option = random.Next(1, 3);
            switch (option)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    Console.WriteLine("player position is :" + firstroll);
                    break;
                case 2:
                    Console.WriteLine("roll value is" + firstroll);
                    Console.WriteLine("Snake");
                    initial -= firstroll;
                    if (initial < 0)
                        initial = 0;
                    Console.WriteLine("initial player position that is  :" + initial);
                    break;
                default:
                    Console.WriteLine("no play");
                    break;
            }
        }
    }
}
