﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosGrisesWeb.ProxyGenero {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GeneroDC", Namespace="http://schemas.datacontract.org/2004/07/LosGrisesServices")]
    [System.SerializableAttribute()]
    public partial class GeneroDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroNombreField;
        
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
        public string GeneroId {
            get {
                return this.GeneroIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroIdField, value) != true)) {
                    this.GeneroIdField = value;
                    this.RaisePropertyChanged("GeneroId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GeneroNombre {
            get {
                return this.GeneroNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroNombreField, value) != true)) {
                    this.GeneroNombreField = value;
                    this.RaisePropertyChanged("GeneroNombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyGenero.IServicioGenero")]
    public interface IServicioGenero {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGenero/ObtenerGeneros", ReplyAction="http://tempuri.org/IServicioGenero/ObtenerGenerosResponse")]
        LosGrisesWeb.ProxyGenero.GeneroDC[] ObtenerGeneros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGenero/ObtenerGeneros", ReplyAction="http://tempuri.org/IServicioGenero/ObtenerGenerosResponse")]
        System.Threading.Tasks.Task<LosGrisesWeb.ProxyGenero.GeneroDC[]> ObtenerGenerosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioGeneroChannel : LosGrisesWeb.ProxyGenero.IServicioGenero, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioGeneroClient : System.ServiceModel.ClientBase<LosGrisesWeb.ProxyGenero.IServicioGenero>, LosGrisesWeb.ProxyGenero.IServicioGenero {
        
        public ServicioGeneroClient() {
        }
        
        public ServicioGeneroClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioGeneroClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGeneroClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGeneroClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LosGrisesWeb.ProxyGenero.GeneroDC[] ObtenerGeneros() {
            return base.Channel.ObtenerGeneros();
        }
        
        public System.Threading.Tasks.Task<LosGrisesWeb.ProxyGenero.GeneroDC[]> ObtenerGenerosAsync() {
            return base.Channel.ObtenerGenerosAsync();
        }
    }
}
