using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift2
{
    public class Move
    {
        public int YourPosition { get; set; }
        public int YourShoots { get; set; }
        public int OpponentShoots { get; set; }

        public Move()
        {
            //kollar påp skott

        }

        Opponent opponent = new Opponent();
        Play play = new Play();
        string result = " ";

        //public int GetPosition(int systemScorePosition)
        //{
        //    
        //        int opponentPosition;
        //            if (systemScorePosition == 0)
        //            {
        //                opponentPosition = opponent.GetRandomWithoutShoot();
        //            }
        //            else if (systemScorePosition< 3 && systemScorePosition> 0)
        //            {
        //                opponentPosition = opponent.GetRandom();
        //            }
        //            else
        //{
        //    opponentPosition = opponent.GetRandomShotgun();
        //}
        //    return opponentPosition;
        //}
        public string YouLoad(int systemScorePosition)
        {
            opponent = new Opponent();

            int opponentPosition;
            if (systemScorePosition == 0)
            {
                opponentPosition = opponent.GetRandomWithoutShoot();
            }
            else if (systemScorePosition < 3 && systemScorePosition > 0)
            {
                opponentPosition = opponent.GetRandom();
            }
            else
            {
                opponentPosition = opponent.GetRandomShotgun();
            }

            if (opponentPosition == 1) //Ladda mot ladda
            {
                result = "LOAD_LOAD";
            }
            else if (opponentPosition == 2) //Ladda mot blocka
            {
                result = "LOAD_BLOCK";
            }
            else if (opponentPosition == 3) //Ladda mot skjuta
            {
                result = "LOAD_SHOOT";
            }

            if (opponentPosition == 4) //Ladda mot shotgun
            {
                result = "LOAD_SHOTGUN";
            }

            return result;

        }
        public string YouBlock(int systemScorePosition)
        {
            opponent = new Opponent();

            int opponentPosition;
            if (systemScorePosition == 0)
            {
                opponentPosition = opponent.GetRandomWithoutShoot();
            }
            else if (systemScorePosition < 3 && systemScorePosition > 0)
            {
                opponentPosition = opponent.GetRandom();
            }
            else
            {
                opponentPosition = opponent.GetRandomShotgun();
            }



            if (opponentPosition == 1) //Blocka mot ladda
            {
                result = "BLOCK_LOAD";

            }
            //Blocka mot blocka  //händer ingen, result = "BLOCK_BLOCK";
            else if (opponentPosition == 3) //Blocka mot skjuta
            {
                result = "BLOCK_SHOOT";
            }

            if (opponentPosition == 4) //Blocka mot shotgun
            {
                result = "BLOCK_SHOTGUN";
            }

            return result;
        }
        public string YouShoot(int systemScorePosition)
        {
            opponent = new Opponent();

            int opponentPosition;
            if (systemScorePosition == 0)
            {
                opponentPosition = opponent.GetRandomWithoutShoot();
            }
            else if (systemScorePosition < 3 && systemScorePosition > 0)
            {
                opponentPosition = opponent.GetRandom();
            }
            else
            {
                opponentPosition = opponent.GetRandomShotgun();
            }

            if (opponentPosition == 1) //Skjuta mot ladda
            {
                result = "SHOOT_LOAD";

            }
            else if (opponentPosition == 2) //Skjuta mot blocka
            {
                result = "SHOOT_BLOCK";
            }
            else if (opponentPosition == 3) //Skjuta mot skjuta
            {
                result = "SHOOT_SHOOT";
            }

            if (opponentPosition == 4) //Skjuta mot shotgun
            {
                result = "SHOOT_SHOTGUN";
            }

            return result;
        }

        public string YouShootgun(int systemScorePosition)
        {
            opponent = new Opponent();
            int opponentPosition;

            if (systemScorePosition == 0)
            {
                opponentPosition = opponent.GetRandomWithoutShoot();
            }
            else
            {
                opponentPosition = opponent.GetRandomShotgun();
            }


            if (opponentPosition == 1) //Shotgun mot ladda
            {
                result = "SHOTGUN";
            }
            else if (opponentPosition == 2) //Shotgun mot blocka
            {
                result = "SHOTGUN";
            }
            else if (opponentPosition == 3) //Shotgun mot skjuta
            {
                result = "SHOTGUN";
            }

            if (opponentPosition == 4) //shotgun mot shotgun
            {
                //play.YouLostScore();
                //play.SystemLostScore();
                result = "SHOTGUN_SHOTGUN";
            }

            return result;
        }
        public string ResultGame()
        {
            return result;
        }

    }
}
