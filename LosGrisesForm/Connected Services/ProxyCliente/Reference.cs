﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosGrisesForm.ProxyCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteDC", Namespace="http://schemas.datacontract.org/2004/07/LosGrisesServices")]
    [System.SerializableAttribute()]
    public partial class ClienteDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_apeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_dirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_dniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> cli_fec_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_fec_nac_serializadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> cli_fec_regField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] cli_fotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short cli_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_mailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_nomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_sexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short cli_stateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_telField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_user_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cli_user_regField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ubg_idField;
        
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
        public string Distrito {
            get {
                return this.DistritoField;
            }
            set {
                if ((object.ReferenceEquals(this.DistritoField, value) != true)) {
                    this.DistritoField = value;
                    this.RaisePropertyChanged("Distrito");
                }
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
        public string Provincia {
            get {
                return this.ProvinciaField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinciaField, value) != true)) {
                    this.ProvinciaField = value;
                    this.RaisePropertyChanged("Provincia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Region {
            get {
                return this.RegionField;
            }
            set {
                if ((object.ReferenceEquals(this.RegionField, value) != true)) {
                    this.RegionField = value;
                    this.RaisePropertyChanged("Region");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_ape {
            get {
                return this.cli_apeField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_apeField, value) != true)) {
                    this.cli_apeField = value;
                    this.RaisePropertyChanged("cli_ape");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_dir {
            get {
                return this.cli_dirField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_dirField, value) != true)) {
                    this.cli_dirField = value;
                    this.RaisePropertyChanged("cli_dir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_dni {
            get {
                return this.cli_dniField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_dniField, value) != true)) {
                    this.cli_dniField = value;
                    this.RaisePropertyChanged("cli_dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> cli_fec_mod {
            get {
                return this.cli_fec_modField;
            }
            set {
                if ((this.cli_fec_modField.Equals(value) != true)) {
                    this.cli_fec_modField = value;
                    this.RaisePropertyChanged("cli_fec_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_fec_nac_serializado {
            get {
                return this.cli_fec_nac_serializadoField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_fec_nac_serializadoField, value) != true)) {
                    this.cli_fec_nac_serializadoField = value;
                    this.RaisePropertyChanged("cli_fec_nac_serializado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> cli_fec_reg {
            get {
                return this.cli_fec_regField;
            }
            set {
                if ((this.cli_fec_regField.Equals(value) != true)) {
                    this.cli_fec_regField = value;
                    this.RaisePropertyChanged("cli_fec_reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] cli_foto {
            get {
                return this.cli_fotoField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_fotoField, value) != true)) {
                    this.cli_fotoField = value;
                    this.RaisePropertyChanged("cli_foto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short cli_id {
            get {
                return this.cli_idField;
            }
            set {
                if ((this.cli_idField.Equals(value) != true)) {
                    this.cli_idField = value;
                    this.RaisePropertyChanged("cli_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_mail {
            get {
                return this.cli_mailField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_mailField, value) != true)) {
                    this.cli_mailField = value;
                    this.RaisePropertyChanged("cli_mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_nom {
            get {
                return this.cli_nomField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_nomField, value) != true)) {
                    this.cli_nomField = value;
                    this.RaisePropertyChanged("cli_nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_sex {
            get {
                return this.cli_sexField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_sexField, value) != true)) {
                    this.cli_sexField = value;
                    this.RaisePropertyChanged("cli_sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short cli_state {
            get {
                return this.cli_stateField;
            }
            set {
                if ((this.cli_stateField.Equals(value) != true)) {
                    this.cli_stateField = value;
                    this.RaisePropertyChanged("cli_state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_tel {
            get {
                return this.cli_telField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_telField, value) != true)) {
                    this.cli_telField = value;
                    this.RaisePropertyChanged("cli_tel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_user_mod {
            get {
                return this.cli_user_modField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_user_modField, value) != true)) {
                    this.cli_user_modField = value;
                    this.RaisePropertyChanged("cli_user_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cli_user_reg {
            get {
                return this.cli_user_regField;
            }
            set {
                if ((object.ReferenceEquals(this.cli_user_regField, value) != true)) {
                    this.cli_user_regField = value;
                    this.RaisePropertyChanged("cli_user_reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ubg_id {
            get {
                return this.ubg_idField;
            }
            set {
                if ((object.ReferenceEquals(this.ubg_idField, value) != true)) {
                    this.ubg_idField = value;
                    this.RaisePropertyChanged("ubg_id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyCliente.IServicioCliente")]
    public interface IServicioCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ConsultarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ConsultarClienteResponse")]
        LosGrisesForm.ProxyCliente.ClienteDC ConsultarCliente(short strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ConsultarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ConsultarClienteResponse")]
        System.Threading.Tasks.Task<LosGrisesForm.ProxyCliente.ClienteDC> ConsultarClienteAsync(short strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ListarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ListarClienteResponse")]
        LosGrisesForm.ProxyCliente.ClienteDC[] ListarCliente();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ListarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ListarClienteResponse")]
        System.Threading.Tasks.Task<LosGrisesForm.ProxyCliente.ClienteDC[]> ListarClienteAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/InsertarCliente", ReplyAction="http://tempuri.org/IServicioCliente/InsertarClienteResponse")]
        bool InsertarCliente(LosGrisesForm.ProxyCliente.ClienteDC objCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/InsertarCliente", ReplyAction="http://tempuri.org/IServicioCliente/InsertarClienteResponse")]
        System.Threading.Tasks.Task<bool> InsertarClienteAsync(LosGrisesForm.ProxyCliente.ClienteDC objCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ActualizarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ActualizarClienteResponse")]
        bool ActualizarCliente(LosGrisesForm.ProxyCliente.ClienteDC objCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/ActualizarCliente", ReplyAction="http://tempuri.org/IServicioCliente/ActualizarClienteResponse")]
        System.Threading.Tasks.Task<bool> ActualizarClienteAsync(LosGrisesForm.ProxyCliente.ClienteDC objCliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioClienteChannel : LosGrisesForm.ProxyCliente.IServicioCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioClienteClient : System.ServiceModel.ClientBase<LosGrisesForm.ProxyCliente.IServicioCliente>, LosGrisesForm.ProxyCliente.IServicioCliente {
        
        public ServicioClienteClient() {
        }
        
        public ServicioClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LosGrisesForm.ProxyCliente.ClienteDC ConsultarCliente(short strCodigo) {
            return base.Channel.ConsultarCliente(strCodigo);
        }
        
        public System.Threading.Tasks.Task<LosGrisesForm.ProxyCliente.ClienteDC> ConsultarClienteAsync(short strCodigo) {
            return base.Channel.ConsultarClienteAsync(strCodigo);
        }
        
        public LosGrisesForm.ProxyCliente.ClienteDC[] ListarCliente() {
            return base.Channel.ListarCliente();
        }
        
        public System.Threading.Tasks.Task<LosGrisesForm.ProxyCliente.ClienteDC[]> ListarClienteAsync() {
            return base.Channel.ListarClienteAsync();
        }
        
        public bool InsertarCliente(LosGrisesForm.ProxyCliente.ClienteDC objCliente) {
            return base.Channel.InsertarCliente(objCliente);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarClienteAsync(LosGrisesForm.ProxyCliente.ClienteDC objCliente) {
            return base.Channel.InsertarClienteAsync(objCliente);
        }
        
        public bool ActualizarCliente(LosGrisesForm.ProxyCliente.ClienteDC objCliente) {
            return base.Channel.ActualizarCliente(objCliente);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarClienteAsync(LosGrisesForm.ProxyCliente.ClienteDC objCliente) {
            return base.Channel.ActualizarClienteAsync(objCliente);
        }
    }
}
