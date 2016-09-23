using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightInfoDataAccessLibrary;
using FlightInfoEntityLibrary;
using FlightInfoExceptionLibrary;

namespace FlightInfoBusinessLibrary
{
    /// <summary>
    /// Interface implemetation
    /// </summary>
    public class FlightInfoBusiness : IFlightInfoBusiness
    {
        FlightInfoDataAccessLayer dalLayerObj = null;
       
        /// <summary>
        /// Constructor
        /// </summary>
        public FlightInfoBusiness()
        {
            dalLayerObj = new FlightInfoDataAccessLayer();
        }

        /// <summary>
        /// Gets Flight Details
        /// </summary>
        /// <returns></returns>
        public List<FlightInfoEntity> getFlightInformation()
        {
            tblFlightInformation[] flightInformation = null;
            List<FlightInfoEntity> flightDetailsList = null;
            try
            {
                flightInformation = dalLayerObj.getFlightInformation();
                if (flightInformation != null)
                {
                    flightDetailsList = new List<FlightInfoEntity>();
                    foreach (var flights in flightInformation)
                    {
                        flightDetailsList.Add(new FlightInfoEntity
                        {
                            FlightNumber = flights.FlightNumber,
                            FlightTime=flights.FlightTime,
                            Destination=flights.Destination
                            
                        });
                    }
                }

            }
            catch (FlightInfoException ex)
            {

                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return flightDetailsList;
        }

        /// <summary>
        /// Gets the detail flight information
        /// </summary>
        /// <param name="flightId"></param>
        /// <returns></returns>
        public List<FlightInfoEntity> getFlightDetails(string flightId)
        {
            tblFlightInformation[] flightInformation = null;
            List<FlightInfoEntity> flightDetailsList = null;
            try
            {
                flightInformation = dalLayerObj.getFlightDetails(flightId);
                flightDetailsList = new List<FlightInfoEntity>();
                foreach (var item in flightInformation)
                {
                    flightDetailsList.Add(new FlightInfoEntity
                    {
                        FlightNumber = item.FlightNumber,
                        FlightTime = item.FlightTime,
                        Destination=item.Destination,
                        Model = item.Model,
                        Airline = item.Airline
                    });
                }

            
            }
             catch (FlightInfoException ex)
            {

                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return flightDetailsList;
        }
    }
}
