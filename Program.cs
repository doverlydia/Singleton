using System;

namespace Singleton
{
    class Program
    {
        public static Player player = new Player();
        public static Enemy enemy = new Enemy();
        static void Main(string[] args)
        {
            Console.WriteLine("Run game? 1 for yes 2 for no");
            int answrer = int.Parse(Console.ReadLine());

            if (answrer == 1)
                GameManager.Instance.runGame = true;
            else
                GameManager.Instance.runGame = false;
            
            player.Move();
            enemy.Attack();

            Console.ReadLine();
        }
    }
}
