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
    // Win Form.
    {
        // Creates a board object.
        Board board2 = new Board();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Restarts the game.
            board2.resetGame();
            // Switches to the welcome screen.
            Form3 form = new Form3();
            this.Visible = false;
            form.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Closes the application.
            Application.Exit();
        }
    }
}
