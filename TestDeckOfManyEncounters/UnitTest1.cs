
using Microsoft.VisualStudio.CodeCoverage;
using System.Threading;

namespace DeckOfManyEncounters.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestParseNormalCase()
        {
            FileManager fileManager = new FileManager();
            List<Monster> monsterList = new List<Monster> { };
            string line = "Aarakocra,Medium,Humanoid,NG,12,13,20;50 fly,10,14,10,11,12,11,None,Perception,None,Normal,Auran,0.25,Dive Attack,Monster Manual,NA,Wizards of the Coast,Other,1,0";
            fileManager.parseData(line, "Any", 6, monsterList, false, false, "Good");

            Assert.Multiple(() =>
            {
                Assert.That(monsterList[0].Name, Is.EqualTo("Aarakocra"));
                Assert.That(monsterList[0].AC, Is.EqualTo(12));
                Assert.That(monsterList[0].HP, Is.EqualTo(13));
                Assert.That(monsterList[0].ChallengeRating, Is.EqualTo(0.25));
            });

        }

        [Test]
        public void TestReadDataNormal()
        {
            FileManager fileManager = new FileManager();
            List<Monster> monsterList = new List<Monster> { };

            fileManager.readData("Any", 6, monsterList, false, false, "Any");

            
            Assert.Multiple(() =>
            {
                Assert.That(monsterList[0].Name, Is.EqualTo("Aarakocra"));
                Assert.That(monsterList[1].AC, Is.EqualTo(13));
                Assert.That(monsterList[2].HP, Is.EqualTo(49));
                Assert.That(monsterList[2].ChallengeRating, Is.EqualTo(1.00));
            });
        }

        [Test]
        public void TestGenEncounterOneMonster()
        {
            CalculationManager calculationManager = new CalculationManager();

            calculationManager.AddPlayer("joe", "Ham", 4);
            calculationManager.AddPlayer("joe", "Ham", 3);
            calculationManager.AddPlayer("joe", "Ham", 4);


            calculationManager.GetEligibleMonsters("Any", true, true, 2, "Good");

            List<Encounter> encounterList = new List<Encounter> { };
            encounterList = calculationManager.GenerateEncounters(2, 1);

            Assert.That(encounterList[0], Is.Not.Null);
        }

        [Test]
        public void TestGenEncounterManyMonster()
        {
            CalculationManager calculationManager = new CalculationManager();

            calculationManager.AddPlayer("joe", "Ham", 4);
            calculationManager.AddPlayer("joe", "Ham", 3);
            calculationManager.AddPlayer("joe", "Ham", 4);


            calculationManager.GetEligibleMonsters("Any", true, true, 2, "Good");

            List<Encounter> encounterList = new List<Encounter> { };
            encounterList = calculationManager.GenerateEncounters(2, 4);

            for (int i = 0; i < 6; i++)
            {
                Assert.That(encounterList[i].MonsterList.Count, Is.EqualTo(4));
            }
        }

        [Test]
        public void TestGenEncounterManyMonsterOnePlayer()
        {
            CalculationManager calculationManager = new CalculationManager();

            calculationManager.AddPlayer("joe", "Ham", 1);
           


            calculationManager.GetEligibleMonsters("Any", true, true, 0, "Any");

            List<Encounter> encounterList = new List<Encounter> { };
            encounterList = calculationManager.GenerateEncounters(0, 8);

            for (int i = 0; i < 6; i++)
            {
                Assert.That(encounterList[i].MonsterList.Count, Is.EqualTo(8));
            }
        }

        [Test]
        public void TestGenEncounterManyMonsterThreeMember()
        {
            CalculationManager calculationManager = new CalculationManager();

            calculationManager.AddPlayer("joe", "Ham", 1);
            calculationManager.AddPlayer("joe", "Ham", 1);
            calculationManager.AddPlayer("joe", "Ham", 1);


            calculationManager.GetEligibleMonsters("Any", true, true, 0, "Any");

            List<Encounter> encounterList = new List<Encounter> { };
            encounterList = calculationManager.GenerateEncounters(0, 4);

            for (int i = 0; i < 6; i++)
            {
                Assert.That(encounterList[i].MonsterList.Count, Is.EqualTo(4));
            }
        }


    }

      
 }