using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.DesenvolvimentoWeb.ServicoWCF.Models
{
    public class DaoFuncionario
    {
        public List<Funcionario> Listar()
        {
            var lst = new List<Funcionario>();

            using (var ctx = new DBCADASTROEntities())
            {
                foreach (var item in ctx.TBFuncionarios)
                    lst.Add(new Funcionario()
                    {
                        Cpf = item.CPF,
                        Nome = item.NOME,
                        DataNascimento = item.DATANASC,
                        SalarioBruto = item.SALARIOBRUTO
                    });
            }

            return lst;
        }
    }
}