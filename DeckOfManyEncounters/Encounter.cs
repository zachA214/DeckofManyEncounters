using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfManyEncounters
{
    internal class Encounter
    {
        private List<Monster> monsterList = new List<Monster> { };

        public List<Monster> MonsterList { get { return monsterList; } }

        public void AddMonster(Monster monster)
        {
            monsterList.Add(monster);
        }
    }
}
