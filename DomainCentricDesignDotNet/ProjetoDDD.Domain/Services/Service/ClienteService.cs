using ProjetoDDD.Domain.Interfaces.Service;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;

namespace ProjetoDDD.Domain.Services.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository repository;

        public ClienteService(IClienteRepository repository)
        {
            this.repository = repository;
        }

        public void AdicionaCliente(Cliente cliente)
        {
            this.repository.AdicionaCliente(cliente);
        }

        public void AtualizaCliente(Cliente cliente)
        {
            this.repository.AtualizaCliente(cliente);
        }

        public void DefinirClienteVip()
        {
            this.repository.DefinirClienteVip();
        }

        public void EnviarEmailPromocao()
        {
            
        }

        public List<Cliente> ObtemTodos()
        {
            return this.repository.ObtemTodos();
        }

        public Cliente ObterCliente(int id)
        {
            return repository.ObterCliente(id);
        }

        public void RemoveCliente(int id)
        {
            this.repository.RemoveCliente(id);
        }
    }
}