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
        public PartyViewerForm()
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
            generateButton.Location = new Point(this.ClientSize.Width-10, 10); // Position the button at the top of the form
            generateButton.Click += (sender, e) => GenerateEntry(myPanel);
            this.Controls.Add(generateButton); // Add generate button to form
        }
        private void GenerateEntry(Panel panel)
        {
            // Create controls
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.Size = new Size(75, 23);
            deleteButton.Location = new Point(10, yPosition); // Position of delete button
            deleteButton.Click += (sender, e) => DeleteEntry(panel, deleteButton);

            Label nameLabel = new Label();
            nameLabel.Text = "Name: John Doe";
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
        private void DeleteEntry(Panel panel, Button deleteButton)
        {
            // Find the controls to delete
            foreach (Control control in panel.Controls)
            {
                if (control.Bounds.IntersectsWith(deleteButton.Bounds))
                {
                    // Remove controls related to this entry
                    panel.Controls.Remove(control);
                }
            }

            // Adjust the Y-position after deletion (optional, depends on desired behavior)
            yPosition -= 40; // Decrease Y-position to avoid overlap
        }
    }
}
