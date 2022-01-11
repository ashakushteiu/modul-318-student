using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace EasyTravel
{
    internal class Search
    {
        ITransport transport = new Transport();
        private List<string> _searchresults = new List<string>();
         public List<string> NormalSearch(string from, string to)
        {
            var Connections = transport.GetConnections(from, to);
            foreach (Connection connection in Connections.ConnectionList)
            {
                _searchresults.Add("Nach: " + connection.To.Station.Name + "\tAbfahrt: "
                    + connection.From.Departure.Value.ToString("HH:mm"));
            }
            return _searchresults;
        }
    }
}
