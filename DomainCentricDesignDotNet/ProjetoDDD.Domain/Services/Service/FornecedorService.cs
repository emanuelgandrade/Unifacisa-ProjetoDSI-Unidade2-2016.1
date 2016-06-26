using ProjetoDDD.Domain.Interfaces.Service;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;

namespace ProjetoDDD.Domain.Services.Service
{
    public class FornecedorService : IFornecedorService
    {
        private IFornecedorRepository repository;

        public FornecedorService(IFornecedorRepository repository)
        {
            this.repository = repository;
        }

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            this.repository.AdicionaFornecedor(fornecedor);
        }

        public void AtualizaFornecedor(Fornecedor fornecedor)
        {
            this.repository.AtualizaFornecedor(fornecedor);
        }

        public List<Fornecedor> ObtemTodos()
        {
            return repository.ObtemTodos();
        }

        public Fornecedor ObterFornecedor(int id)
        {
            return repository.ObterFornecedor(id);
        }

        public void RemoveFornecedor(int id)
        {
            this.repository.RemoveFornecedor(id);
        }
    }
}