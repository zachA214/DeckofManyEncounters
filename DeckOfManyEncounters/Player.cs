using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{
    internal class Player
    {
        private int level = 0; 

        public int Level { get { return level; } set { level = value; } }  

        private string name = string.Empty;

        public string Name { get { return name; } set { name = value; } }   

        private string classification = string.Empty; 

        public string Classification { get { return classification; } set { classification = value; } } 

        public Player(string  name, string classification, int level)
        {
            this.name = name;
            this.classification = classification;
            this.level = level;
        }
    }
}
