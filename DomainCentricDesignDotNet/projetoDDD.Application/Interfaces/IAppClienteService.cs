using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace projetoDDD.Application.Interfaces
{
    public interface IAppClienteService 
    {
        void AdicionaCliente(Cliente cliente);
        Cliente ObterCliente(int id);
        List<Cliente> ObtemTodos();
        void AtualizaCliente(Cliente cliente);
        void RemoveCliente(int id);
        void DefinirClienteVip();
    }
}
