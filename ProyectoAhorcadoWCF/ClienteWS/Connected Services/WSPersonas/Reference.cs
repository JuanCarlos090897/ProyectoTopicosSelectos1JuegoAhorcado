﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWS.WSPersonas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseRespuesta", Namespace="http://schemas.datacontract.org/2004/07/ProyectoAhorcadoWCF")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClienteWS.WSPersonas.Persona))]
    public partial class BaseRespuesta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/ProyectoAhorcadoWCF")]
    [System.SerializableAttribute()]
    public partial class Persona : ClienteWS.WSPersonas.BaseRespuesta {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSPersonas.IWSPersonas")]
    public interface IWSPersonas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPersonas/ObtenerPersona", ReplyAction="http://tempuri.org/IWSPersonas/ObtenerPersonaResponse")]
        ClienteWS.WSPersonas.Persona ObtenerPersona(string Identificacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSPersonas/ObtenerPersona", ReplyAction="http://tempuri.org/IWSPersonas/ObtenerPersonaResponse")]
        System.Threading.Tasks.Task<ClienteWS.WSPersonas.Persona> ObtenerPersonaAsync(string Identificacion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSPersonasChannel : ClienteWS.WSPersonas.IWSPersonas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSPersonasClient : System.ServiceModel.ClientBase<ClienteWS.WSPersonas.IWSPersonas>, ClienteWS.WSPersonas.IWSPersonas {
        
        public WSPersonasClient() {
        }
        
        public WSPersonasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSPersonasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPersonasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSPersonasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClienteWS.WSPersonas.Persona ObtenerPersona(string Identificacion) {
            return base.Channel.ObtenerPersona(Identificacion);
        }
        
        public System.Threading.Tasks.Task<ClienteWS.WSPersonas.Persona> ObtenerPersonaAsync(string Identificacion) {
            return base.Channel.ObtenerPersonaAsync(Identificacion);
        }
    }
}
