﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Asg4StockConsumer.localhost {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockData", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class StockData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sAdjCloseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sCloseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime sDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sHighField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sLowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sOpenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double sVolumeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sAdjClose {
            get {
                return this.sAdjCloseField;
            }
            set {
                if ((this.sAdjCloseField.Equals(value) != true)) {
                    this.sAdjCloseField = value;
                    this.RaisePropertyChanged("sAdjClose");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sClose {
            get {
                return this.sCloseField;
            }
            set {
                if ((this.sCloseField.Equals(value) != true)) {
                    this.sCloseField = value;
                    this.RaisePropertyChanged("sClose");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime sDate {
            get {
                return this.sDateField;
            }
            set {
                if ((this.sDateField.Equals(value) != true)) {
                    this.sDateField = value;
                    this.RaisePropertyChanged("sDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sHigh {
            get {
                return this.sHighField;
            }
            set {
                if ((this.sHighField.Equals(value) != true)) {
                    this.sHighField = value;
                    this.RaisePropertyChanged("sHigh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sLow {
            get {
                return this.sLowField;
            }
            set {
                if ((this.sLowField.Equals(value) != true)) {
                    this.sLowField = value;
                    this.RaisePropertyChanged("sLow");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sOpen {
            get {
                return this.sOpenField;
            }
            set {
                if ((this.sOpenField.Equals(value) != true)) {
                    this.sOpenField = value;
                    this.RaisePropertyChanged("sOpen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double sVolume {
            get {
                return this.sVolumeField;
            }
            set {
                if ((this.sVolumeField.Equals(value) != true)) {
                    this.sVolumeField = value;
                    this.RaisePropertyChanged("sVolume");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="localhost.IStockPriceService")]
    public interface IStockPriceService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockPriceService/GetDateRange", ReplyAction="http://tempuri.org/IStockPriceService/GetDateRangeResponse")]
        Asg4StockConsumer.localhost.StockData[] GetDateRange(System.DateTime start, System.DateTime stop);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockPriceService/GetDateRange", ReplyAction="http://tempuri.org/IStockPriceService/GetDateRangeResponse")]
        System.Threading.Tasks.Task<Asg4StockConsumer.localhost.StockData[]> GetDateRangeAsync(System.DateTime start, System.DateTime stop);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockPriceService/GetMovingAverage", ReplyAction="http://tempuri.org/IStockPriceService/GetMovingAverageResponse")]
        Asg4StockConsumer.localhost.StockData[] GetMovingAverage(System.DateTime start, System.DateTime stop, int days);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockPriceService/GetMovingAverage", ReplyAction="http://tempuri.org/IStockPriceService/GetMovingAverageResponse")]
        System.Threading.Tasks.Task<Asg4StockConsumer.localhost.StockData[]> GetMovingAverageAsync(System.DateTime start, System.DateTime stop, int days);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockPriceServiceChannel : Asg4StockConsumer.localhost.IStockPriceService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockPriceServiceClient : System.ServiceModel.ClientBase<Asg4StockConsumer.localhost.IStockPriceService>, Asg4StockConsumer.localhost.IStockPriceService {
        
        public StockPriceServiceClient() {
        }
        
        public StockPriceServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockPriceServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockPriceServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockPriceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Asg4StockConsumer.localhost.StockData[] GetDateRange(System.DateTime start, System.DateTime stop) {
            return base.Channel.GetDateRange(start, stop);
        }
        
        public System.Threading.Tasks.Task<Asg4StockConsumer.localhost.StockData[]> GetDateRangeAsync(System.DateTime start, System.DateTime stop) {
            return base.Channel.GetDateRangeAsync(start, stop);
        }
        
        public Asg4StockConsumer.localhost.StockData[] GetMovingAverage(System.DateTime start, System.DateTime stop, int days) {
            return base.Channel.GetMovingAverage(start, stop, days);
        }
        
        public System.Threading.Tasks.Task<Asg4StockConsumer.localhost.StockData[]> GetMovingAverageAsync(System.DateTime start, System.DateTime stop, int days) {
            return base.Channel.GetMovingAverageAsync(start, stop, days);
        }
    }
}
