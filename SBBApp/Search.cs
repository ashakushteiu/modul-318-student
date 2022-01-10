using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;

namespace EasyTravel
{
    internal class Search
    {
        ITransport transport = new Transport();
         public void test()
        {
            transport.GetStationBoard("Stadelhofen", "8503059");
        }
    }
}
