using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{
    
    public class CalculationManager
    {
        private List<Monster> monsterList = new List<Monster> { };
        //calculation functions

        private List<Player> party = new List<Player> { };

        public void AddPlayer(string name, string classification, int level)
        {
            party.Add(new Player(name, classification, level));
        }

        
    }
}
