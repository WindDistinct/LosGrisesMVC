﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosGrisesWeb.ProxyEditorial {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EditorialDC", Namespace="http://schemas.datacontract.org/2004/07/LosGrisesServices")]
    [System.SerializableAttribute()]
    public partial class EditorialDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short EditorialIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EditorialNombreField;
        
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
        public short EditorialId {
            get {
                return this.EditorialIdField;
            }
            set {
                if ((this.EditorialIdField.Equals(value) != true)) {
                    this.EditorialIdField = value;
                    this.RaisePropertyChanged("EditorialId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EditorialNombre {
            get {
                return this.EditorialNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.EditorialNombreField, value) != true)) {
                    this.EditorialNombreField = value;
                    this.RaisePropertyChanged("EditorialNombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyEditorial.IServicioEditorial")]
    public interface IServicioEditorial {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEditorial/ObtenerEditoriales", ReplyAction="http://tempuri.org/IServicioEditorial/ObtenerEditorialesResponse")]
        LosGrisesWeb.ProxyEditorial.EditorialDC[] ObtenerEditoriales();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioEditorial/ObtenerEditoriales", ReplyAction="http://tempuri.org/IServicioEditorial/ObtenerEditorialesResponse")]
        System.Threading.Tasks.Task<LosGrisesWeb.ProxyEditorial.EditorialDC[]> ObtenerEditorialesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioEditorialChannel : LosGrisesWeb.ProxyEditorial.IServicioEditorial, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioEditorialClient : System.ServiceModel.ClientBase<LosGrisesWeb.ProxyEditorial.IServicioEditorial>, LosGrisesWeb.ProxyEditorial.IServicioEditorial {
        
        public ServicioEditorialClient() {
        }
        
        public ServicioEditorialClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioEditorialClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEditorialClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioEditorialClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LosGrisesWeb.ProxyEditorial.EditorialDC[] ObtenerEditoriales() {
            return base.Channel.ObtenerEditoriales();
        }
        
        public System.Threading.Tasks.Task<LosGrisesWeb.ProxyEditorial.EditorialDC[]> ObtenerEditorialesAsync() {
            return base.Channel.ObtenerEditorialesAsync();
        }
    }
}
