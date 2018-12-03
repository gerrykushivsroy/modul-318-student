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

        //Unit Test der prüft ob 
        [TestMethod]
        public void ConnectionTest()
        {
            testee = new Transport();
            var resultcConnections = testee.GetConnections("Ballwil", "Emmenbrücke, Gersag", "18:00")

            Assert.IsNotNull(resultcConnections);
        }
    }
}
