using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{   

    internal class Monster
    {
        private string name = string.Empty;

        public string Name { get { return name; } set { name = value; } }

        private string size = string.Empty;

        public string Size { get { return size; } set { size = value; } }   

        private string type = string.Empty;

        public string Type { get { return type; } set { type = value; } } 

        private string alignment = string.Empty;

        public string Alignment { get { return alignment; } set { alignment = value; } }   

        private int ac = 0;

        public int AC { get { return ac; } set { ac = value; } }

        private int hp = 0;

        public int HP { get { return hp; } set { hp = value;  } }

        private string speed = string.Empty;

        public string Speed { get { return speed; } set { speed = value; } }

        private int str = 0;

        public int STR { get { return str; } set { str = value; } }

        private int dex = 0;

        public int DEX { get { return dex;  } set { dex = value; } }

        private int con = 0; 

        public int CON { get { return con; } set { con = value; } }

        private int intelligence = 0;

        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        private int wis = 0;

        public int WIS { get { return wis; } set { wis = value; } };

        private int cha = 0;

        public int CHA { get { return cha; } set { cha = value; } }

        private string savThrows = string.Empty;

        public string SavThrows { get { return savThrows; } set { savThrows = value; } }

        private string skills = string.Empty;

        public string Skills { get { return skills; } set { skills = value; } } 

        private string wri = string.Empty;

        public string WRI { get { return wri; } set { wri = value; } }

        private string senses = string.Empty;

        public string Senses { get { return senses; } set { senses = value; } }

        private string languages = string.Empty;

        public string Languages { get { return languages; } set { languages = value; } }    

        private double challengeRating = 0.0;

        public double ChallengeRating { get { return ChallengeRating; } set { ChallengeRating = value; } }  

        private string additional = string.Empty; 

        public string Additional { get { return additional; } set { additional = value; } }

    }
}
