using Agustina_Checkpoint2;
using NUnit.Framework.Constraints;

namespace Agustina_Checkpoint2_TestUnit
{
    public class Tests
    {
            Team actual = new Team("Jessheim Idrettsklubb");
            
        [SetUp]
        public void Setup()
        {
            actual.Players = new List<Player>()
            {
                new Player("Agustina", 2),
                new Player("Alejandro", 4),
                new Player("Juan Pablo", 5),
                new Star("Iman", 10, "very active"),
            };

        }

        [Test]
        public void GetTeamsNames_ReturnList()
        {
            //Arrange
            Team expected = new Team("Jessheim");
            expected.Players = new List<Player>()
            {
                new Player("Agustina", 2),
                new Player("Alejandro", 4),
                new Player("Juan Pablo", 5),
                new Star("Iman", 10, "very active"),
            };
            //Act
            expected.PrintTeam(expected.Players);
            

            //Assert
            //Assert.That(actual.PrintTeam(actual.Players), Is.EqualTo(expected.PrintTeam(expected.Players)));
        }
        [Test]
        public void SaveToFile_CompareFile()
        {
            //Arrange
            Team expected = new Team("Jessheim Idrettsklubb");
            expected.Players = new List<Player>()
            {
                new Player("Agustina", 2),
                new Player("Alejandro", 4),
                new Player("Juan Pablo", 5),
                new Star("Iman", 10, "very active"),
            };

            //Act
            
            actual.SaveToFile("JessheimActual.txt");


            //Assert
            Assert.That(actual.ReadFile("JessheimActual.txt"), Is.EqualTo(expected.ReadFile("Jessheim.txt")));
        }
    }
}