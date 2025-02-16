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
        public string Realm , oh = "";
        public decimal CreatureCount = 0, DifficultyValue = 0;
        public bool flyer = true, swimmer = true;
        public CalculationManager CM1;

        private void partyButton_Click(object sender, EventArgs e)
        {
            PartyViewerForm partyF1 = new PartyViewerForm();
            if(partyF1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Party Saved\n");
            }
        }


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
                this.DifficultyValue = inputF1.DifficultyValue;
                this.CreatureCount = inputF1.CreatureCount;
                this.Realm = inputF1.Realm;
                this.flyer = inputF1.flyer;
                this.swimmer = inputF1.swimmer;

                MessageBox.Show($"Difficulty: {DifficultyValue}\nCreature Count: {this.CreatureCount}\nRealm: {this.Realm}\nFlyers?: {this.flyer}\nSwimmers?: {this.swimmer}");
            }
        }
    }
}
