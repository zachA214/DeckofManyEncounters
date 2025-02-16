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

            for(int j = 0; j < 6; j++)
            {
                encounterTabs.SelectTab(j);
                yPos = 10;
                for(int i = 0; i < encounterList[j].MonsterList.Count(); i++)
                {
                    Label monsterName = new Label();
                    monsterName.Text = encounterList[j].MonsterList[i].Name;
                    monsterName.Size = new Size(250, 23);
                    monsterName.Location = new Point(30, yPos); 
                    //monsterName.MouseHover += (sender, e) => monsterName.Cursor = Cursors.Hand;
                    monsterName.Click += (sender, e) => getMonsterStats(sender, e, encounterList[j].MonsterList[i]);

                    PictureBox monsterImage = new PictureBox();
                    switch (encounterList[j].MonsterList[i].Size)
                    {
                        case "Tiny":
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
                        default:
                            MessageBox.Show("Failure");
                            break;
                    }
                    monsterImage.Location = new Point(280, yPos);
                    monsterImage.Size = new Size(32, 32);

                    switch(j)
                    {
                        case 0:
                            panel1.Controls.Add(monsterName);
                            panel1.Controls.Add(monsterImage);
                            break;
                        case 1:
                            panel2.Controls.Add(monsterName);
                            panel2.Controls.Add(monsterImage);
                            break;
                        case 2:
                            panel3.Controls.Add(monsterName);
                            panel3.Controls.Add(monsterImage);
                            break;
                        case 3:
                            panel4.Controls.Add(monsterName);
                            panel4.Controls.Add(monsterImage);
                            break;
                        case 4:
                            panel5.Controls.Add(monsterName);
                            panel5.Controls.Add(monsterImage);
                            break;
                        case 5:
                            panel6.Controls.Add(monsterName);
                            panel6.Controls.Add(monsterImage);
                            break;

                    }



                    yPos += 40; // Adjust this value for spacing between entries
                }
            }


        }

        internal void getMonsterStats(object sender, EventArgs e, Monster myMonster)
        {
            MonsterStatsForm MSF = new MonsterStatsForm(myMonster);
            //inputF1.ShowDialog();
            if (MSF.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}

