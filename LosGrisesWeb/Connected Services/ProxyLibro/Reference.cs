﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosGrisesWeb.ProxyLibro {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LibroDC", Namespace="http://schemas.datacontract.org/2004/07/LosGrisesServices")]
    [System.SerializableAttribute()]
    public partial class LibroDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aut_apeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short aut_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string aut_nomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short edi_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string edi_nomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gen_descField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short gen_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short lib_disp_stockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lib_ediField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> lib_fec_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short lib_fec_pubField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> lib_fec_regField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short lib_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lib_nomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short lib_stateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lib_user_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lib_user_regField;
        
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
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string aut_ape {
            get {
                return this.aut_apeField;
            }
            set {
                if ((object.ReferenceEquals(this.aut_apeField, value) != true)) {
                    this.aut_apeField = value;
                    this.RaisePropertyChanged("aut_ape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short aut_id {
            get {
                return this.aut_idField;
            }
            set {
                if ((this.aut_idField.Equals(value) != true)) {
                    this.aut_idField = value;
                    this.RaisePropertyChanged("aut_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string aut_nom {
            get {
                return this.aut_nomField;
            }
            set {
                if ((object.ReferenceEquals(this.aut_nomField, value) != true)) {
                    this.aut_nomField = value;
                    this.RaisePropertyChanged("aut_nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short edi_id {
            get {
                return this.edi_idField;
            }
            set {
                if ((this.edi_idField.Equals(value) != true)) {
                    this.edi_idField = value;
                    this.RaisePropertyChanged("edi_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string edi_nom {
            get {
                return this.edi_nomField;
            }
            set {
                if ((object.ReferenceEquals(this.edi_nomField, value) != true)) {
                    this.edi_nomField = value;
                    this.RaisePropertyChanged("edi_nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string gen_desc {
            get {
                return this.gen_descField;
            }
            set {
                if ((object.ReferenceEquals(this.gen_descField, value) != true)) {
                    this.gen_descField = value;
                    this.RaisePropertyChanged("gen_desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short gen_id {
            get {
                return this.gen_idField;
            }
            set {
                if ((this.gen_idField.Equals(value) != true)) {
                    this.gen_idField = value;
                    this.RaisePropertyChanged("gen_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short lib_disp_stock {
            get {
                return this.lib_disp_stockField;
            }
            set {
                if ((this.lib_disp_stockField.Equals(value) != true)) {
                    this.lib_disp_stockField = value;
                    this.RaisePropertyChanged("lib_disp_stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lib_edi {
            get {
                return this.lib_ediField;
            }
            set {
                if ((object.ReferenceEquals(this.lib_ediField, value) != true)) {
                    this.lib_ediField = value;
                    this.RaisePropertyChanged("lib_edi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> lib_fec_mod {
            get {
                return this.lib_fec_modField;
            }
            set {
                if ((this.lib_fec_modField.Equals(value) != true)) {
                    this.lib_fec_modField = value;
                    this.RaisePropertyChanged("lib_fec_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short lib_fec_pub {
            get {
                return this.lib_fec_pubField;
            }
            set {
                if ((this.lib_fec_pubField.Equals(value) != true)) {
                    this.lib_fec_pubField = value;
                    this.RaisePropertyChanged("lib_fec_pub");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> lib_fec_reg {
            get {
                return this.lib_fec_regField;
            }
            set {
                if ((this.lib_fec_regField.Equals(value) != true)) {
                    this.lib_fec_regField = value;
                    this.RaisePropertyChanged("lib_fec_reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short lib_id {
            get {
                return this.lib_idField;
            }
            set {
                if ((this.lib_idField.Equals(value) != true)) {
                    this.lib_idField = value;
                    this.RaisePropertyChanged("lib_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lib_nom {
            get {
                return this.lib_nomField;
            }
            set {
                if ((object.ReferenceEquals(this.lib_nomField, value) != true)) {
                    this.lib_nomField = value;
                    this.RaisePropertyChanged("lib_nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short lib_state {
            get {
                return this.lib_stateField;
            }
            set {
                if ((this.lib_stateField.Equals(value) != true)) {
                    this.lib_stateField = value;
                    this.RaisePropertyChanged("lib_state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lib_user_mod {
            get {
                return this.lib_user_modField;
            }
            set {
                if ((object.ReferenceEquals(this.lib_user_modField, value) != true)) {
                    this.lib_user_modField = value;
                    this.RaisePropertyChanged("lib_user_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lib_user_reg {
            get {
                return this.lib_user_regField;
            }
            set {
                if ((object.ReferenceEquals(this.lib_user_regField, value) != true)) {
                    this.lib_user_regField = value;
                    this.RaisePropertyChanged("lib_user_reg");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyLibro.IServicioLibro")]
    public interface IServicioLibro {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/ConsultarLibro", ReplyAction="http://tempuri.org/IServicioLibro/ConsultarLibroResponse")]
        LosGrisesWeb.ProxyLibro.LibroDC ConsultarLibro(short strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/ConsultarLibro", ReplyAction="http://tempuri.org/IServicioLibro/ConsultarLibroResponse")]
        System.Threading.Tasks.Task<LosGrisesWeb.ProxyLibro.LibroDC> ConsultarLibroAsync(short strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/ListarLibro", ReplyAction="http://tempuri.org/IServicioLibro/ListarLibroResponse")]
        LosGrisesWeb.ProxyLibro.LibroDC[] ListarLibro();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/ListarLibro", ReplyAction="http://tempuri.org/IServicioLibro/ListarLibroResponse")]
        System.Threading.Tasks.Task<LosGrisesWeb.ProxyLibro.LibroDC[]> ListarLibroAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/InsertarLibro", ReplyAction="http://tempuri.org/IServicioLibro/InsertarLibroResponse")]
        bool InsertarLibro(LosGrisesWeb.ProxyLibro.LibroDC objLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/InsertarLibro", ReplyAction="http://tempuri.org/IServicioLibro/InsertarLibroResponse")]
        System.Threading.Tasks.Task<bool> InsertarLibroAsync(LosGrisesWeb.ProxyLibro.LibroDC objLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/ActualizarLibro", ReplyAction="http://tempuri.org/IServicioLibro/ActualizarLibroResponse")]
        bool ActualizarLibro(LosGrisesWeb.ProxyLibro.LibroDC objLibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioLibro/ActualizarLibro", ReplyAction="http://tempuri.org/IServicioLibro/ActualizarLibroResponse")]
        System.Threading.Tasks.Task<bool> ActualizarLibroAsync(LosGrisesWeb.ProxyLibro.LibroDC objLibro);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioLibroChannel : LosGrisesWeb.ProxyLibro.IServicioLibro, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioLibroClient : System.ServiceModel.ClientBase<LosGrisesWeb.ProxyLibro.IServicioLibro>, LosGrisesWeb.ProxyLibro.IServicioLibro {
        
        public ServicioLibroClient() {
        }
        
        public ServicioLibroClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioLibroClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioLibroClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioLibroClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LosGrisesWeb.ProxyLibro.LibroDC ConsultarLibro(short strCodigo) {
            return base.Channel.ConsultarLibro(strCodigo);
        }
        
        public System.Threading.Tasks.Task<LosGrisesWeb.ProxyLibro.LibroDC> ConsultarLibroAsync(short strCodigo) {
            return base.Channel.ConsultarLibroAsync(strCodigo);
        }
        
        public LosGrisesWeb.ProxyLibro.LibroDC[] ListarLibro() {
            return base.Channel.ListarLibro();
        }
        
        public System.Threading.Tasks.Task<LosGrisesWeb.ProxyLibro.LibroDC[]> ListarLibroAsync() {
            return base.Channel.ListarLibroAsync();
        }
        
        public bool InsertarLibro(LosGrisesWeb.ProxyLibro.LibroDC objLibro) {
            return base.Channel.InsertarLibro(objLibro);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarLibroAsync(LosGrisesWeb.ProxyLibro.LibroDC objLibro) {
            return base.Channel.InsertarLibroAsync(objLibro);
        }
        
        public bool ActualizarLibro(LosGrisesWeb.ProxyLibro.LibroDC objLibro) {
            return base.Channel.ActualizarLibro(objLibro);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarLibroAsync(LosGrisesWeb.ProxyLibro.LibroDC objLibro) {
            return base.Channel.ActualizarLibroAsync(objLibro);
        }
    }
}