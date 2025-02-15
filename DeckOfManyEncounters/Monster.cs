using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{   
    enum Size
    {
        Small, Medium, Large
    }
    internal class Monster
    {
        private string name;

        public string Name { get { return name; } set { name = value; } }

        private Size size;

        public Size Size { get { return size; } set { size = value; } }   

        private string type;

        public string Type { get { return type; } set { type = value; } } 

        private string alignment;

        public string Alignment { get { return alignment; } set { alignment = value; } }   

        private int ac;

        public int AC { get { return ac; } set { ac = value; } }

        private int hp;

        public int HP { get { return hp; } set { hp = value;  } }

        private string speed;

        public string Speed { get { return speed; } set { speed = value; } }

        private int str;

        public int STR { get { return str; } set { str = value; } }

        private int dex;

        public int DEX { get { return dex;  } set { dex = value; } }

        private int con; 

        public int CON { get { return con; } set { con = value; } }

        private int intelligence;

        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        private int wis;

        public int WIS { get { return wis; } set { wis = value; } };

        private int cha;

        public int CHA { get { return cha; } set { cha = value; } }

        private string savThrows;

        public string SavThrows { get { return savThrows; } set { savThrows = value; } }

        private string skills;

        public string Skills { get { return skills; } set { skills = value; } } 

        private string wri;

        public string WRI { get { return wri; } set { wri = value; } }

        private string senses;

        public string Senses { get { return senses; } set { senses = value; } }

        private string languages;

        public string Languages { get { return languages; } set { languages = value; } }    

        private double challengeRating;

        public double ChallengeRating { get { return ChallengeRating; } set { ChallengeRating = value; } }  

        private string additional; 

        public string Additional { get { return additional; } set { additional = value; } }

    }
}
