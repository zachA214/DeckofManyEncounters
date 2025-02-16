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
        public int DifficultyValue { get; set; }
        public int CreatureCount { get; set; }
        public string Realm { get; set; }
        public string Alignment { get; set; }
        public bool flyer { get; set; }
        public bool swimmer { get; set; }

        private bool difUpdate = false, realmUpdate = false, alignUpdate = false;
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
            else if (difficultyBox.Text == "WORLD ENDER") { DifficultyValue = 20; }
            CreatureCount = Convert.ToInt32(CreatureCounter.Value);
            Alignment = alignmentBox.Text;
            Realm = realmSelector.Text;
            flyer = flyerCheckBox.Checked;
            swimmer = swimmerCheckBox.Checked;
            this.Close();
        }

        private void realmSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            realmUpdate = true;
            if (difUpdate == true && realmUpdate == true && alignUpdate == true)
            {
                saveAndCloseInput.Enabled = true;
            }
        }

        private void difficultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alignmentBox_SelectedValueChanged(object sender, EventArgs e)
        {
            alignUpdate = true;
            if (difUpdate == true && realmUpdate == true && alignUpdate == true)
            {
                saveAndCloseInput.Enabled = true;
            }
        }

        private void difficultyBox_TextUpdate(object sender, EventArgs e)
        {
            difUpdate = true;
            if (difUpdate == true && realmUpdate == true && alignUpdate == true)
            {
                saveAndCloseInput.Enabled = true;
            }
        }
    }
}
