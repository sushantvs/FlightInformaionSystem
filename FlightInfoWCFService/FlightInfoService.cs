using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using FlightInfoEntityLibrary;
using FlightInfoExceptionLibrary;
using FlightInfoBusinessLibrary;

namespace FlightInfoWCFService
{
    public class FlightInfoService : IFlightInfoService
    {
        FlightInfoBusiness businessLayerObject = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public FlightInfoService()
        {
            businessLayerObject = new FlightInfoBusiness();
        }

        /// <summary>
        /// Gets Flight Information
        /// </summary>
        /// <returns></returns>
        public List<FlightInfoEntity> getFlightInformation()
        {
            try
            {
                return businessLayerObject.getFlightInformation();
            }
            catch (FlightInfoException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException<FlightInfoServiceException>(new FlightInfoServiceException { Error = ex.Message }, "could not get Flight Information");
            }

        }

        /// <summary>
        /// Gets Flight details
        /// </summary>
        /// <param name="flightID"></param>
        /// <returns></returns>
        public List<FlightInfoEntity> getFlightDetails(string flightID)
        {
            try
            {
                return businessLayerObject.getFlightDetails(flightID);
            }
            catch (FlightInfoException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException<FlightInfoServiceException>(new FlightInfoServiceException { Error = ex.Message }, "could not get Flight details");
            }
        }
    }
}
