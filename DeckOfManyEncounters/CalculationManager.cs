using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{
    
    public class CalculationManager
    {

        private FileManager fileManager = new FileManager();
       // private List<Encounter> encounters = new List<Encounter> { }; 

        private List<Monster> monsterList = new List<Monster> { };
        //calculation functions

        private List<Player> party = new List<Player> { };

        public void AddPlayer(string name, string classification, int level)
        {
            party.Add(new Player(name, classification, level));
        }

        //call to data processinggggg to develope monster list 
        public void GetEligibleMonsters(string realm)
        {
            int level = 0;
            foreach (Player player in party) level += player.Level;
            level /= party.Count;
            //populate monster list with call to fileManager
            fileManager.readData(realm, level, monsterList);
        }

        internal List<Encounter> GenerateEncounters(int challengeLevel, int difficulty, int creatureCount)
        {
            //encounters.Add()
            //call to calculations and append to list 
            return new List<Encounter> { };
        }

        
    }
}
