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
        public string Realm = "", Alignment = "";
        public int CreatureCount = 0, DifficultyValue = 0;
        public bool flyer = true, swimmer = true;
        internal CalculationManager CM1 = new CalculationManager();

        private void partyButton_Click(object sender, EventArgs e)
        {
            PartyViewerForm partyF1 = new PartyViewerForm(CM1);
            if(partyF1.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show("Party Saved\n");
                this.Invalidate();
            }
        }


        public DeckOfManyEncounters()
        {
            InitializeComponent();

            this.Paint += DeckOfManyEncounters_Paint;
        
        }
        
        //creates 
        private void DeckOfManyEncounters_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font displayFont = new Font("Arial", 24); // Set a starting font size
            float squareSize = 20; // Size of the square (20x20)
            float leftMargin = 20; // Space from the left edge
            float xPosition = leftMargin; // Start from the left side
            float yPosition = 50; // Fixed Y position for the row

            // Measure the total width of all the names and their squares
            float totalWidth = 0;
            foreach (Player nameToDisplay in CM1.party)
            {
                SizeF stringSize = g.MeasureString(nameToDisplay.Name, displayFont);
                totalWidth += stringSize.Width + squareSize + 20; // Add space for the square and some padding
            }

            // Adjust font size to ensure totalWidth fits the screen width
            while (totalWidth > this.ClientSize.Width)
            {
                // Reduce font size by 10% and recalculate total width
                displayFont = new Font(displayFont.FontFamily, displayFont.Size * 0.9f);

                // Recalculate the total width after scaling the font size
                totalWidth = 0;
                foreach (Player nameToDisplay in CM1.party)
                {
                    SizeF stringSize = g.MeasureString(nameToDisplay.Name, displayFont);
                    totalWidth += stringSize.Width + squareSize + 20; // Add space for the square and some padding
                }
            }

            // Calculate starting X position to center the names
            xPosition = (this.ClientSize.Width - totalWidth) / 2;

            // Loop through each name in the list
            foreach (Player nameToDisplay in CM1.party)
            {
                // Measure the width of the current name
                SizeF stringSize = g.MeasureString(nameToDisplay.Name, displayFont);

                // Draw the name at the current x and y position with white color
                g.DrawString(nameToDisplay.Name, displayFont, Brushes.White, xPosition, yPosition);

                // Draw a small square under the name with white color
                float squareX = xPosition + (stringSize.Width - squareSize) / 2; // Center square under the name
                float squareY = yPosition + stringSize.Height + 5; // Position square below the name
                g.FillRectangle(Brushes.White, squareX, squareY, squareSize, squareSize);

                // Update the xPosition for the next name to be placed next to the current one
                xPosition += stringSize.Width + squareSize + 20; // Add space between names
            }
        }
        private void inputFormOpenButton_Click(object sender, EventArgs e)
        {
            InputForm inputF1 = new InputForm();
            //inputF1.ShowDialog();
            if (inputF1.ShowDialog() == DialogResult.OK)
            {
                this.DifficultyValue = inputF1.DifficultyValue;
                this.CreatureCount = inputF1.CreatureCount;
                this.Realm = inputF1.Realm;
                this.flyer = inputF1.flyer;
                this.swimmer = inputF1.swimmer;
                this.Alignment = inputF1.Alignment;

                MessageBox.Show($"Difficulty: {DifficultyValue}\nCreature Count: {this.CreatureCount}\nRealm: {this.Realm}\nFlyers?: {this.flyer}\nSwimmers?: {this.swimmer}\Alignment: {this.Alignment}");
            }
        }
    }
}
