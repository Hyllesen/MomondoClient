using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomondoClient.Model
{
    class AirportCodes
    {
        public string[] airportCodeList { get; set; }

        public AirportCodes(string[] airportCodes)
        {
            airportCodeList = airportCodes;
        }
    }
}
