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
    public partial class gameSetup : Form
    {
        
        public gameSetup()
        {
            InitializeComponent();
            p1cRequired.Hide();  //Hides the "required" label telling the user to pick an option.
            p2cRequired.Hide();  //Hides the "required" label telling the user to pick an option.
        }

        private void timeLimitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e) // returns to menu
        {
            Form1 menu = new Form1(); // Creates new menu window
            this.Hide();
            menu.Show();
        }

        private void p1ColourCombo_SelectedIndexChanged(object sender, EventArgs e) // Changes if both values in dropdown are the same
        {
            string choiceP1 = this.p1ColourCombo.GetItemText(this.p1ColourCombo.SelectedItem); // Handles the current combo box for player 1
            string choiceP2 = this.p2ColourCombo.GetItemText(this.p2ColourCombo.SelectedItem); // Handles the current combo box for player 2

            if ((choiceP1 == "White") && (choiceP2 == "White"))
            {
                p2ColourCombo.SelectedIndex = p2ColourCombo.FindStringExact("Red");
            }

            if ((choiceP1 == "Red") && (choiceP2 == "Red"))
            {
                p2ColourCombo.SelectedIndex = p2ColourCombo.FindStringExact("White");
            }

        }

        private void p2ColourCombo_SelectedIndexChanged(object sender, EventArgs e) // Changes choice if both values in dropdown are the same
        {
            string choiceP1 = this.p1ColourCombo.GetItemText(this.p1ColourCombo.SelectedItem); // Handles the current combo box for player 1 
            string choiceP2 = this.p2ColourCombo.GetItemText(this.p2ColourCombo.SelectedItem); // Handles the current combo box for player 2 

            if ((choiceP1 == "White") && (choiceP2 == "White"))
            {
                p1ColourCombo.SelectedIndex = p1ColourCombo.FindStringExact("Red");
            }

            if ((choiceP1 == "Red") && (choiceP2 == "Red"))
            {
                p1ColourCombo.SelectedIndex = p1ColourCombo.FindStringExact("White");
            }
        }

        private void startGame_Click(object sender, EventArgs e)
        { 
            int p1Colour = 0;
            int p2Colour = 0;

            if (p1ColourCombo.Text == "White") // Converts combo box values to integer values for player 1 
            {
                p1Colour = 1;
            }
            else if (p1ColourCombo.Text == "Red")
            {
                p1Colour = 2;
            }
            if (p2ColourCombo.Text == "White") // Converts combo box values to integer values for player 2
            {
                p2Colour = 1;
            }
            else if (p2ColourCombo.Text == "Red")
            {
                p2Colour = 2;
            }
            // End of conversion
            if ((string.IsNullOrEmpty(p1ColourCombo.Text)) || (string.IsNullOrEmpty(p2ColourCombo.Text))) // Checks to see if combo boxes do have colours selected.
            {
                p1cRequired.Show();
                p2cRequired.Show();
            }
            else
            {
                gameWindow gameWindow = new gameWindow(p1Colour, p2Colour, Convert.ToInt32(timeLimitCombo.SelectedItem)); // launches game window
                gameWindow.Show();
                p1cRequired.Hide();
                p2cRequired.Hide();
            }
        }
    }
}
