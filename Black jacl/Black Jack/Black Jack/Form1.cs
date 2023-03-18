using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Black_Jack
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool bust, hit;
        bool call = true;
        bool gamestate = true;
        int Player = 0;
        int value;
        decimal bet = 10;
        bool enter = false;
        int House = 0;
        bool stand = false;
        bool setup = true;
        decimal Cash = 100;
        int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        int card;
        

        private void hitbutton_Click(object sender, EventArgs e)
        {
            HIT();
        }

        private void standclick(object sender, EventArgs e)
        {
            Stand();
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                hit = false;
            }
            if (e.KeyCode == Keys.S)
            {
                stand = false;
            }
            if (e.KeyCode == Keys.Enter)
            {
                enter = false;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.H)
            {
                hit = true;

            }
            if (e.KeyCode == Keys.S)
            {
                stand = true;
            }
            if (e.KeyCode == Keys.Enter && gamestate == false)
            {
                RestartRound();
            }

            if (e.KeyCode == Keys.Enter)
            {
                enter = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Round();
        }

        private void gametime(object sender, EventArgs e)
        {
            if (gamestate == true)
            {
                if (Cash <= 0)
                {
                    broke.Visible = true;
                    gamestate = false;
                }
                txtStatus.Text = "Status: " + gamestate;
                txtHouse.Text = "House: " + House;
                txtScore.Text = "Total: " + Player;
                txtCard.Text = "Recent Card: " + card;
                txtCash.Text = "Cash: " + Cash;
                txtBet.Text = "Bet: " + bet;                
                if (Cash <= 1000)
                {
                    if (Cash >= 0)
                    {
                        progressBar1.Value = (int)Cash;
                    }
                }
                else
                {
                    progressBar1.Value = 1000;
                }
                if (Cash >= 10)
                {
                    numud.Minimum = 10;
                }
                else
                {
                    numud.Maximum = Cash;
                }
                if (infinitycheckbox.Checked)
                {
                    Cash = 1000;
                }
                

                numud.Maximum = Cash;
                //bet = numud.Value;
                

                //call
                if (stand == true)
                {
                    if (setup == true)
                    {
                        card = cards[rnd.Next(0, 12)];

                        House = House + card;
                        setup = false;
                    }
                    
                    if (House < 15)
                    {
                        if (cheat2.Checked)
                        {
                            txtHouse.Text = "House Lost " + House;
                            txtScore.Text = "You Won! " + Player;
                            Cash += bet;
                            Win.Visible = true;
                            gamestate = false;
                        }
                        else
                        {
                            card = cards[rnd.Next(0, 12)];
                            txtCard.Text = "Recent Card: " + card;
                            House = House + card;
                        }                        
                    }
                    else
                    {
                        if (cheat2.Checked)
                        {
                            txtHouse.Text = "House Lost " + House;
                            txtScore.Text = "You Won! " + Player;
                            Cash += bet;
                            Win.Visible = true;
                            gamestate = false;
                        }
                        else
                        {
                            if (House > Player)
                            {
                                txtHouse.Text = "House Won " + House;
                                txtScore.Text = "You Lost " + Player;
                                Cash -= bet;
                                endscreen.Visible = true;
                                gamestate = false;
                            }
                            if (House > 21)
                            {
                                txtHouse.Text = "House BUST " + House;
                                Win.Text = "You Won! " + Player;
                                Cash += bet;
                                Win.Visible = true;
                                gamestate = false;
                            }
                            if (Player > House)
                            {
                                txtHouse.Text = "House Lost " + House;
                                txtScore.Text = "You Won! " + Player;
                                Cash += bet;
                                Win.Visible = true;
                                gamestate = false;
                            }
                            if (House == Player)
                            {
                                txtHouse.Text = "Draw " + House;
                                txtScore.Text = "Draw " + Player;
                                gamestate = false;
                            }
                            if (Player > 21)
                            {
                                txtHouse.Text = "House Wins " + House;
                                txtScore.Text = "BUST " + Player;
                                Cash -= bet;
                                endscreen.Visible = true;
                                bust = true;
                                gamestate = false;
                            }
                            RestartButton.Visible = true;
                        }
                    }
                }
            }
            if (Player > 21 && stand == false && gamestate == true)
            {
                txtHouse.Text = "House Wins " + House;
                txtScore.Text = "BUST " + Player;
                Cash -= bet;
                endscreen.Visible = true;
                bust = true;
                gamestate = false;
            }
            if (gamestate == false)
            {
                txtCash.Text = "Cash: " + Cash;
                txtStatus.Text = "Status: " + gamestate;
                RestartButton.Visible = true;
            }  
        }
        

        private void restartClick(object sender, EventArgs e)
        {
            RestartRound();
        }

        public void Round()
        {
            //house
            card = cards[rnd.Next(0, 12)];
            House = House + card;
            stand = false;

            //anything else
            endscreen.Visible = false;
            Win.Visible = false;
            betButton.Visible = true;

            //player
            card = cards[rnd.Next(0, 12)];
            Player = Player + card;
            card = cards[rnd.Next(0, 12)];
            Player = Player + card;

            



        }

        public void HIT()
        {
            

            if (bust == false && Player <= 21 && stand == false)
            {
                card = cards[rnd.Next(0, 12)];
                
                Player = Player + card;
                call = false;
                betButton.Visible = false;

            }
            else
            {
                txtScore.Text = "HEY YOU CAN'T DO THAT!";
            }

        }
        public void Stand()
        {
            stand = true;
            /*
            card = cards[rnd.Next(0, 12)];

            House = House + card;
            
            txtHouse.Text = "House: " + House;
            txtScore.Text = "Total: " + Player;

            while (gamestate == true)
            {
                txtStatus.Text = "Status: " + gamestate;
                txtHouse.Text = "House: " + House;
                txtScore.Text = "Total: " + Player;
                txtCard.Text = "Recent Card: " + card;
                if (House > Player)
                {
                    txtHouse.Text = "House Won";
                    txtScore.Text = "You Lost";
                }
                if (House > 21)
                {
                    txtHouse.Text = "House Lost";
                    txtScore.Text = "You Won!";
                    Thread.Sleep(3000);
                    gamestate = false;
                }
                if (Player > House)
                {
                    txtHouse.Text = "House Lost";
                    txtScore.Text = "You Won!";
                    Thread.Sleep(3000);
                    gamestate = false;
                }
                if (House > Player)
                {
                    txtHouse.Text = "House Won";
                    txtScore.Text = "You Lost";
                    Thread.Sleep(3000);
                    gamestate = false;
                }
                if (House == Player)
                {
                    txtHouse.Text = "Draw";
                    txtScore.Text = "Draw";
                    Thread.Sleep(3000);
                    gamestate = false;
                }
                if (House < 15)
                {
                    card = cards[rnd.Next(0, 12)];
                    txtCard.Text = "Recent Card: " + card;
                    House = House + card;
                }
            }
            */


        }

        private void Bet(object sender, EventArgs e)
        {
            if (call == true)
            {
                bet = numud.Value;
                txtBet.Text = "Bet: " + bet;
                call = false;
                betButton.Visible = false;
            }
        }

        public void RestartRound()
        {
            RestartButton.Visible = false;
            gamestate = true;
            bust = false;
            Player = 0;
            House = 0;
            card = 0;
            bet = 10;
            stand = false;
            Win.Visible = true;
            endscreen.Visible = true;
            setup = true;
            betButton.Visible = true;
            broke.Visible = false;
            txtBet.Text = "Bet: 0";
            betButton.Visible = true;
            call = true;

            Round();
        }


    }
}
