using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class GameManager
    {
        #region declare singleton pattern
        private static GameManager gameManager;

        public static GameManager Instance
        {
            get
            {
                if(gameManager == null)
                {
                    gameManager = new GameManager();
                }
                return gameManager;
            }
        }
        #endregion

        public bool runGame = false;
    }
}
