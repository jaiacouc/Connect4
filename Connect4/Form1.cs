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

        public Form1()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            board.updateBoard(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            board.updateBoard(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            board.updateBoard(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            board.updateBoard(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            board.updateBoard(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            board.updateBoard(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            board.updateBoard(7);
        }
    }
}
