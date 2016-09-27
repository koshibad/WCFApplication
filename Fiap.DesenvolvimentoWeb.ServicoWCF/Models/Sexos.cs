using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Fiap.DesenvolvimentoWeb.ServicoWCF.Models
{
    [DataContract(Name = "Sexos", Namespace = "FiapWCF")]
    public enum Sexos
    {
        [EnumMember(Value = "MASCULINO")]
        MASCULINO = 0,
        [EnumMember(Value = "FEMININO")]
        FEMININO = 1
    }
}