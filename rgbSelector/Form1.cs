using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Joshua Williams 
   Class: CST-117
   Assignment: Milestone-1
   Project: RGB-Selector
*/

namespace rgbSelector
    
{
    public partial class rgbForm : Form
    {
        public rgbForm()
        {
            InitializeComponent();
        }

        private void rgbForm_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //Throws an exception if the user inputs a word or letter instead of a number.
            try
            {
                //Users RGB values will be stored here.
                //Each value will be converted from a string to an integer.
                int r = Convert.ToInt32(redTextbox.Text);
                int g = Convert.ToInt32(greenTextbox.Text);
                int b = Convert.ToInt32(blueTextbox.Text);
                previewTexbox.BackColor = Color.FromArgb(r,g,b);
            }
            catch
            {
                MessageBox.Show("Please Enter in a Numeric Value");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //When the exit button is clicked the user will exit the program.
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Resets the users RGB Values to 255 
            string defValue = "255";
            redTextbox.Text = defValue;
            greenTextbox.Text = defValue;
            blueTextbox.Text = defValue;

            int convertedValue = Convert.ToInt32(defValue);

            previewTexbox.BackColor = Color.FromArgb(convertedValue, convertedValue, convertedValue);

        }
    }

}
