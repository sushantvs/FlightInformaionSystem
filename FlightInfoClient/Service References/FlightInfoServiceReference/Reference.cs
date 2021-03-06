﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightInfoClient.FlightInfoServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FlightInfoServiceException", Namespace="http://schemas.datacontract.org/2004/07/FlightInfoWCFService")]
    [System.SerializableAttribute()]
    public partial class FlightInfoServiceException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FlightInfoServiceReference.IFlightInfoService")]
    public interface IFlightInfoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightInfoService/getFlightInformation", ReplyAction="http://tempuri.org/IFlightInfoService/getFlightInformationResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FlightInfoClient.FlightInfoServiceReference.FlightInfoServiceException), Action="http://tempuri.org/IFlightInfoService/getFlightInformationFlightInfoServiceExcept" +
            "ionFault", Name="FlightInfoServiceException", Namespace="http://schemas.datacontract.org/2004/07/FlightInfoWCFService")]
        FlightInfoEntityLibrary.FlightInfoEntity[] getFlightInformation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightInfoService/getFlightInformation", ReplyAction="http://tempuri.org/IFlightInfoService/getFlightInformationResponse")]
        System.Threading.Tasks.Task<FlightInfoEntityLibrary.FlightInfoEntity[]> getFlightInformationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightInfoService/getFlightDetails", ReplyAction="http://tempuri.org/IFlightInfoService/getFlightDetailsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(FlightInfoClient.FlightInfoServiceReference.FlightInfoServiceException), Action="http://tempuri.org/IFlightInfoService/getFlightDetailsFlightInfoServiceExceptionF" +
            "ault", Name="FlightInfoServiceException", Namespace="http://schemas.datacontract.org/2004/07/FlightInfoWCFService")]
        FlightInfoEntityLibrary.FlightInfoEntity[] getFlightDetails(string flightID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFlightInfoService/getFlightDetails", ReplyAction="http://tempuri.org/IFlightInfoService/getFlightDetailsResponse")]
        System.Threading.Tasks.Task<FlightInfoEntityLibrary.FlightInfoEntity[]> getFlightDetailsAsync(string flightID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlightInfoServiceChannel : FlightInfoClient.FlightInfoServiceReference.IFlightInfoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlightInfoServiceClient : System.ServiceModel.ClientBase<FlightInfoClient.FlightInfoServiceReference.IFlightInfoService>, FlightInfoClient.FlightInfoServiceReference.IFlightInfoService {
        
        public FlightInfoServiceClient() {
        }
        
        public FlightInfoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlightInfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightInfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlightInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FlightInfoEntityLibrary.FlightInfoEntity[] getFlightInformation() {
            return base.Channel.getFlightInformation();
        }
        
        public System.Threading.Tasks.Task<FlightInfoEntityLibrary.FlightInfoEntity[]> getFlightInformationAsync() {
            return base.Channel.getFlightInformationAsync();
        }
        
        public FlightInfoEntityLibrary.FlightInfoEntity[] getFlightDetails(string flightID) {
            return base.Channel.getFlightDetails(flightID);
        }
        
        public System.Threading.Tasks.Task<FlightInfoEntityLibrary.FlightInfoEntity[]> getFlightDetailsAsync(string flightID) {
            return base.Channel.getFlightDetailsAsync(flightID);
        }
    }
}
