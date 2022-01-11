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
        private List<string> _searchResults = new List<string>();
        private List<string> _timeResult = new List<string>();
        private List<string> _travelTime = new List<string>();
        public List<string> NormalSearch(string from, string to)
        {
            if (from.Equals("") || to.Equals("") )
            {
                _searchResults.Add("Start- und Zielort muss angegeben werden.");
            }
            else
            {
                var Connections = transport.GetConnections(from, to);
                foreach (Connection connection in Connections.ConnectionList)
                {
                    _searchResults.Add("Nach: " + connection.To.Station.Name);
                }
            }
            return _searchResults;
        }
        public List<string> TimeSearch(string from, string to)
        {
            if (from != "" || to != "")
            {
                var Connections = transport.GetConnections(from, to);
                foreach (Connection connection in Connections.ConnectionList)
                {
                    string delay = "";
                    if(connection.From.Delay > 0)
                    {
                        delay = " +" + connection.From.Delay + " min";
                    }
                    _timeResult.Add("Abfahrt: " + connection.From.Departure.Value.ToString("HH:mm") + "Uhr" + delay);
                }
            }
            return _timeResult;
        }

        public List<string> TravelTime(string from, string to)
        {
            if (from != "" || to != "")
            {
                var Connections = transport.GetConnections(from, to);
                foreach (Connection connection in Connections.ConnectionList)
                {
                    _travelTime.Add("Ankunft: " + connection.To.Arrival.Value.ToString("dd.MM.yy HH:mm") + "Uhr");
                }
            }
            return _travelTime;
        }
    }
}
