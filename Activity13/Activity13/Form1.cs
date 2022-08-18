using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }
        private void newGameButton_Click(object sender, EventArgs e)
        {
            const int Rows = 3;     //Variables for constructing the two-dimensional
            const int Cols = 3;
            int[,] board = new int[Rows, Cols];

            Random rn = new Random();

            for (int row = 0; row < Rows; row++)    //Fills the two dismensional array with eithe 0 or 1
            {
                for (int col = 0; col < Cols; col++)
                {
                    board[row, col] = rn.Next(2);
                }
            }

            //Gives the game board either X or O based on value assigned.
            if (board[0, 0] == 0)
            {
                row1Col1Box.Text = "O";
            }    
            else
            {
                row1Col1Box.Text = "X";
            }
            if (board[0, 1] == 0)
            {
                row1Col2Box.Text = "O";
            }
            else
            {
                row1Col2Box.Text = "X";
            }
            if (board[0, 2] == 0)
            {
                row1Col3Box.Text = "O";
            }
            else
            {
                row1Col3Box.Text = "X";
            }
            if (board[1, 0] == 0)
            {
                row2Col1Box.Text = "O";
            }
            else
            {
                row2Col1Box.Text = "X";
            }
            if (board[1, 1] == 0)
            {
                row2Col2Box.Text = "O";
            }
            else
            {
                row2Col2Box.Text = "X";
            }
            if (board[1, 2] == 0)
            {
                row2Col3Box.Text = "O";
            }
            else
            {
                row2Col3Box.Text = "X";
            }
            if (board[2, 0] == 0)
            {
                row3Col1Box.Text = "O";
            }
            else
            {
                row3Col1Box.Text = "X";
            }
            if (board[2, 1] == 0)
            {
                row3Col2Box.Text = "O";
            }
            else
            {
                row3Col2Box.Text = "X";
            }
            if (board[2, 2] == 0)
            {
                row3Col3Box.Text = "O";
            }
            else
            {
                row3Col3Box.Text = "X";
            }

            //Sees if row won
            if (board[0, 0].Equals(board[0, 1]) && board[0, 0].Equals(board[0, 2])) //Checks row victory
            {
                winnerLabel.Text = "Row is the winner!";
                

            }
            if (board[1, 0].Equals(board[1, 1]) && board[1, 0].Equals(board[1, 2]))
            {
                winnerLabel.Text = "Row is the winner!";
               
            }
            if (board[2, 0].Equals(board[2, 1]) && board[2, 0].Equals(board[2, 2]))
            {
                winnerLabel.Text = "Row is the winner!";
                
            }
            //Sees if column won
            if (board[0, 0].Equals(board[1, 0]) && board[0, 0].Equals(board[2, 0])) //Checks Column
            {
                winnerLabel.Text = "Col is the winner!";
                
            }
            if (board[0, 1].Equals(board[1, 1]) && board[0, 1].Equals(board[2, 1]))
            {
                winnerLabel.Text = "Col is the winner!";
                
            }
            if (board[0, 2].Equals(board[1, 2]) && board[0, 2].Equals(board[2, 2]))
            {
                winnerLabel.Text = "Col is the winner!";
                
            }
            //Sees if diag won
            if (board[0, 0].Equals(board[1, 1]) && board[0, 0].Equals(board[2, 2]))  //Checks Diag
            {
                winnerLabel.Text = "Diag is the winner!";
                
            }
            if (board[2, 2].Equals(board[1, 1]) && board[2, 2].Equals(board[0, 0]))
            {
                winnerLabel.Text = "Diag is the winner!";
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
