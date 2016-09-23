using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using FlightInfoEntityLibrary;
using FlightInfoExceptionLibrary;


namespace FlightInfoDataAccessLibrary
{
    /// <summary>
    /// Data Access Layer
    /// </summary>
    public class FlightInfoDataAccessLayer
    {
        FlightInformationDataDataContext flightInfoDataContext = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public FlightInfoDataAccessLayer()
        {
            flightInfoDataContext = new FlightInformationDataDataContext();
        }

        /// <summary>
        /// Gets Flight Details
        /// </summary>
        /// <returns></returns>
        public tblFlightInformation[] getFlightInformation()
        {
            try
            {
                var flights = from contents in flightInfoDataContext.tblFlightInformations
                              select contents;
                return flights.ToArray();
                             
            }
            catch (SqlException ex)
            {

                throw new FlightInfoException("Couldn't fetch Flight Information",ex);
            }
        }

        /// <summary>
        /// Gets detailed flight information
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        public tblFlightInformation[] getFlightDetails(string flightId)
        {
            try
            {
                var details = from detail in flightInfoDataContext.tblFlightInformations
                            where detail.FlightNumber.Equals(flightId)
                            select detail; ;
                return details.ToArray();
            }

            catch (SqlException ex)
            {
                throw new FlightInfoException("Couldn't fetch Flight Details",ex);
            }
        }

    }
}
