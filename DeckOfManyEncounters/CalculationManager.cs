using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{
    
    public class CalculationManager
    {
       // private List<Encounter> encounters = new List<Encounter> { }; 

        private List<Monster> monsterList = new List<Monster> { };
        //calculation functions

        private List<Player> party = new List<Player> { };

        public void AddPlayer(string name, string classification, int level)
        {
            party.Add(new Player(name, classification, level));
        }

        //call to data processinggggg to develope monster list 

        internal List<Encounter> GenerateEncounters(int challengeLevel, int difficulty, int creatureCount)
        {
            //encounters.Add()
            //call to calculations and append to list 
            return new List<Encounter> { };
        }

        
    }
}
