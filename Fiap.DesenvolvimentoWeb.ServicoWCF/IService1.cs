using Fiap.DesenvolvimentoWeb.ServicoWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Fiap.DesenvolvimentoWeb.ServicoWCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Funcionario> ListarFuncionarios();
    }
}
