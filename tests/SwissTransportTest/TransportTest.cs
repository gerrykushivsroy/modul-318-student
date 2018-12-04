using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007", "14:05");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern", "17:00");

            Assert.IsNotNull(connections);
        }

        /// <summary>
        /// Test der prüft das stationBoard nicht Null sein darf. 
        /// </summary>
        [TestMethod]
        public void StationBoardTest()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Ballwil", "8502023", "15:03");

            Assert.IsNotNull(stationBoard);
        }
        /// <summary>
        /// Test der überprüft das resultConnections nicht NULL sein darf.
        /// </summary>
        [TestMethod]
        public void ConnectionTest()
        {
            //Arrange
            testee = new Transport();
            //Act
            var resultcConnections = testee.GetConnections("Ballwil", "Emmenbrücke, Gersag", "04:20");
            //Assert
            Assert.IsNotNull(resultcConnections);
        }
    }
}
