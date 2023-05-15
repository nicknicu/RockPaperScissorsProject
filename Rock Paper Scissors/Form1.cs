using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {


        int rounds = 3;
        int timerPerRound = 6;

        bool gameover = false;

        string[] CPUchoiceList = {"rock", "paper", "scissor", "paper", "scissor", "rock" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUchoice;

        string playerChoice;

        int playerwins;
        int AIwins;


        public Form1()
        {
            InitializeComponent();
            countDownTimer.Enabled = true;
            playerChoice = "none";
            txtTime.Text = "5";
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissor";
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            timerPerRound -= 1;

            txtTime.Text = timerPerRound.ToString();
            roundsText.Text = skin.Rounds + rounds;

            if(timerPerRound < 1)
            {
                countDownTimer.Enabled = false;
                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUchoice = CPUchoiceList[randomNumber];

                switch(CPUchoice)
                {
                    case "rock":
                        picCPU.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        picCPU.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        picCPU.Image = Properties.Resources.scissors;
                        break;
                }


                if(rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if(playerwins > AIwins)
                    {
                        MessageBox.Show(skin.PlayerWin);
                    }
                    else
                    {
                        MessageBox.Show(skin.CPUWin);
                    }

                    gameover = true;
                }


            }
        }


        private void checkGame()
        {

            // AI and player win rules

            if(playerChoice == "rock" && CPUchoice == "paper")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Paper Covers Rocks");

            }
            else if(playerChoice == "scissor" && CPUchoice == "rock")
            {
                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Rock Breaks Scissors");
            }
            else if (playerChoice == "paper" && CPUchoice == "scissor")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Scissor cuts paper");

            }
            else if(playerChoice == "rock" && CPUchoice == "scissor")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Rock Breaks Scissors");

            }
            else if (playerChoice == "paper" && CPUchoice == "rock")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Paper Covers Rocks");

            }
            else if (playerChoice == "scissor" && CPUchoice == "paper")
            {
                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Scissor cuts paper");

            }
            else if(playerChoice == "none")
            {
                MessageBox.Show("Make your Choice");
            }
            else
            {
                MessageBox.Show("Draw");

            }

            startNextRound();
        }

        public void startNextRound()
        {

            if (gameover)
            {



                return;
            }

            txtMessage.Text = skin.player + playerwins + " - " + skin.Computer + AIwins;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
        }

        private void restartGame(object sender, EventArgs e)
        {
            playerwins = 0;
            AIwins = 0;
            rounds = 3;
            txtMessage.Text = skin.player + playerwins + " - " + skin.Computer + AIwins;

            playerChoice = "none";
            txtTime.Text = "5";
            
            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;

            gameover = false;
        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void LangSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (LangSelector.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja");
                    //Thread.CurrentThread.CurrentCulture = new System.Globalization.DateTimeFormatInfo("");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh");
                    break;
                case 3:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    break;
            }
            this.Controls.Clear();

            InitializeComponent();

        }

        private void txtMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
