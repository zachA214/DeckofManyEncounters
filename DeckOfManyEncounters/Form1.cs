using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfManyEncounters
{
    public partial class DeckOfManyEncounters : Form
    {
        public DeckOfManyEncounters()
        {
            InitializeComponent();
        }

        private void inputFormOpenButton_Click(object sender, EventArgs e)
        {
            InputForm inputF1 = new InputForm();
            //inputF1.ShowDialog();
            if (inputF1.ShowDialog() == DialogResult.OK)
            {
                string userInput1 = inputF1.UserInput1;
                string userInput2 = inputF1.UserInput2;
                string userInput3 = inputF1.UserInput3;

                MessageBox.Show($"User Input 1: {userInput1}\nUser Input 2: {userInput2}\nUser Input 3: {userInput3}");
            }
        }
    }
}
