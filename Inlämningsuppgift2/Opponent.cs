using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2
{
    public class Opponent
    {
        public int OpponentScore { get; set; }

        public Opponent()
        {
            ////block = BlockScore.Score;
            ////load = LoadScore.Score;
            ////shoot = ShootScore.Score;
        }

        public int GetRandom()
        {

            Random oppRandom = new Random();
            int opponentRandom = oppRandom.Next(1, 4);
            OpponentScore = opponentRandom;
            return OpponentScore;
        }
        public int GetRandomShotgun()
        {
            Random oppRandom = new Random();
            int opponentRandom = oppRandom.Next(1, 5);
            OpponentScore = opponentRandom;
            return OpponentScore;
        }
        public int GetRandomWithoutShoot()
        {
            Random oppRandom = new Random();
            int opponentRandom= oppRandom.Next(1, 3);

            //while (true)
            //{
            //    if((opponentRandomTemp= oppRandom.Next(1, 4))!=2)
            //    {
            //        opponentRandom = opponentRandomTemp;
            //        break;
            //    }

            //}
            OpponentScore = opponentRandom;

            return OpponentScore;
        }


    }
}
