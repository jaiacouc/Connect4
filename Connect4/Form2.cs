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
    public partial class Form2 : Form
    {
        Board board2 = new Board();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            if (board2.currentTurn == PLAYER.Yellow.ToString())
            {
                label2.Text = PLAYER.Yellow.ToString();
            }
            else
            {
                label2.Text = PLAYER.Red.ToString();
            }
        }
    }
}
