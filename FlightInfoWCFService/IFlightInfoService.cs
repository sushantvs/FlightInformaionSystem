using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using FlightInfoEntityLibrary;
using FlightInfoExceptionLibrary;

namespace FlightInfoWCFService
{
    /// <summary>
    /// WCF Service Contract
    /// </summary>
    [ServiceContract]
    public interface IFlightInfoService
    {
        [OperationContract]
        [FaultContract(typeof(FlightInfoServiceException))]
        List<FlightInfoEntity> getFlightInformation();

        [OperationContract]
        [FaultContract(typeof(FlightInfoServiceException))]
        List<FlightInfoEntity> getFlightDetails(string flightID);
    }

    /// <summary>
    /// Datacontract for serivce exception details
    /// </summary>
    [DataContract]
    public class FlightInfoServiceException
    {
        public string Error { get; set; }
    }
}
