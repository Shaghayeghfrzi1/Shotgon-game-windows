using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2
{
    public class Play
    {
        int yourScore = 0,
           systemScore = 0;
       
        public void YouLostScore()
        {
            yourScore--;
        }
        public void YouAddedScore()
        {
            yourScore++;
        }
        public void SystemLostScore()
        {
            systemScore--;
        }
        public void SystemAddedScore()
        {
            systemScore++;
        }
        public int YourScore()
        {
            return yourScore;
        }
        public int SystemScore()
        {
            return systemScore;
        }
        public int YourScoreStart()
        {
            yourScore = 0;
            return yourScore;
        }
        public int SystemScoreStart()
        {
            systemScore = 0;
            return systemScore;
        }
        //public bool YouAreGameOver()
        //{
        //    bool winner=true;

        //    if (yourScore < 0)
        //        winner = true;
        //    else if (systemScore < 0)
        //        winner = false;

        //    return winner;
        //}


    }
}
