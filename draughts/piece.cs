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

namespace draughts
{
    public class piece
    {
        public bool king = false;
        public bool clicked;
        public Button counter = new Button();
        Panel[,] board = new Panel[8, 8]; 
        public int player;
        public bool active = true;


        public Button createPiece(int x, int y, int pieceHeight, int pieceWidth, int playerColour, Panel[,] grid, int playerNum) // Places button on the board
        {
            player = playerNum;
            Button tempCounter = new Button();
            tempCounter.Height = pieceHeight;
            tempCounter.Width = pieceWidth;
            tempCounter.Location = new Point(x, y);
            if (playerColour == 1)
            {
                tempCounter.BackColor = Color.White;
                tempCounter.ForeColor = Color.White;
            }
            else if (playerColour == 2)
            {
                tempCounter.BackColor = Color.Red;
                tempCounter.ForeColor = Color.Red;
            }
            tempCounter.Click += new EventHandler(piece_click);
            board = grid;
            counter = tempCounter;
            return tempCounter;
        }
        public List<int> findMoves(Panel[,] grid, int player)  //Finds the moves a player can make
        {
            List<int> possibleMoves = new List<int>();
            int x = counter.Location.X;
            int y = counter.Location.Y;
            int m1X = 0;
            int m1Y = 0;
            int m2X = 0;
            int m2Y = 0;
            int m3X = 0;
            int m3Y = 0;
            int m4X = 0;
            int m4Y = 0;


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (x == grid[i, j].Location.X && y == grid[i, j].Location.Y)
                    {
                        if (player == 1) // locations for player 1
                        {

                            if (king == true)
                            {
                                m1X = i + 1;
                                m1Y = j - 1;
                                m2X = i - 1;
                                m2Y = j - 1;
                                m3X = i + 1;
                                m3Y = j + 1;
                                m4X = i - 1;
                                m4Y = j + 1;
                            }
                            else
                            {
                                m1X = i + 1;
                                m1Y = j + 1;
                                m2X = i - 1;
                                m2Y = j + 1;
                            }

                            if (king == true)
                            {
                                possibleMoves.Add(m1X);
                                possibleMoves.Add(m1Y);
                                possibleMoves.Add(m2X);
                                possibleMoves.Add(m2Y);
                                possibleMoves.Add(m3X);
                                possibleMoves.Add(m3Y);
                                possibleMoves.Add(m4X);
                                possibleMoves.Add(m4Y);
                            }
                            else
                            {
                                possibleMoves.Add(m1X);
                                possibleMoves.Add(m1Y);
                                possibleMoves.Add(m2X);
                                possibleMoves.Add(m2Y);
                            }
                        }
                        else if (player == 2) // locations for player 2
                        {


                            if (king == true)
                            {
                                m1X = i + 1;
                                m1Y = j + 1;
                                m2X = i - 1;
                                m2Y = j + 1;
                                m3X = i + 1;
                                m3Y = j - 1;
                                m4X = i - 1;
                                m4Y = j - 1;
                            }
                            else
                            {
                                m1X = i - 1;
                                m1Y = j - 1;
                                m2X = i + 1;
                                m2Y = j - 1;
                            }

                            if (king == true)
                            {
                                possibleMoves.Add(m1X);
                                possibleMoves.Add(m1Y);
                                possibleMoves.Add(m2X);
                                possibleMoves.Add(m2Y);
                                possibleMoves.Add(m3X);
                                possibleMoves.Add(m3Y);
                                possibleMoves.Add(m4X);
                                possibleMoves.Add(m4Y);
                            }
                            else
                            {
                                possibleMoves.Add(m1X);
                                possibleMoves.Add(m1Y);
                                possibleMoves.Add(m2X);
                                possibleMoves.Add(m2Y);
                            }
                        }

                    }
                }
            }

            return possibleMoves;
        }

        public void pieceMove(int xPosMove, int yPosMove)  // Moves a piece
        {
            counter.Location = new Point(xPosMove, yPosMove);
        }

        public void piece_click(object sender, EventArgs e) // Event to deal with piece click
        {
            int x = counter.Location.X;
            int y = counter.Location.Y;
            clicked = true;
        }

        public void kingRefresh()
        {
            if (king == true && counter.BackColor == Color.Red)
            {
                counter.BackColor = Color.Maroon;
            }
            else if (king == true && counter.BackColor == Color.White)
            {
                counter.BackColor = Color.Cyan;
            }
        }

        public void refreshState()
        {
            if (active == false)
            {
                counter.Enabled = false;
                counter.Visible = false;
            }
        }



    }
}
