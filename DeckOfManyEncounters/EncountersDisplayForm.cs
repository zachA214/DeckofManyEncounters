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
        private Image small = Image.FromFile("MonsterImages/TinyFly.png");
        private Image medium = Image.FromFile("MonsterImages/medium_guy.png");
        private Image large = Image.FromFile("MonsterImages/OrcLarge.png");
        private Image huge = Image.FromFile("MonsterImages/huge_guy.png");
        private Image garg = Image.FromFile("MonsterImages/PurpleWormGarg.png");
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

                PictureBox monsterImage = new PictureBox();
                switch (encounterList[0].MonsterList[i].Size)
                {
                    case "Small":
                        monsterImage.Image = small;
                        break;
                    case "Medium":
                        monsterImage.Image = medium;
                        break;
                    case "Large":
                        monsterImage.Image = large;
                        break;
                    case "Huge":
                        monsterImage.Image = huge;
                        break;
                    case "Gargantuan":
                        monsterImage.Image = garg;
                        break;
                }
                monsterImage.Location = new Point(280, yPos);
                monsterImage.Size = new Size(60, 60);

                panel1.Controls.Add(monsterName);
                panel1.Controls.Add(monsterImage);


                yPos += 40; // Adjust this value for spacing between entries
            }

        }
    }
}

