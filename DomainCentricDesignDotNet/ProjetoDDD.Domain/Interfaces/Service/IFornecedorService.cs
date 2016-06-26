using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Service
{
    public interface IFornecedorService
    {
        void AdicionaFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
        void AtualizaFornecedor(Fornecedor fornecedor);
        void RemoveFornecedor(int id);
    }
}