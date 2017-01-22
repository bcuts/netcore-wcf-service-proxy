﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfProxy.PersonServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonDto", Namespace="http://schemas.datacontract.org/2004/07/PersonWcfService.DTO")]
    [System.SerializableAttribute()]
    public partial class PersonDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string CountryCode {
            get {
                return this.CountryCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryCodeField, value) != true)) {
                    this.CountryCodeField = value;
                    this.RaisePropertyChanged("CountryCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PersonServiceReference.IPersonService")]
    public interface IPersonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersons", ReplyAction="http://tempuri.org/IPersonService/GetPersonsResponse")]
        WcfProxy.PersonServiceReference.GetPersonsResponse GetPersons(WcfProxy.PersonServiceReference.GetPersonsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/GetPersons", ReplyAction="http://tempuri.org/IPersonService/GetPersonsResponse")]
        System.Threading.Tasks.Task<WcfProxy.PersonServiceReference.GetPersonsResponse> GetPersonsAsync(WcfProxy.PersonServiceReference.GetPersonsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SavePerson", ReplyAction="http://tempuri.org/IPersonService/SavePersonResponse")]
        WcfProxy.PersonServiceReference.SavePersonResponse SavePerson(WcfProxy.PersonServiceReference.SavePersonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/SavePerson", ReplyAction="http://tempuri.org/IPersonService/SavePersonResponse")]
        System.Threading.Tasks.Task<WcfProxy.PersonServiceReference.SavePersonResponse> SavePersonAsync(WcfProxy.PersonServiceReference.SavePersonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Clear", ReplyAction="http://tempuri.org/IPersonService/ClearResponse")]
        WcfProxy.PersonServiceReference.ClearResponse Clear(WcfProxy.PersonServiceReference.ClearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPersonService/Clear", ReplyAction="http://tempuri.org/IPersonService/ClearResponse")]
        System.Threading.Tasks.Task<WcfProxy.PersonServiceReference.ClearResponse> ClearAsync(WcfProxy.PersonServiceReference.ClearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersons", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPersonsRequest {
        
        public GetPersonsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPersonsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPersonsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WcfProxy.PersonServiceReference.PersonDto[] GetPersonsResult;
        
        public GetPersonsResponse() {
        }
        
        public GetPersonsResponse(WcfProxy.PersonServiceReference.PersonDto[] GetPersonsResult) {
            this.GetPersonsResult = GetPersonsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SavePerson", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SavePersonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WcfProxy.PersonServiceReference.PersonDto person;
        
        public SavePersonRequest() {
        }
        
        public SavePersonRequest(WcfProxy.PersonServiceReference.PersonDto person) {
            this.person = person;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SavePersonResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SavePersonResponse {
        
        public SavePersonResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Clear", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ClearRequest {
        
        public ClearRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ClearResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ClearResponse {
        
        public ClearResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPersonServiceChannel : WcfProxy.PersonServiceReference.IPersonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PersonServiceClient : System.ServiceModel.ClientBase<WcfProxy.PersonServiceReference.IPersonService>, WcfProxy.PersonServiceReference.IPersonService {
        
        public PersonServiceClient() {
        }
        
        public PersonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PersonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfProxy.PersonServiceReference.GetPersonsResponse GetPersons(WcfProxy.PersonServiceReference.GetPersonsRequest request) {
            return base.Channel.GetPersons(request);
        }
        
        public System.Threading.Tasks.Task<WcfProxy.PersonServiceReference.GetPersonsResponse> GetPersonsAsync(WcfProxy.PersonServiceReference.GetPersonsRequest request) {
            return base.Channel.GetPersonsAsync(request);
        }
        
        public WcfProxy.PersonServiceReference.SavePersonResponse SavePerson(WcfProxy.PersonServiceReference.SavePersonRequest request) {
            return base.Channel.SavePerson(request);
        }
        
        public System.Threading.Tasks.Task<WcfProxy.PersonServiceReference.SavePersonResponse> SavePersonAsync(WcfProxy.PersonServiceReference.SavePersonRequest request) {
            return base.Channel.SavePersonAsync(request);
        }
        
        public WcfProxy.PersonServiceReference.ClearResponse Clear(WcfProxy.PersonServiceReference.ClearRequest request) {
            return base.Channel.Clear(request);
        }
        
        public System.Threading.Tasks.Task<WcfProxy.PersonServiceReference.ClearResponse> ClearAsync(WcfProxy.PersonServiceReference.ClearRequest request) {
            return base.Channel.ClearAsync(request);
        }
    }
}
