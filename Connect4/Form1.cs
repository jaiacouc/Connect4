using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    // Game Form.
    {
        // Creates a board object.
        Board board = new Board();


        // Creates a color array to assign the colors to the table.
        Color[,] bgColors = new Color[6, 7]
        {
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  },
            {SystemColors.Control, SystemColors.Control, SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control , SystemColors.Control  }
        };

        public void win()
        // Method that used to facilitate calling the check win methods.
        // Then switches to the next turn.
        {
            board.checkWin();
            board.NextTurn();
            if (board.win == true)
            {
                // Switches to the winning form then closes the previous form.
                Form2 form = new Form2();
                this.Visible = false;
                form.ShowDialog();
                System.Windows.Forms.Application.Exit();
            }
        }

        public void setColor(int _col)
        {
            // Calls the update board method then uses the return row to update the color array.
            int row = board.updateBoard(_col);

            // Protects against array out of bounds.
            if (row >= 0)
            {
                // Checks for players turn.
                if (board.currentTurn == PLAYER.Yellow.ToString())
                {
                    // Prints the players turn on screen.
                    nameLabel.Text = NameOfPlayer.playerNameTwo;
                    // Sets the array position on the table to yellow.
                    bgColors[row, _col] = Color.Yellow;
                    tableLayoutPanel1.Refresh();
                    // Calls win method.
                    win();
                }
                else
                {
                    // Prints the players turn on screen.
                    nameLabel.Text = NameOfPlayer.playerNameOne;
                    // Sets array position on the table to red.
                    bgColors[row, _col] = Color.Red;
                    tableLayoutPanel1.Refresh();
                    // Calls win method.
                    win();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            // Sets the initial turn to player1.
            nameLabel.Text = NameOfPlayer.playerNameOne;
            // Initializes the game board.
            board.initializeBoard();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Quits the application.
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
         // Column 1 button, calls the set color method to update the board.
        {
            setColor(0);
        }

        private void button2_Click(object sender, EventArgs e)
        // Column 2 button, calls the set color method to update the board.
        {
            setColor(1);
        }

        private void button3_Click(object sender, EventArgs e)
        // Column 3 button, calls the set color method to update the board.
        {
            setColor(2);
        }

        private void button4_Click(object sender, EventArgs e)
        // Column 4 button, calls the set color method to update the board.
        {
            setColor(3);
        }

        private void button5_Click(object sender, EventArgs e)
        // Column 5 button, calls the set color method to update the board.
        {
            setColor(4);
        }

        private void button6_Click(object sender, EventArgs e)
        // Column 6 button, calls the set color method to update the board.
        {
            setColor(5);
        }

        private void button7_Click(object sender, EventArgs e)
        // Column 7 button, calls the set color method to update the board.
        {
            setColor(6);
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        // Allows the table cell to change color.
        {
            using (var b = new SolidBrush(bgColors[e.Row, e.Column]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
         // Restarts the game.
        {
            board.resetGame();
            Form3 form = new Form3();
            this.Visible = false;
            form.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }
    }
}
