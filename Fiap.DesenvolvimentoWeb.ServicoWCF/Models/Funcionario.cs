using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Fiap.DesenvolvimentoWeb.ServicoWCF.Models
{
    public class Funcionario : Pessoa
    {
        [DataMember]
        public string Cpf { get; set; }

        [DataMember]
        public double SalarioBruto { get; set; }
    }
}