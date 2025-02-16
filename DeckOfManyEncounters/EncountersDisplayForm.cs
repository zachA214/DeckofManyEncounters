using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfManyEncounters
{
    public partial class EncountersDisplayForm: Form
    {
        private int yPos = 10;
        internal EncountersDisplayForm(List<Encounter> encounterList)
        {
            InitializeComponent();
            encounterTabs.SelectTab(0);

            for(int i = 0; i < encounterList[0].MonsterList.Count(); i++)
            {
                Label monsterName = new Label();
                monsterName.Text = encounterList[0].MonsterList[i].Name;
                monsterName.Size = new Size(250, 23);
                monsterName.Location = new Point(30, yPos); // Position of delete button
                //monsterName.Click += (sender, e) => DeleteEntry(panel, deleteButton, CM1);

                panel1.Controls.Add(monsterName);


                yPos += 40; // Adjust this value for spacing between entries
            }

        }
    }
}
