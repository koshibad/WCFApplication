using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fiap.DesenvolvimentoWeb.ServicoWCF.Models
{
    [DataContract(Name = "Person", Namespace = "FiapWCF")]
    [XmlInclude(typeof(Sexos))]
    [KnownType(typeof(Sexos))]
    public class Pessoa
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public DateTime DataNascimento { get; set; }

        [DataMember]
        public Sexos Sexo { get; set; }

    }
}
