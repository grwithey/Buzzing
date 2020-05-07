using Buzzing.Bees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BuzzingTests
{
    [TestClass]
    public class CreationTests
    {
        [TestMethod]
        public void CreateWorker()
        {
            // Act
            var workerBee = new Worker();

            // Assert
            Assert.IsTrue(workerBee.GetType() == new Worker().GetType());
        }

        [TestMethod]
        public void CreateQueen()
        {
            // Act
            var queenBee = new Queen();

            // Assert
            Assert.IsTrue(queenBee.GetType() == new Queen().GetType());
        }

        [TestMethod]
        public void CreateDrone()
        {
            // Act
            var droneBee = new Drone();

            // Assert
            Assert.IsTrue(droneBee.GetType() == new Drone().GetType());
        }

        [TestMethod]
        public void CreateQueen_HealthIs100WhenCreated()
        {
            // Act
            var queenBee = new Queen();

            // Assert
            Assert.AreEqual(100, queenBee.Health);
        }

        [TestMethod]
        public void CreateWorker_HealthIs100WhenCreated()
        {
            // Act
            var workerBee = new Worker();

            // Assert
            Assert.AreEqual(100, workerBee.Health);
        }

        [TestMethod]
        public void CreateDrone_HealthIs100WhenCreated()
        {
            // Act
            var droneBee = new Drone();

            // Assert
            Assert.AreEqual(100, droneBee.Health);
        }
    }
}
