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
    {
        Board board = new Board();

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
        {
            string message = "You Win!" + board.currentTurn;
            board.checkWin();
            if (board.win == true)
            {
                Form2 form = new Form2();
                this.Visible = false;
                form.Show();
                System.Windows.Forms.Application.Exit();
            }
        }

        public void setColor(int _col)
        {
            int row = board.updateBoard(_col);

            if (row >= 0)
            {
                if (board.currentTurn == PLAYER.Yellow.ToString())
                {
                    bgColors[row, _col] = Color.Yellow;
                    tableLayoutPanel1.Refresh();
                    win();
                    board.NextTurn();
                    
                }
                else
                {
                    bgColors[row, _col] = Color.Red;
                    tableLayoutPanel1.Refresh();
                    win();
                    board.NextTurn();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            board.initializeBoard();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setColor(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setColor(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setColor(2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setColor(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setColor(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            setColor(5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            setColor(6);
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(bgColors[e.Row, e.Column]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
    }
}
