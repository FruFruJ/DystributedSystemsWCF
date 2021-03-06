﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlijentAukcija.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IServiceAukcija")]
    public interface IServiceAukcija {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/prijaviKlijenta", ReplyAction="http://tempuri.org/IServiceAukcija/prijaviKlijentaResponse")]
        void prijaviKlijenta(string id, string ime, string prezime, float cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/prijaviKlijenta", ReplyAction="http://tempuri.org/IServiceAukcija/prijaviKlijentaResponse")]
        System.Threading.Tasks.Task prijaviKlijentaAsync(string id, string ime, string prezime, float cena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/vratiEksponatIDPonudjivaca", ReplyAction="http://tempuri.org/IServiceAukcija/vratiEksponatIDPonudjivacaResponse")]
        string vratiEksponatIDPonudjivaca();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/vratiEksponatIDPonudjivaca", ReplyAction="http://tempuri.org/IServiceAukcija/vratiEksponatIDPonudjivacaResponse")]
        System.Threading.Tasks.Task<string> vratiEksponatIDPonudjivacaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/odustajeKlijent", ReplyAction="http://tempuri.org/IServiceAukcija/odustajeKlijentResponse")]
        void odustajeKlijent(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/odustajeKlijent", ReplyAction="http://tempuri.org/IServiceAukcija/odustajeKlijentResponse")]
        System.Threading.Tasks.Task odustajeKlijentAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/povecajCenu", ReplyAction="http://tempuri.org/IServiceAukcija/povecajCenuResponse")]
        void povecajCenu(string id, float zaKoliko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/povecajCenu", ReplyAction="http://tempuri.org/IServiceAukcija/povecajCenuResponse")]
        System.Threading.Tasks.Task povecajCenuAsync(string id, float zaKoliko);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/postaviEksponat", ReplyAction="http://tempuri.org/IServiceAukcija/postaviEksponatResponse")]
        void postaviEksponat(string ime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAukcija/postaviEksponat", ReplyAction="http://tempuri.org/IServiceAukcija/postaviEksponatResponse")]
        System.Threading.Tasks.Task postaviEksponatAsync(string ime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAukcijaChannel : KlijentAukcija.ServiceReference2.IServiceAukcija, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAukcijaClient : System.ServiceModel.ClientBase<KlijentAukcija.ServiceReference2.IServiceAukcija>, KlijentAukcija.ServiceReference2.IServiceAukcija {
        
        public ServiceAukcijaClient() {
        }
        
        public ServiceAukcijaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAukcijaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAukcijaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAukcijaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void prijaviKlijenta(string id, string ime, string prezime, float cena) {
            base.Channel.prijaviKlijenta(id, ime, prezime, cena);
        }
        
        public System.Threading.Tasks.Task prijaviKlijentaAsync(string id, string ime, string prezime, float cena) {
            return base.Channel.prijaviKlijentaAsync(id, ime, prezime, cena);
        }
        
        public string vratiEksponatIDPonudjivaca() {
            return base.Channel.vratiEksponatIDPonudjivaca();
        }
        
        public System.Threading.Tasks.Task<string> vratiEksponatIDPonudjivacaAsync() {
            return base.Channel.vratiEksponatIDPonudjivacaAsync();
        }
        
        public void odustajeKlijent(string id) {
            base.Channel.odustajeKlijent(id);
        }
        
        public System.Threading.Tasks.Task odustajeKlijentAsync(string id) {
            return base.Channel.odustajeKlijentAsync(id);
        }
        
        public void povecajCenu(string id, float zaKoliko) {
            base.Channel.povecajCenu(id, zaKoliko);
        }
        
        public System.Threading.Tasks.Task povecajCenuAsync(string id, float zaKoliko) {
            return base.Channel.povecajCenuAsync(id, zaKoliko);
        }
        
        public void postaviEksponat(string ime) {
            base.Channel.postaviEksponat(ime);
        }
        
        public System.Threading.Tasks.Task postaviEksponatAsync(string ime) {
            return base.Channel.postaviEksponatAsync(ime);
        }
    }
}
