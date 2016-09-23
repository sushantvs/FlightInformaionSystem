using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace FlightInfoEntityLibrary
{
    /// <summary>
    /// Flight Information System Entity
    /// </summary>
    [DataContract]
    public class FlightInfoEntity
    {
        /// <summary>
        /// Gets or Sets flight number
        /// </summary>
        [DataMember]
        public string FlightNumber { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Flight Name
        /// </summary>
        [DataMember]
        public DateTime FlightTime { get; set; }

        /// <summary>
        /// Gets or sets Airline
        /// </summary>
        [DataMember]
        public string Airline { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember]
        public string Model { get; set; }
    }
}
