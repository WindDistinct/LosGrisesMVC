﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosGrisesWeb.ProxyPersonal {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonalDC", Namespace="http://schemas.datacontract.org/2004/07/LosGrisesServices")]
    [System.SerializableAttribute()]
    public partial class PersonalDC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_ape_matField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_ape_patField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_dirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_dniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime per_fec_ingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> per_fec_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> per_fec_regField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] per_fotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short per_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_mailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_nomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_passField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short per_stateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_telField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_user_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string per_user_regField;
        
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
        public string per_ape_mat {
            get {
                return this.per_ape_matField;
            }
            set {
                if ((object.ReferenceEquals(this.per_ape_matField, value) != true)) {
                    this.per_ape_matField = value;
                    this.RaisePropertyChanged("per_ape_mat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_ape_pat {
            get {
                return this.per_ape_patField;
            }
            set {
                if ((object.ReferenceEquals(this.per_ape_patField, value) != true)) {
                    this.per_ape_patField = value;
                    this.RaisePropertyChanged("per_ape_pat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_dir {
            get {
                return this.per_dirField;
            }
            set {
                if ((object.ReferenceEquals(this.per_dirField, value) != true)) {
                    this.per_dirField = value;
                    this.RaisePropertyChanged("per_dir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_dni {
            get {
                return this.per_dniField;
            }
            set {
                if ((object.ReferenceEquals(this.per_dniField, value) != true)) {
                    this.per_dniField = value;
                    this.RaisePropertyChanged("per_dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime per_fec_ing {
            get {
                return this.per_fec_ingField;
            }
            set {
                if ((this.per_fec_ingField.Equals(value) != true)) {
                    this.per_fec_ingField = value;
                    this.RaisePropertyChanged("per_fec_ing");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> per_fec_mod {
            get {
                return this.per_fec_modField;
            }
            set {
                if ((this.per_fec_modField.Equals(value) != true)) {
                    this.per_fec_modField = value;
                    this.RaisePropertyChanged("per_fec_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> per_fec_reg {
            get {
                return this.per_fec_regField;
            }
            set {
                if ((this.per_fec_regField.Equals(value) != true)) {
                    this.per_fec_regField = value;
                    this.RaisePropertyChanged("per_fec_reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] per_foto {
            get {
                return this.per_fotoField;
            }
            set {
                if ((object.ReferenceEquals(this.per_fotoField, value) != true)) {
                    this.per_fotoField = value;
                    this.RaisePropertyChanged("per_foto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short per_id {
            get {
                return this.per_idField;
            }
            set {
                if ((this.per_idField.Equals(value) != true)) {
                    this.per_idField = value;
                    this.RaisePropertyChanged("per_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_mail {
            get {
                return this.per_mailField;
            }
            set {
                if ((object.ReferenceEquals(this.per_mailField, value) != true)) {
                    this.per_mailField = value;
                    this.RaisePropertyChanged("per_mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_nom {
            get {
                return this.per_nomField;
            }
            set {
                if ((object.ReferenceEquals(this.per_nomField, value) != true)) {
                    this.per_nomField = value;
                    this.RaisePropertyChanged("per_nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_pass {
            get {
                return this.per_passField;
            }
            set {
                if ((object.ReferenceEquals(this.per_passField, value) != true)) {
                    this.per_passField = value;
                    this.RaisePropertyChanged("per_pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short per_state {
            get {
                return this.per_stateField;
            }
            set {
                if ((this.per_stateField.Equals(value) != true)) {
                    this.per_stateField = value;
                    this.RaisePropertyChanged("per_state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_tel {
            get {
                return this.per_telField;
            }
            set {
                if ((object.ReferenceEquals(this.per_telField, value) != true)) {
                    this.per_telField = value;
                    this.RaisePropertyChanged("per_tel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_user_mod {
            get {
                return this.per_user_modField;
            }
            set {
                if ((object.ReferenceEquals(this.per_user_modField, value) != true)) {
                    this.per_user_modField = value;
                    this.RaisePropertyChanged("per_user_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string per_user_reg {
            get {
                return this.per_user_regField;
            }
            set {
                if ((object.ReferenceEquals(this.per_user_regField, value) != true)) {
                    this.per_user_regField = value;
                    this.RaisePropertyChanged("per_user_reg");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyPersonal.IServicioPersonal")]
    public interface IServicioPersonal {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/ConsultarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/ConsultarPersonalResponse")]
        LosGrisesWeb.ProxyPersonal.PersonalDC ConsultarPersonal(short strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/ConsultarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/ConsultarPersonalResponse")]
        System.Threading.Tasks.Task<LosGrisesWeb.ProxyPersonal.PersonalDC> ConsultarPersonalAsync(short strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/ListarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/ListarPersonalResponse")]
        LosGrisesWeb.ProxyPersonal.PersonalDC[] ListarPersonal();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/ListarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/ListarPersonalResponse")]
        System.Threading.Tasks.Task<LosGrisesWeb.ProxyPersonal.PersonalDC[]> ListarPersonalAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/InsertarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/InsertarPersonalResponse")]
        bool InsertarPersonal(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/InsertarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/InsertarPersonalResponse")]
        System.Threading.Tasks.Task<bool> InsertarPersonalAsync(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/ActualizarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/ActualizarPersonalResponse")]
        bool ActualizarPersonal(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPersonal/ActualizarPersonal", ReplyAction="http://tempuri.org/IServicioPersonal/ActualizarPersonalResponse")]
        System.Threading.Tasks.Task<bool> ActualizarPersonalAsync(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPersonalChannel : LosGrisesWeb.ProxyPersonal.IServicioPersonal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPersonalClient : System.ServiceModel.ClientBase<LosGrisesWeb.ProxyPersonal.IServicioPersonal>, LosGrisesWeb.ProxyPersonal.IServicioPersonal {
        
        public ServicioPersonalClient() {
        }
        
        public ServicioPersonalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPersonalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPersonalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPersonalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LosGrisesWeb.ProxyPersonal.PersonalDC ConsultarPersonal(short strCodigo) {
            return base.Channel.ConsultarPersonal(strCodigo);
        }
        
        public System.Threading.Tasks.Task<LosGrisesWeb.ProxyPersonal.PersonalDC> ConsultarPersonalAsync(short strCodigo) {
            return base.Channel.ConsultarPersonalAsync(strCodigo);
        }
        
        public LosGrisesWeb.ProxyPersonal.PersonalDC[] ListarPersonal() {
            return base.Channel.ListarPersonal();
        }
        
        public System.Threading.Tasks.Task<LosGrisesWeb.ProxyPersonal.PersonalDC[]> ListarPersonalAsync() {
            return base.Channel.ListarPersonalAsync();
        }
        
        public bool InsertarPersonal(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal) {
            return base.Channel.InsertarPersonal(objPersonal);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarPersonalAsync(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal) {
            return base.Channel.InsertarPersonalAsync(objPersonal);
        }
        
        public bool ActualizarPersonal(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal) {
            return base.Channel.ActualizarPersonal(objPersonal);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarPersonalAsync(LosGrisesWeb.ProxyPersonal.PersonalDC objPersonal) {
            return base.Channel.ActualizarPersonalAsync(objPersonal);
        }
    }
}