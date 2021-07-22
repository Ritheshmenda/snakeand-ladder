using System;
using System.Collections.Generic;
using System.Text;

namespace snakeandladder
{
    class snakeandladder
    {
            
        public void gamestarts()
        {
            int lastposition = 0;
            int initial = 0;
            int count = 0;
            while (initial < 100)
            {
                count++;
                Random random = new Random();
                int firstroll = random.Next(1, 7);
                int option = random.Next(1, 3);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ladder");
                        Console.WriteLine("player position is :" + firstroll);
                        initial += firstroll;
                        if (initial > 100)
                        {
                            initial -= firstroll;
                            lastposition = initial;
                            Console.WriteLine("player position will retained in :" + lastposition);
                        }
                        Console.WriteLine("initial player position that is  :" + initial);
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
                        Console.WriteLine("chance denied");
                        break;
                }
                Console.WriteLine("no of trials for die :" + count);
            }
        }
    }
}
