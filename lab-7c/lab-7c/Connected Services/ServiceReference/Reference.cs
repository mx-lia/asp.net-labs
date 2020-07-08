﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab_7c.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Record", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceConsole")]
    [System.SerializableAttribute()]
    public partial class Record : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long RecordIDField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long RecordID {
            get {
                return this.RecordIDField;
            }
            set {
                if ((this.RecordIDField.Equals(value) != true)) {
                    this.RecordIDField = value;
                    this.RaisePropertyChanged("RecordID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        lab_7c.ServiceReference.Record[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        System.Threading.Tasks.Task<lab_7c.ServiceReference.Record[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByID", ReplyAction="http://tempuri.org/IService/GetByIDResponse")]
        lab_7c.ServiceReference.Record GetByID(long recordID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByID", ReplyAction="http://tempuri.org/IService/GetByIDResponse")]
        System.Threading.Tasks.Task<lab_7c.ServiceReference.Record> GetByIDAsync(long recordID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        lab_7c.ServiceReference.Record Add(string name, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        System.Threading.Tasks.Task<lab_7c.ServiceReference.Record> AddAsync(string name, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        lab_7c.ServiceReference.Record Update(long recordID, string name, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        System.Threading.Tasks.Task<lab_7c.ServiceReference.Record> UpdateAsync(long recordID, string name, string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        long Delete(long recordID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        System.Threading.Tasks.Task<long> DeleteAsync(long recordID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : lab_7c.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<lab_7c.ServiceReference.IService>, lab_7c.ServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public lab_7c.ServiceReference.Record[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<lab_7c.ServiceReference.Record[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public lab_7c.ServiceReference.Record GetByID(long recordID) {
            return base.Channel.GetByID(recordID);
        }
        
        public System.Threading.Tasks.Task<lab_7c.ServiceReference.Record> GetByIDAsync(long recordID) {
            return base.Channel.GetByIDAsync(recordID);
        }
        
        public lab_7c.ServiceReference.Record Add(string name, string phone) {
            return base.Channel.Add(name, phone);
        }
        
        public System.Threading.Tasks.Task<lab_7c.ServiceReference.Record> AddAsync(string name, string phone) {
            return base.Channel.AddAsync(name, phone);
        }
        
        public lab_7c.ServiceReference.Record Update(long recordID, string name, string phone) {
            return base.Channel.Update(recordID, name, phone);
        }
        
        public System.Threading.Tasks.Task<lab_7c.ServiceReference.Record> UpdateAsync(long recordID, string name, string phone) {
            return base.Channel.UpdateAsync(recordID, name, phone);
        }
        
        public long Delete(long recordID) {
            return base.Channel.Delete(recordID);
        }
        
        public System.Threading.Tasks.Task<long> DeleteAsync(long recordID) {
            return base.Channel.DeleteAsync(recordID);
        }
    }
}
