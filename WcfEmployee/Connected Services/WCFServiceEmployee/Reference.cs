﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfEmployee.WCFServiceEmployee {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceEmployee.Entity")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SalaryField;
        
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
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeID {
            get {
                return this.EmployeeIDField;
            }
            set {
                if ((this.EmployeeIDField.Equals(value) != true)) {
                    this.EmployeeIDField = value;
                    this.RaisePropertyChanged("EmployeeID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFServiceEmployee.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save", ReplyAction="http://tempuri.org/IService1/SaveResponse")]
        WcfEmployee.WCFServiceEmployee.Employee Save(WcfEmployee.WCFServiceEmployee.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Save", ReplyAction="http://tempuri.org/IService1/SaveResponse")]
        System.Threading.Tasks.Task<WcfEmployee.WCFServiceEmployee.Employee> SaveAsync(WcfEmployee.WCFServiceEmployee.Employee employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetList", ReplyAction="http://tempuri.org/IService1/GetListResponse")]
        WcfEmployee.WCFServiceEmployee.Employee[] GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetList", ReplyAction="http://tempuri.org/IService1/GetListResponse")]
        System.Threading.Tasks.Task<WcfEmployee.WCFServiceEmployee.Employee[]> GetListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfEmployee.WCFServiceEmployee.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfEmployee.WCFServiceEmployee.IService1>, WcfEmployee.WCFServiceEmployee.IService1 {
        
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
        
        public WcfEmployee.WCFServiceEmployee.Employee Save(WcfEmployee.WCFServiceEmployee.Employee employee) {
            return base.Channel.Save(employee);
        }
        
        public System.Threading.Tasks.Task<WcfEmployee.WCFServiceEmployee.Employee> SaveAsync(WcfEmployee.WCFServiceEmployee.Employee employee) {
            return base.Channel.SaveAsync(employee);
        }
        
        public WcfEmployee.WCFServiceEmployee.Employee[] GetList() {
            return base.Channel.GetList();
        }
        
        public System.Threading.Tasks.Task<WcfEmployee.WCFServiceEmployee.Employee[]> GetListAsync() {
            return base.Channel.GetListAsync();
        }
    }
}