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

        internal List<Monster> monsterList = new List<Monster> { };
        //calculation functions

        internal List<Player> party = new List<Player> { };

        public int getPartyCount()
        {
            return party.Count;
        }

        public int getMonsterListCount()
        {
            return monsterList.Count;
        }

        public void AddPlayer(string name, string classification, int level)
        {
            party.Add(new Player(name, classification, level));
        }

        public void RemovePlayer(int index)
        {
            party.RemoveAt(index);
        }

        public void RemovePlayer(string name)
        {
            foreach (var player in party)
            {
                if (player.Name == name)
                {
                    party.Remove(player);
                }
            }
        }

        //call to data processinggggg to develope monster list 
        public void GetEligibleMonsters(string realm, bool noFly, bool noSwim, int difficulty)
        {
            double level = 0;
            foreach (Player player in party) level += player.Level;
            level /= party.Count;
            level = 0.25 * level * party.Count + difficulty;
            //populate monster list with call to fileManager
            fileManager.readData(realm, (int) Math.Ceiling(level), monsterList, noFly, noSwim);
        }

        internal List<Encounter> GenerateEncounters( int difficulty, int creatureCount)
        {
            //encounters.Add()
            //call to calculations and append to list 

            List<Encounter> encounters = new List<Encounter>();

            int level = 0;
            foreach (Player player in party) level += player.Level;
            level /= party.Count;

            double challengeLevel = 0.25 * level * party.Count + difficulty;

            ///need separate logic for when only one creature feature
            if (creatureCount == 1)
            {
                for (int i = 0; i < 6; i++) encounters.Add(Calculations.singleMonster(challengeLevel, monsterList));
            }

            else if(difficulty == 20)
            {
                encounters = Calculations.impossible( monsterList);
            }
            else
            {
                encounters.Add(Calculations.methodOne(challengeLevel, creatureCount, monsterList));
                encounters.Add(Calculations.methodOne(challengeLevel, creatureCount, monsterList));
                encounters.Add(Calculations.methodOne(challengeLevel, creatureCount, monsterList));
                encounters.Add(Calculations.methodTwo(challengeLevel, creatureCount, monsterList));
                encounters.Add(Calculations.methodTwo(challengeLevel, creatureCount, monsterList));
                encounters.Add(Calculations.methodTwo(challengeLevel, creatureCount, monsterList));
            }

            return encounters;

        }

        
    }
}
