using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IntecAppWS.Responses;
using IntecAppWS.Entidades;

namespace IntecAppWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceAppIntec
    {

        // TODO: Add your service operations here
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Login")]
        [OperationContract]
        LoginResponse Login(int ID, string PIN);
        /*
        [OperationContract]
        DatosGeneralesResponse DatosGenerales(string ID, string sesion);

        [OperationContract]
        AsignaturasPreseleccionadasResponse AsignaturasPreseleccionadas(string id, Programa programa, Periodo periodo, string sesion);

        [OperationContract]
        AsignaturasSeleccionadasResponse AsignaturasSeleccionadas(string id, Programa programa, Periodo periodo, string sesion);
        */
        [WebInvoke(Method = "POST",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Alertas")]
        [OperationContract]
        AlertaResponse Alertas(int ID, string sesion);


    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
