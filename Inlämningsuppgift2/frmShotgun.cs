using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift2
{
    public partial class frmShotgun : Form
    {
        Opponent opponent;
        Move move;
        Play play;

        public frmShotgun()
        {
            InitializeComponent();
            opponent = new Opponent();
            play = new Play();
            move = new Move();
        }


        //::::::::::::::::::::::METODER:::::::::::::::::::::::::::::
        public void YouWin()
        {
            lblYourShoots.Text = play.YourScoreStart().ToString();
            lblSystemsShoots.Text = play.SystemScoreStart().ToString();
            txtResult.Visible = true;
            txtResult.BackColor = Color.Green;
            txtResult.Text = "Grattis! Du är vinnare!";
            cmdPlayAgain.Visible = true;

        }
        public void GameOver()
        {
            lblYourShoots.Text = play.YourScoreStart().ToString();
            lblSystemsShoots.Text = play.SystemScoreStart().ToString();
            txtResult.Visible = true;
            txtResult.BackColor = Color.Red;
            txtResult.Text = "Va synd! Du är inte vinnare!";
            cmdPlayAgain.Visible = true;
        }
        public void CheckShootButton()
        {
            if (play.YourScore() == 0) cmdSkjuta.Enabled = false;
            else cmdSkjuta.Enabled = true;
        }
        public void ActiveYourShotgun()
        {
            if (play.YourScore() >= 3) cmdShotgun.Visible = true;
            else cmdShotgun.Visible = false;
        }
        public void YouAreGameOver()
        {
            if (play.YourScore() < 0)
                GameOver();
            else if (play.SystemScore() < 0)
                YouWin();
        }
        public string CmdShowOpponentsChoice(int opponentsPosition)
        {
            string value;
            if (opponentsPosition == 1) value = "Ladda";
            else if (opponentsPosition == 2) value = "Blocka";
            else if (opponentsPosition == 3) value = "Skjuta";
            else if (opponentsPosition == 4) value = "Shotgun";
            else value = "Motståndare";
            return value;
        }
        public void ShowRandomSituation(int systemScores)
        {
            if (systemScores == 0)
                cmdSystem.Text = CmdShowOpponentsChoice(opponent.GetRandomWithoutShoot());
            else if (systemScores < 3 && systemScores > 0)
                cmdSystem.Text = CmdShowOpponentsChoice(opponent.GetRandom());
            else 
                cmdSystem.Text = CmdShowOpponentsChoice(opponent.GetRandomShotgun());
        }
        //::::::::::::::::::::::::::KNAPPAR::::::::::::::::::::::::::::::::::::
        private void cmdSkjuta_Click(object sender, EventArgs e)
        {//SHOOT

            ShowRandomSituation(play.SystemScore());
            string result = move.YouShoot(play.SystemScore());

            if (result == "SHOOT_LOAD")
            {
                YouWin();
            }
            else if (result == "SHOOT_BLOCK")
            {
                play.YouLostScore();
                lblYourShoots.Text = play.YourScore().ToString();
            }
            else if (result == "SHOOT_SHOOT")
            {
                play.YouLostScore();
                lblYourShoots.Text = play.YourScore().ToString();
                play.SystemLostScore();
                lblSystemsShoots.Text = play.SystemScore().ToString();
            }
            else if (result == "SHOOT_SHOTGUN")
            {
                GameOver();
            }

            //YouAreGameOver();
            ActiveYourShotgun();
        }

        private void cmdBlocka_Click_1(object sender, EventArgs e)
        {//BLOCK

            ShowRandomSituation(play.SystemScore());
            string result = move.YouBlock(play.SystemScore());

            if (result == "BLOCK_LOAD")
            {
                play.SystemAddedScore();
                lblSystemsShoots.Text = play.SystemScore().ToString();
            }
            else if (result == "BLOCK_SHOOT")
            {
                play.SystemLostScore();
                lblSystemsShoots.Text = play.SystemScore().ToString();
            }
            else if (result == "BLOCK_SHOTGUN")
            {
                GameOver();
            }


            //YouAreGameOver();
            CheckShootButton();
            ActiveYourShotgun();
        }

        private void cmdShotgun_Click_1(object sender, EventArgs e)
        {//SHOTGUN
            CheckShootButton();

            ShowRandomSituation(play.SystemScore());
            string result = move.YouShootgun(play.SystemScore());

            if (result == "SHOTGUN")
            {
                YouWin();
            }
            else if (result == "SHOTGUN_SHOTGUN")
            {
                play.YouLostScore();
                lblYourShoots.Text = play.YourScore().ToString();
                play.SystemLostScore();
                lblSystemsShoots.Text = play.SystemScore().ToString();
            }

            //YouAreGameOver();

            ActiveYourShotgun();
        }

        private void cmdPlayAgain_Click(object sender, EventArgs e)
        {
            lblYourShoots.Text = play.YourScoreStart().ToString();
            lblSystemsShoots.Text = play.SystemScoreStart().ToString();
            txtResult.Visible = false;
            cmdPlayAgain.Visible = false;
            cmdShotgun.Visible = false;
            cmdSkjuta.Enabled = false;
            cmdSystem.Text = "Motståndare";
        }

        private void cmdLadda_Click_1(object sender, EventArgs e)
        {//LOAD

            ShowRandomSituation(play.SystemScore());
            string result = move.YouLoad(play.SystemScore());


            if (result == "LOAD_LOAD")
            {
                play.YouAddedScore();
                lblYourShoots.Text = play.YourScore().ToString();
                play.SystemAddedScore();
                lblSystemsShoots.Text = play.SystemScore().ToString();
            }
            else if (result == "LOAD_BLOCK")
            {
                play.YouAddedScore();
                lblYourShoots.Text = play.YourScore().ToString();
            }
            else if (result == "LOAD_SHOOT" || result == "LOAD_SHOTGUN")
            {
                GameOver();
            }

            //YouAreGameOver();
            CheckShootButton();
            ActiveYourShotgun();

        }

    }
}

