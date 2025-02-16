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
    public partial class InputForm: Form
    {
        public decimal DifficultyValue { get; set; }
        public decimal CreatureCount { get; set; }
        public string Realm { get; set; }
        public bool flyer { get; set; }
        public bool swimmer { get; set; }

        private bool difUpdate = false, realmUpdate = false;
        public InputForm()
        {
            InitializeComponent();
        }

        private void saveAndCloseInput_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // converting difficulty from string to int
            if (difficultyBox.Text == "Easy") { DifficultyValue = -1; }
            else if (difficultyBox.Text == "Normal") { DifficultyValue = 0; }
            else if (difficultyBox.Text == "Hard") { DifficultyValue = 1; }
            else if (difficultyBox.Text == "Very Hard") { DifficultyValue = 2; }
            else if (difficultyBox.Text == "IMPOSSIBLE") { DifficultyValue = 12; }
            CreatureCount = CreatureCounter.Value;
            Realm = realmSelector.Text;
            flyer = flyerCheckBox.Checked;
            swimmer = swimmerCheckBox.Checked;
            this.Close();
        }

        private void realmSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            realmUpdate = true;
            if (difUpdate == true && realmUpdate == true)
            {
                saveAndCloseInput.Enabled = true;
            }
        }

        private void difficultyBox_TextUpdate(object sender, EventArgs e)
        {
            difUpdate = true;
            if(difUpdate == true && realmUpdate == true)
            {
                saveAndCloseInput.Enabled = true;
            }
        }
    }
}
