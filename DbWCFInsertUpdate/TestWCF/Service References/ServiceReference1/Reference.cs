﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDetails", Namespace="http://schemas.datacontract.org/2004/07/DbWCFInsertUpdate")]
    [System.SerializableAttribute()]
    public partial class UserDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FNAMEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SNAMEField;
        
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
        public string FNAME {
            get {
                return this.FNAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.FNAMEField, value) != true)) {
                    this.FNAMEField = value;
                    this.RaisePropertyChanged("FNAME");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SNAME {
            get {
                return this.SNAMEField;
            }
            set {
                if ((object.ReferenceEquals(this.SNAMEField, value) != true)) {
                    this.SNAMEField = value;
                    this.RaisePropertyChanged("SNAME");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertUserInformation", ReplyAction="http://tempuri.org/IService1/InsertUserInformationResponse")]
        string InsertUserInformation(TestWCF.ServiceReference1.UserDetails userInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertUserInformation", ReplyAction="http://tempuri.org/IService1/InsertUserInformationResponse")]
        System.Threading.Tasks.Task<string> InsertUserInformationAsync(TestWCF.ServiceReference1.UserDetails userInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUserInformation", ReplyAction="http://tempuri.org/IService1/UpdateUserInformationResponse")]
        string UpdateUserInformation(TestWCF.ServiceReference1.UserDetails userInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUserInformation", ReplyAction="http://tempuri.org/IService1/UpdateUserInformationResponse")]
        System.Threading.Tasks.Task<string> UpdateUserInformationAsync(TestWCF.ServiceReference1.UserDetails userInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TestWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TestWCF.ServiceReference1.IService1>, TestWCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string InsertUserInformation(TestWCF.ServiceReference1.UserDetails userInfo) {
            return base.Channel.InsertUserInformation(userInfo);
        }
        
        public System.Threading.Tasks.Task<string> InsertUserInformationAsync(TestWCF.ServiceReference1.UserDetails userInfo) {
            return base.Channel.InsertUserInformationAsync(userInfo);
        }
        
        public string UpdateUserInformation(TestWCF.ServiceReference1.UserDetails userInfo) {
            return base.Channel.UpdateUserInformation(userInfo);
        }
        
        public System.Threading.Tasks.Task<string> UpdateUserInformationAsync(TestWCF.ServiceReference1.UserDetails userInfo) {
            return base.Channel.UpdateUserInformationAsync(userInfo);
        }
    }
}