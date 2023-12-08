using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] gameboard = new string[9];
        int currentTurn = 0;



        public String returnSymbol(int turn)
        {
            if(turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";       
            }
        }

        public System.Drawing.Color determineColor(String symbol)
        {
            if (symbol.Equals("O"))
            {
                return System.Drawing.Color.OrangeRed;
            }
            else if (symbol.Equals("X"))
            {
                return System.Drawing.Color.LightCoral;
            }
            return System.Drawing.Color.White;
        }

        public void checkForWinner()
        {
            for(int i=0; i<8; i++)
            {
                String combination = "";
                int one = 0, two = 0, three = 0;

                switch (i)
                {
                    case 0:
                        combination = gameboard[0] + gameboard[4] + gameboard[8];
                        one = 0;
                        two = 4;
                        three = 8;
                        break;
                    case 1:
                        combination = gameboard[2] + gameboard[4] + gameboard[6];
                        one = 2;
                        two = 4;
                        three = 6;
                        break;
                    case 2:
                        combination = gameboard[0] + gameboard[1] + gameboard[2];
                        one = 0;
                        two = 1;
                        three = 2;
                        break;
                    case 3:
                        combination = gameboard[3] + gameboard[4] + gameboard[5];
                        one = 3;
                        two = 4;
                        three = 5;
                        break;
                    case 4:
                        combination = gameboard[6] + gameboard[7] + gameboard[8];
                        one = 6;
                        two = 7;
                        three = 8;
                        break;
                    case 5:
                        combination = gameboard[0] + gameboard[3] + gameboard[6];
                        one = 0;
                        two = 3;
                        three = 6;
                        break;
                    case 6:
                        combination = gameboard[1] + gameboard[4] + gameboard[7];
                        one = 1;
                        two = 4;
                        three = 7;
                        break;
                    case 7:
                        combination = gameboard[3] + gameboard[5] + gameboard[8];
                        one = 3;
                        two = 5;
                        three = 8;
                        break;
                }

                

                if (combination.Equals("OOO"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("<O> is win", "We have a winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(combination.Equals("XXX"))
                {
                    changeColor(one);
                    changeColor(two);
                    changeColor(three);
                    MessageBox.Show("<X> is win", "We have a winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                checkDraw();
            }
        }

        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            //Reset_Color
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            gameboard = new string[9];
            currentTurn = 0;
        }

        public void changeColor(int number)
        {
            switch (number)
            {
                case 0:
                    button1.BackColor = System.Drawing.Color.Lime;
                    break;
                case 1:
                    button2.BackColor = System.Drawing.Color.Lime;
                    break;
                case 2:
                    button3.BackColor = System.Drawing.Color.Lime;
                    break;
                case 3:
                    button4.BackColor = System.Drawing.Color.Lime;
                    break;
                case 4:
                    button5.BackColor = System.Drawing.Color.Lime;
                    break;
                case 5:
                    button6.BackColor = System.Drawing.Color.Lime;
                    break;
                case 6:
                    button7.BackColor = System.Drawing.Color.Lime;
                    break;
                case 7:
                    button8.BackColor = System.Drawing.Color.Lime;
                    break;
                case 8:
                    button9.BackColor = System.Drawing.Color.Lime;
                    break;
            }
        }

        public void checkDraw()
        {
            int counter = 0;
            for(int i=0; i<gameboard.Length; i++)
            {
               if(gameboard[i] != null) { counter++; }
               if(counter == 9)
                {
                    reset();
                    MessageBox.Show("That's a draw", "No winner today :(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[0] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[0]);
            button1.BackColor = buttonColor;
            button1.Text = gameboard[0];
            checkForWinner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[1]= returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[1]);
            button2.BackColor = buttonColor;
            button2.Text = gameboard[1];
            checkForWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[2] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[2]);
            button3.BackColor = buttonColor;
            button3.Text = gameboard[2];
            checkForWinner();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[3] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[3]);
            button4.BackColor = buttonColor;
            button4.Text = gameboard[3];
            checkForWinner();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[4] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[4]);
            button5.BackColor = buttonColor;
            button5.Text = gameboard[4];
            checkForWinner();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[5] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[5]);
            button6.BackColor = buttonColor;
            button6.Text = gameboard[5];
            checkForWinner();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[6] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[6]);
            button7.BackColor = buttonColor;
            button7.Text = gameboard[6];
            checkForWinner();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[7] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[7]);
            button8.BackColor = buttonColor;
            button8.Text = gameboard[7];
            checkForWinner();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentTurn++;
            gameboard[8] = returnSymbol(currentTurn);
            Color buttonColor = determineColor(gameboard[8]);
            button9.BackColor = buttonColor;
            button9.Text = gameboard[8];
            checkForWinner();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
