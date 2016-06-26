using ProjetoDDD.Domain.Interfaces.Service;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using projetoDDD.Application.Interfaces;

namespace projetoDDD.Application.Services
{
    public class AppFornecedorService : IAppFornecedorService
    {
        private IFornecedorService service;

        public AppFornecedorService(IFornecedorService service)
        {
            this.service = service;
        }

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            this.service.AdicionaFornecedor(fornecedor);
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            this.service.AtualizaFornecedor(fornecedor);
        }

        public List<Fornecedor> ObtemTodos()
        {
            return this.service.ObtemTodos();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return service.ObterFornecedor(id);
        }

        public void RemoveForncedor(int id)
        {
            this.service.RemoveFornecedor(id);
        }
    }
}