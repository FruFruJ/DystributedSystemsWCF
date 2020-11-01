using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfMobilnaTelefonija
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceOperater
    {
        [OperationContract]
        void dodajMinute(string racun,int minuti,float tarifa);

        [OperationContract]
        void dodajPoruke(string racun, int poruke, float tarifa);
        [OperationContract]
        void dodajInternet(string racun, int mb, float tarifa);
        [OperationContract]
        string vratiStanje(string racun);
        [OperationContract]
        void dodajRacun(string brRacuna, int min, int poruke, int mb);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfMobilnaTelefonija.ContractType".
    [DataContract]
    public class TelRacun
    {
   
        [DataMember]
        public string BRRacuna { get; set; }
        [DataMember]
        public int Minuti { get; set; }

        [DataMember]
        public int Poruke { get; set; }
        [DataMember]
        public int Internet { get; set; }
        [DataMember]
        public double StanjeRacuna { get; set; }
    }
}
