using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Player
    {
        public Player() { }
        public void Move()
        {
            if (GameManager.Instance.runGame == true)
                Console.WriteLine("Player Is Moving");
        }
    }

    class Enemy
    {
        public Enemy() { }

        public void Attack()
        {
            if (GameManager.Instance.runGame == true)
                Console.WriteLine("Enemy Attack");
        }
    }
}
