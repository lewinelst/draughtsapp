using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace draughts
{
    public partial class gameWindow : Form
    {
        private int p1Colour;
        private int p2Colour;
        private int timeLeft;
        public bool panelClick { get; set; } //Bool for click
        public Panel selectedPos { get; set; } //Finds object click event is called from
        bool p1Turn = true;
        bool p2Turn = false;
        public int movePosX; //Final move location for X
        public int movePosY; //Fiaal move location for Y

        public gameWindow(int p1ColourSend, int p2ColourSend, int gameTime)
        {
            p1Colour = p1ColourSend;
            p2Colour = p2ColourSend;
            timeLeft = (gameTime * 60);
            InitializeComponent();
        }

        private void gameWindow_Load(object sender, EventArgs e)
        {
            game();
        }
        public void boardSetup(Panel[,] board) // Function to assign an array with matching board pannels - c is the column, r is the row
        {
            board[0, 0] = c0r0;
            board[1, 0] = c1r0;
            board[2, 0] = c2r0;
            board[3, 0] = c3r0;
            board[4, 0] = c4r0;
            board[5, 0] = c5r0;
            board[6, 0] = c6r0;
            board[7, 0] = c7r0;
            board[0, 1] = c0r1;
            board[1, 1] = c1r1;
            board[2, 1] = c2r1;
            board[3, 1] = c3r1;
            board[4, 1] = c4r1;
            board[5, 1] = c5r1;
            board[6, 1] = c6r1;
            board[7, 1] = c7r1;
            board[0, 2] = c0r2;
            board[1, 2] = c1r2;
            board[2, 2] = c2r2;
            board[3, 2] = c3r2;
            board[4, 2] = c4r2;
            board[5, 2] = c5r2;
            board[6, 2] = c6r2;
            board[7, 2] = c7r2;
            board[0, 3] = c0r3;
            board[1, 3] = c1r3;
            board[2, 3] = c2r3;
            board[3, 3] = c3r3;
            board[4, 3] = c4r3;
            board[5, 3] = c5r3;
            board[6, 3] = c6r3;
            board[7, 3] = c7r3;
            board[0, 4] = c0r4;
            board[1, 4] = c1r4;
            board[2, 4] = c2r4;
            board[3, 4] = c3r4;
            board[4, 4] = c4r4;
            board[5, 4] = c5r4;
            board[6, 4] = c6r4;
            board[7, 4] = c7r4;
            board[0, 5] = c0r5;
            board[1, 5] = c1r5;
            board[2, 5] = c2r5;
            board[3, 5] = c3r5;
            board[4, 5] = c4r5;
            board[5, 5] = c5r5;
            board[6, 5] = c6r5;
            board[7, 5] = c7r5;
            board[0, 6] = c0r6;
            board[1, 6] = c1r6;
            board[2, 6] = c2r6;
            board[3, 6] = c3r6;
            board[4, 6] = c4r6;
            board[5, 6] = c5r6;
            board[6, 6] = c6r6;
            board[7, 6] = c7r6;
            board[0, 7] = c0r7;
            board[1, 7] = c1r7;
            board[2, 7] = c2r7;
            board[3, 7] = c3r7;
            board[4, 7] = c4r7;
            board[5, 7] = c5r7;
            board[6, 7] = c6r7;
            board[7, 7] = c7r7;
        }

        private void placePieceTest(int x, int y, Panel [,] board) // Places a single piece - used for testing
        {
            Button counter = new Button();
            int pieceHeight = 40;
            int pieceWidth = 40;
            piece boardPiece = new piece();
            counter = boardPiece.createPiece(x, y, pieceHeight, pieceWidth, 1, board, 1);
            Controls.Add(counter);
        }

        private List<piece> PlacePieces(List<piece> playerPieces, Panel[,] board, int player)
        {
            if (player == 1)
            {
                for (int i = 0; i < 8; i++) // place player 1's pieces 1st row and 3rd
                {
                    i += 1;
                    for (int j = 0; j < 3; j++)
                    {
                        Panel currentPos = board[i, j];
                        int x = currentPos.Location.X;
                        int y = currentPos.Location.Y;
                        Button counter = new Button();
                        int pieceHeight = 40;
                        int pieceWidth = 40;
                        piece boardPiece = new piece();
                        counter = boardPiece.createPiece(x, y, pieceHeight, pieceWidth, p1Colour, board, player);
                        Controls.Add(counter);
                        counter.BringToFront();
                        j += 1;
                        playerPieces.Add(boardPiece);

                    }


                }

                for (int i = 0; i < 8; i++) // place player 1's pieces 2nd row
                {
                    Panel currentPos = board[i, 1];
                    int x = currentPos.Location.X;
                    int y = currentPos.Location.Y;
                    Button counter = new Button();
                    int pieceHeight = 40;
                    int pieceWidth = 40;
                    piece boardPiece = new piece();
                    counter = boardPiece.createPiece(x, y, pieceHeight, pieceWidth, p1Colour, board, player);
                    Controls.Add(counter);
                    counter.BringToFront();
                    i += 1;
                    playerPieces.Add(boardPiece);
                }
            }
            else if (player == 2)
            {
                for (int i = 0; i < 8; i++) // place player 2's pieces 6th and 8th rows
                {
                    for (int j = 5; j < 8; j++)
                    {
                        Panel currentPos = board[i, j];
                        int x = currentPos.Location.X;
                        int y = currentPos.Location.Y;
                        Button counter = new Button();
                        int pieceHeight = 40;
                        int pieceWidth = 40;
                        piece boardPiece = new piece();
                        counter = boardPiece.createPiece(x, y, pieceHeight, pieceWidth, p2Colour, board, player);
                        Controls.Add(counter);
                        counter.BringToFront();
                        playerPieces.Add(boardPiece);
                        j += 1;
                    }
                    i += 1;
                }

                for (int i = 0; i < 8; i++) // place player 2's pieces 7th row
                {
                    i += 1;
                    Panel currentPos = board[i, 6];
                    int x = currentPos.Location.X;
                    int y = currentPos.Location.Y;
                    Button counter = new Button();
                    int pieceHeight = 40;
                    int pieceWidth = 40;
                    piece boardPiece = new piece();
                    counter = boardPiece.createPiece(x, y, pieceHeight, pieceWidth, p2Colour, board, player);
                    Controls.Add(counter);
                    counter.BringToFront();
                    playerPieces.Add(boardPiece);

                }
            }

            return playerPieces;
        }


        public void game() // Code to run the game
        {
            currentPlayerLabel.Text = "1"; // Sets default value for player label
            Panel[,] board = new Panel[8, 8];
            List<piece> p1Pieces = new List<piece>();
            List<piece> p2Pieces = new List<piece>();
            boardSetup(board);
            panelEventAssign(board, p1Pieces, p2Pieces);
            p1Pieces = PlacePieces(p1Pieces, board, 1);
            p2Pieces = PlacePieces(p2Pieces, board, 2);
            if (timeLeft > 0)
            {
                gameTimer.Enabled = true;
            }

        }

        public void panelEventAssign(Panel[,] board, List<piece> p1Pieces, List<piece> p2Pieces)  // Assigns each panel their event on click
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j].Click += delegate(object sender, EventArgs e)
                    {
                        pos_click(sender, e, board, p1Pieces, p2Pieces);
                    };
                }

            }
        }
        public void pos_click(object sender, EventArgs e, Panel[,] board, List<piece> p1Pieces, List<piece> p2Pieces) //Event for a panel click and piece movement
        {
            bool moveMade = true; //Implimented to stop conflicting pieces, 1 move per event allowed
            panelClick = true;
            bool validMove;
            selectedPos = sender as Panel;
            List<int> moves = new List<int>();

            if (moveMade == true)
            {
                foreach (piece i in p1Pieces)  //Checks player 1's pieces to see if any have been clicked
                {
                    if (i.clicked == true) // makes move if conditions for player 2 are valid
                    {
                        i.clicked = false;
                        movePosX = selectedPos.Location.X;
                        movePosY = selectedPos.Location.Y;
                        if (p1Turn == true)
                        {
                            moves = i.findMoves(board, 1);
                            validMove = validMoveCheck(moves, selectedPos, board, i, p1Pieces, p2Pieces);
                            if (validMove == true)
                            {
                                if (p1Turn == true & i.player == 1)
                                {
                                    i.pieceMove(movePosX, movePosY); //Moves piece to new point
                                    i.clicked = false;
                                    p1Turn = false;
                                    p2Turn = true;
                                    moveMade = false;
                                    winCheck(p1Pieces, p2Pieces); // checks for a win
                                    currentPlayerLabel.Text = "2";
                                }
                                else
                                {

                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid move, please try another.");
                            }
                        }
                    }

                }
            }
            if (moveMade == true)
            {
                foreach (piece i in p2Pieces)
                {
                    if (i.clicked == true) //Checks player 2's pieces to see if any have been clicked
                    { 
                        i.clicked = false;
                        movePosX = selectedPos.Location.X;
                        movePosY = selectedPos.Location.Y;
                        if (p2Turn == true)
                        {
                            moves = i.findMoves(board, 2);
                            validMove = validMoveCheck(moves, selectedPos, board, i, p1Pieces, p2Pieces);
                            if (validMove == true)
                            {
                                if (p2Turn == true & i.player == 2) //Makes move if conditions for player 2 are valid
                                {
                                    i.pieceMove(movePosX, movePosY); //Moves piece tio new point
                                    i.clicked = false;
                                    p2Turn = false;
                                    p1Turn = true;
                                    moveMade = false;
                                    winCheck(p1Pieces, p2Pieces); // checks for a win
                                    currentPlayerLabel.Text = "1";
                                }
                                else
                                {

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid move, please try another.");
                        }
                    }
                }
            }

        }

        public bool validMoveCheck(List<int> moves, Panel selectedPos, Panel[,] board, piece selectedPiece, List<piece> p1Pieces, List<piece> p2Pieces) //Checks the move I am making is valid and returns a bool
        {
            int x = selectedPos.Location.X;
            int y = selectedPos.Location.Y;
            int moveX = 55; // Needed to have a value assigned hence I chose one outside the boards range
            int moveY = 55;
            bool validMove = false;
            for (int i = 0; i < 8; i++) // convert locaiton into an interger value that is compatable with the array that manages the board.
            {
                for (int j = 0; j < 8; j++)
                {
                    if (x == board[i, j].Location.X & y == board[i, j].Location.Y)
                    {
                        moveX = i;
                        moveY = j;
                    }
                    else
                    {

                    }
                }

            }

            if (((moves[0] == moveX) & (moves[1] == moveY)) || ((moves[2] == moveX) & (moves[3] == moveY)))
            {
                validMove = true;
            }
            else
            {
                validMove = false;
            }

            if (selectedPiece.king == true)
            {
                if (((moves[0] == moveX) & (moves[1] == moveY)) || ((moves[2] == moveX) & (moves[3] == moveY)) || ((moves[4] == moveX) & (moves[5] == moveY)) || ((moves[6] == moveX) & (moves[7] == moveY)))
                {
                    validMove = true;
                }
                else
                {
                    validMove = false;
                }
            }
            if (selectedPiece.player == 1) // player 1 move check and interaction
            {
                foreach (piece i in p1Pieces) // player 1 check that move locaiton isn't already taken by a players own piece
                {
                    if ((i.counter.Location.X == x) & (i.counter.Location.Y == y))
                    {
                        validMove = false;
                    }
                    else
                    {

                    }
                }

                foreach (piece j in p2Pieces.ToList()) // checks for other players pieces
                {
                    if ((j.counter.Location.X == x) & (j.counter.Location.Y == y))
                    {
                        if (j.counter.Location.X < selectedPiece.counter.Location.X)
                        {
                            movePosX = board[moveX - 1, moveY + 1].Location.X;
                            movePosY = board[moveX - 1, moveY + 1].Location.Y;
                        }
                        else if (j.counter.Location.X > selectedPiece.counter.Location.X)
                        {
                            movePosX = board[moveX + 1, moveY + 1].Location.X;
                            movePosY = board[moveX + 1, moveY + 1].Location.Y;
                        }
                        
                        if (selectedPiece.king == true) // collision if a piece is a king
                        {
                            if (j.counter.Location.Y < selectedPiece.counter.Location.Y)
                            {
                                if (j.counter.Location.X < selectedPiece.counter.Location.X)
                                {
                                    movePosX = board[moveX - 1, moveY - 1].Location.X;
                                    movePosY = board[moveX - 1, moveY - 1].Location.Y;

                                }
                                else if (j.counter.Location.X > selectedPiece.counter.Location.X)
                                {
                                    movePosX = board[moveX + 1, moveY - 1].Location.X;
                                    movePosY = board[moveX + 1, moveY - 1].Location.Y;
                                }
                            }

                        }
                        foreach (piece l in p2Pieces) // checks to see if a piece is behind the one being taken
                        {
                            if ((movePosX == l.counter.Location.X) & (movePosY == l.counter.Location.Y))
                            {
                                validMove = false;
                            }
                        }
                        foreach (piece i in p1Pieces) // verifies a player dosen't have one of their own pieces behind the one being taken.
                        {
                            if ((i.counter.Location.X == x) & (i.counter.Location.Y == y))
                            {
                                validMove = false;
                            }

                        }
                        if (validMove == true) // validates the move is stil valid
                        {
                            j.active = false; //removes if other player has a piece in location.
                            j.refreshState();
                            p2Pieces.Remove(j); // removes piece from other players list
                        }
                    }
                }
                if (validMove == true)
                {
                    if (moveY == 7)
                    {
                        selectedPiece.king = true;
                        selectedPiece.kingRefresh();
                    }
                }
            }

            else if (selectedPiece.player == 2) // player 2 move check and interaction
            {
                foreach (piece i in p2Pieces) // player 2 check that move locaiton isn't already taken by a players own piece
                {
                    if ((i.counter.Location.X == x) & (i.counter.Location.Y == y))
                    {
                        validMove = false;
                    }
                    else
                    {

                    }
                }

                foreach (piece j in p1Pieces.ToList()) // checks for other players pieces
                {
                    if ((j.counter.Location.X == x) & (j.counter.Location.Y == y)) 
                    {
                        if (j.counter.Location.X < selectedPiece.counter.Location.X)
                        {
                            movePosX = board[moveX - 1, moveY - 1].Location.X;
                            movePosY = board[moveX - 1, moveY - 1].Location.Y;
                                
                        }
                        else if (j.counter.Location.X > selectedPiece.counter.Location.X)
                        {
                            movePosX = board[moveX + 1, moveY - 1].Location.X;
                            movePosY = board[moveX + 1, moveY - 1].Location.Y;
                        }

                        if (selectedPiece.king == true) // collision if a piece is a king
                        {
                            if (j.counter.Location.Y > selectedPiece.counter.Location.Y)
                            {
                                if (j.counter.Location.X < selectedPiece.counter.Location.X)
                                {
                                    movePosX = board[moveX - 1, moveY - 1].Location.X;
                                    movePosY = board[moveX - 1, moveY - 1].Location.Y;

                                }
                                else if (j.counter.Location.X > selectedPiece.counter.Location.X)
                                {
                                    movePosX = board[moveX + 1, moveY - 1].Location.X;
                                    movePosY = board[moveX + 1, moveY - 1].Location.Y;
                                }

                            }
                        }
                        foreach (piece l in p1Pieces) // checks to see if a piece is behind the one being taken
                        {
                            if ((movePosX == l.counter.Location.X) & (movePosY == l.counter.Location.Y))
                            {
                                validMove = false;
                            }
                        }
                        foreach (piece i in p2Pieces) // verifies a player dosen't have one of their own pieces behind the one being taken.
                        {
                            if ((i.counter.Location.X == x) & (i.counter.Location.Y == y))
                            {
                                validMove = false;
                            }

                        }
                        if (validMove == true) // validates the move is still valid
                        {
                            j.active = false; //removes if other player has a piece in location.
                            j.refreshState();
                            p1Pieces.Remove(j); // removes piece from other players list
                        }
                    }
                }
                if (validMove == true)
                {
                    if (moveY == 0)
                    {
                        selectedPiece.king = true;
                        selectedPiece.kingRefresh();
                    }
                }
            }
            return validMove;
        }

        void winCheck(List<piece> p1Pieces, List<piece> p2Pieces) // Checks to see if a player has any pieces yet, then declares a winner if they don't
        {
            if (p1Pieces.Count == 0)
            {
                MessageBox.Show("Player 2 has won!");
                this.Close();
            }
            else if (p2Pieces.Count == 0)
            {
                MessageBox.Show("Player 1 has won!");
                this.Close();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft -= 1;
            timeDisplay.Text = timeLeft.ToString();
            if (timeLeft == 0)
            {
                gameTimer.Enabled = false;
                MessageBox.Show("Time ran out!");
                this.Close();
            }
        }
    }
}

