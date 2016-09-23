using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightInfoEntityLibrary;

namespace FlightInfoBusinessLibrary
{
    /// <summary>
    /// Interface
    /// </summary>
   public interface IFlightInfoBusiness
    {
        List<FlightInfoEntity> getFlightInformation();
        List<FlightInfoEntity> getFlightDetails(string flightId);
    }
}
