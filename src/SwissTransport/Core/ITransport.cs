﻿namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Task<Stations> GetStationsAsync(string query);

        Stations GetStations(string query);

        Task<StationBoardRoot> GetStationBoardAsync(string station, string id, int limit);

        StationBoardRoot GetStationBoard(string station, string id, int limit);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation);

        Connections GetConnections(string fromStation, string toStation);
    }
}