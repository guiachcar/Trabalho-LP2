using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultiBETA.Model;

namespace ConsultiBETA.Controller
{
    class FuncionarioController:Controller
    {

        public void Cadastrar(Funcionario funcionario)
        {
            Listas.funcionarios.Add(funcionario);
        }
        public void Excluir(Funcionario funcionario)
        {
            Listas.funcionarios.Remove(funcionario);
        }
        public Funcionario getFunc(int id)
        {
            return Listas.funcionarios[id];
        }
        public List<Funcionario> Listar()
        {
            return Listas.funcionarios;
        }
    }
}
