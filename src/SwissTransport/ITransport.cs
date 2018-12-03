namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id, string datetime);
        Connections GetConnections(string fromStation, string toStattion, string time);
    }
}