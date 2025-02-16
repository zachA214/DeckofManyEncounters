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
    public partial class PartyViewerForm: Form
    {
        private int yPosition = 10;
        public PartyViewerForm(CalculationManager CM1)
        {
            InitializeComponent();

            // Create the panel and manually set its size and location
            Panel myPanel = new Panel();
            myPanel.Location = new Point(0, 40); // Leave space for the button at the top
            myPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 40); // Subtract 40 for the margin
            myPanel.AutoScroll = true; // Enable automatic scrolling
            this.Controls.Add(myPanel); // Add panel to form

            // Button to generate a new entry (positioned above the panel)
            Button generateButton = new Button();
            generateButton.Text = "Generate Entry";
            generateButton.Location = new Point(10, 10); // Position the button at the top of the form
            generateButton.Click += (sender, e) => GenerateEntry(myPanel, CM1);
            this.Controls.Add(generateButton); // Add generate button to form
                                               // Button to generate a new entry (positioned above the panel)
            Button saveAndExitButton = new Button();
            saveAndExitButton.Text = "Save and Close";
            saveAndExitButton.Width = saveAndExitButton.Width * 4 - saveAndExitButton.Width * 2;
            saveAndExitButton.Location = new Point(this.ClientSize.Width - saveAndExitButton.Width - 10, 10); // Position the button at the top of the form
            saveAndExitButton.Click += (sender, e) => saveAndExit(sender, e);
            this.Controls.Add(saveAndExitButton); // Add generate button to form
        }

        private void saveAndExit(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void GenerateEntry(Panel panel, CalculationManager CM1)
        {
            PartyMemberInputForm PMIF = new PartyMemberInputForm();
            if (PMIF.ShowDialog() == DialogResult.OK)
            {
                CM1.AddPlayer(PMIF.characterName, PMIF.characterClass, PMIF.characterLevel);
                // Create controls
                Button deleteButton = new Button();
                deleteButton.Text = "Delete";
                deleteButton.Size = new Size(75, 23);
                deleteButton.Location = new Point(10, yPosition); // Position of delete button
                deleteButton.Click += (sender, e) => DeleteEntry(panel, deleteButton);

                Label nameLabel = new Label();
                nameLabel.Text = "Name: " + "hi";
                nameLabel.Location = new Point(100, yPosition); // Position of Name label

                Label titleLabel = new Label();
                titleLabel.Text = "Title: Mr.";
                titleLabel.Location = new Point(250, yPosition); // Position of Title label

                Label ageLabel = new Label();
                ageLabel.Text = "Age: 30";
                ageLabel.Location = new Point(400, yPosition); // Position of Age label

                // Add controls to the panel
                panel.Controls.Add(deleteButton);
                panel.Controls.Add(nameLabel);
                panel.Controls.Add(titleLabel);
                panel.Controls.Add(ageLabel);

                // Update the Y-position for the next entry
                yPosition += 40; // Adjust this value for spacing between entries
            }
            else
            {
                MessageBox.Show("Character addition failed\n");
            }
        }
        private void DeleteEntry(Panel panel, Button deleteButton)
        {
            // Find the controls to delete (delete button and associated labels)
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in panel.Controls)
            {
                if (control.Top == deleteButton.Top)
                {
                    controlsToRemove.Add(control);
                }
            }

            // Remove the controls associated with this entry
            foreach (Control control in controlsToRemove)
            {
                panel.Controls.Remove(control);
            }

            // After deleting, reposition all remaining entries
           RepositionEntries(panel);
        }

        // Method to reposition all entries after deletion
       private void RepositionEntries(Panel panel)
       {
            //reset yPosition
            yPosition = 10;

            //x position for each element
            List<int> xPosition = new List<int>();
            xPosition.Add(10);
            xPosition.Add(100);
            xPosition.Add(250);
            xPosition.Add(400);

            int x = 0;
            foreach (Control control in panel.Controls)
            {
                //move it to the proper place the on the screen
                control.Location = new Point(xPosition[x], yPosition);
                x++;
                //go to the next line
                if(x == 4)
                {
                    x = 0;
                    yPosition += 40;
                }
            }
            //remove all data from list
            xPosition.Clear();
        }


    }
}
