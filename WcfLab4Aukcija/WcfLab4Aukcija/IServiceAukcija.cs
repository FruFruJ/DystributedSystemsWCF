using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfLab4Aukcija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceAukcija
    {
        [OperationContract]
        void prijaviKlijenta(string id,string ime,string prezime,float cena);

        [OperationContract]
        string vratiEksponatIDPonudjivaca();

        [OperationContract]
        void odustajeKlijent(string id);

        [OperationContract]
        void povecajCenu(string id, float zaKoliko);
        [OperationContract]
        void postaviEksponat(string ime);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfLab4Aukcija.ContractType".
    [DataContract]
    public class Klijent
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Ime { get; set; }

        [DataMember]
        public string Prezime { get; set; }
        [DataMember]
        public float Cena { get; set; }
    }
}
