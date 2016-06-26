using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repository
{
    public interface IFornecedorRepository
    {
        void AdicionaFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
        void AtualizaFornecedor(Fornecedor fornecedor);
        void RemoveFornecedor(int id);
    }
}