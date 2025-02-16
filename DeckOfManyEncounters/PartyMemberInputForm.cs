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
    public partial class PartyMemberInputForm: Form
    {
        public string characterName { get; set; }
        public string characterClass { get; set; }
        public int characterLevel { get; set; }

        private bool nameCheck = false, classCheck = false;
        public PartyMemberInputForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            characterName = nameInput.Text;
            characterClass = classBox.Text;
            characterLevel = Convert.ToInt32(levelBox.Value);
            this.Close();
        }

        private void classBox_SelectedValueChanged(object sender, EventArgs e)
        {
            classCheck = true;
            if (nameCheck == true && classCheck == true)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            // if a non-whitespace character exists
            nameCheck = false;
            foreach(char c in nameInput.Text)
            {
                if(!char.IsWhiteSpace(c))
                {
                    nameCheck = true;
                }
            }

            if (nameCheck == true && classCheck == true)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
                
        }
    }
}
