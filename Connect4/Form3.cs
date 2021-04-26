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
    public partial class Form3 : Form
        // Welcome Form.
    {
        // Creates board object.
        Board board = new Board();
        public Form3()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        // Exits application.
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sets the player name variables to the text box inputs.
            NameOfPlayer.playerNameOne = textBox1.Text;
            NameOfPlayer.playerNameTwo = textBox2.Text;
            // Switches to the main game form.
            Form1 form = new Form1();
            this.Visible = false;
            form.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }
    }
}
