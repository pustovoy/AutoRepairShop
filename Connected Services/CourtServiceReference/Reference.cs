﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoRepairShop.CourtServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/CourtService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CourtServiceReference.ICourt")]
    public interface ICourt {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourt/GetData", ReplyAction="http://tempuri.org/ICourt/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourt/GetData", ReplyAction="http://tempuri.org/ICourt/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourt/MakeDecision", ReplyAction="http://tempuri.org/ICourt/MakeDecisionResponse")]
        string MakeDecision();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourt/MakeDecision", ReplyAction="http://tempuri.org/ICourt/MakeDecisionResponse")]
        System.Threading.Tasks.Task<string> MakeDecisionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourt/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICourt/GetDataUsingDataContractResponse")]
        AutoRepairShop.CourtServiceReference.CompositeType GetDataUsingDataContract(AutoRepairShop.CourtServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourt/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICourt/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<AutoRepairShop.CourtServiceReference.CompositeType> GetDataUsingDataContractAsync(AutoRepairShop.CourtServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourtChannel : AutoRepairShop.CourtServiceReference.ICourt, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourtClient : System.ServiceModel.ClientBase<AutoRepairShop.CourtServiceReference.ICourt>, AutoRepairShop.CourtServiceReference.ICourt {
        
        public CourtClient() {
        }
        
        public CourtClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourtClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourtClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourtClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string MakeDecision() {
            return base.Channel.MakeDecision();
        }
        
        public System.Threading.Tasks.Task<string> MakeDecisionAsync() {
            return base.Channel.MakeDecisionAsync();
        }
        
        public AutoRepairShop.CourtServiceReference.CompositeType GetDataUsingDataContract(AutoRepairShop.CourtServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<AutoRepairShop.CourtServiceReference.CompositeType> GetDataUsingDataContractAsync(AutoRepairShop.CourtServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
