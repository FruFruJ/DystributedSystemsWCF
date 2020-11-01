using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFjoks
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICisterna
    {
        [OperationContract]
        void dodaj(Materijal m);

        [OperationContract]
        void ispusti(float v);

        [OperationContract]
        Materijal stanje();

        [OperationContract]
        List<string> svePromene();
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCFjoks.ContractType".
    [DataContract]
    public class Materijal
    {
       

        [DataMember]
        public string Naziv { get; set; }

        [DataMember]
        public float V { get;set;}
        [DataMember]
        public float Ro { get; set; }
    }
}
