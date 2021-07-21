using System;
using System.Collections.Generic;
using System.Text;

namespace snakeandladder
{
    class snakeandladder
    {
            
        public void gamestarts()
        {
            Random random = new Random();
            int firstroll = random.Next(1, 7);
            Console.WriteLine("player's new position is:" + firstroll);
        }
    }
}
