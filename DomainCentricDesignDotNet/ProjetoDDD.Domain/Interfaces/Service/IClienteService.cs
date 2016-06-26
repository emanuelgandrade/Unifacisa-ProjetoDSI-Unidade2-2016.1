using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Service
{
    public interface IClienteService
    {
        void AdicionaCliente(Cliente cliente);
        Cliente ObterCliente(int id);
        List<Cliente> ObtemTodos();
        void AtualizaCliente(Cliente cliente);
        void RemoveCliente(int id);
        void DefinirClienteVip();
        void EnviarEmailPromocao();
    }
}