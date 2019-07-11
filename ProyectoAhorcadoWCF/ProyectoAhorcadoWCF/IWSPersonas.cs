using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProyectoAhorcadoWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.

    //[ServiceContract] // Esto lo que hace es que cada persona que se mete a mi Web Service puede utilizar los siquientes metodos 

    //[DataContract]// esto lo que hace es avisarle al WS que va a manejar el WS 

    //[DataMember]// esto se lo debemos de poner a los metodos que queremos exponer 



    [ServiceContract]
    public interface IWSPersonas
    {
        [OperationContract]
        Persona ObtenerPersona(String Identificacion);
    }
    [DataContract]
    public class Persona : BaseRespuesta //lo que hago aqui es heredar de una clase de respuestas que la defino abajo
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Edad { get; set; }
    }
    [DataContract]
    public class BaseRespuesta
    {
        [DataMember]
        public string MensajeRespueta { get; set; }
        [DataMember]
        public string Error { get; set; }
    }
}
