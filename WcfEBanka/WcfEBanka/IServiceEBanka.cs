using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfEBanka
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceEBanka
    {
        [OperationContract]
        string vratiStanje(string brRacuna);

        [OperationContract]
        void prebaciSaDeviznog(string racun, float kolicina, float EURDIN);

        [OperationContract]
        void prebaciSaDinarskog(string racun, float kolicina, float EURDIN);
        [OperationContract]
        void kreirajRacun(string brRacuna, float dinarski, float devizni);
        [OperationContract]
        string vratiIznosDinarski(string brRacuna);
        [OperationContract]
        string vratiIznosDevizni(string brRacuna);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfEBanka.ContractType".
    [DataContract]
    public class Racun
    {
        [DataMember]
        public string BrRacuna { get; set; }

        [DataMember]
        public float Devizni { get; set; }
            
        

        [DataMember]
        public float Dinarski { get; set; }
    }
}
