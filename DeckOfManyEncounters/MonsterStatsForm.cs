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
    public partial class MonsterStatsForm: Form
    {
        internal MonsterStatsForm(Monster myMonster)
        {
            InitializeComponent();

            monsterStat.Text += "Name: " + myMonster.Name + "\nSize: " + myMonster.Size + "\nType: " + myMonster.Type +
                "\nAlignment: " + myMonster.Alignment + "\nAC: " + myMonster.AC + "\nHP: " + myMonster.HP + "\nSpeed: " + myMonster.Speed +
                "\nSTR: " + myMonster.STR + "\nDEX: " + myMonster.DEX + "\nCON: " + myMonster.CON + "\nIntelligence: " + myMonster.Intelligence +
                "\nWIS: " + myMonster.WIS + "\nCHA: " + myMonster.CHA + "\nSavThrows: " + myMonster.SavThrows + "\nSkills: " + myMonster.Skills +
                "\nWRI: " + myMonster.WRI + "\nSenses: " + myMonster.Senses + "\nLanguages: " + myMonster.Languages + "\nChallengeRating: " + myMonster.ChallengeRating +
                "\nAdditional: " + myMonster.Additional + "\nHasFly: " + myMonster.HasFly + "\nHasSwim: " + myMonster.HasSwim + "\nRealm: " + myMonster.Realm;
        }
    }
}
