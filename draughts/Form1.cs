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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) // Closes program
        {
            Application.Exit(); 
        }

        private void htpButton_Click(object sender, EventArgs e) // Opens tips form
        {
            htpForm tipsPage = new htpForm(); // Creates new instance of htp form
            tipsPage.Show(); // shows the new instance 
        }

        private void playGameButton_Click(object sender, EventArgs e) // Opens play game window
        {
            gameSetup setupMenu = new gameSetup(); // Creates a new instance of the gameSetupMenu
            this.Hide(); // Hides the current instance of the menu window
            setupMenu.Show(); // shows the new gameSetupMenu instance created earlier.
        }
    }
}
