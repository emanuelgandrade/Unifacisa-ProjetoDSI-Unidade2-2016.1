using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace projetoDDD.Application.Interfaces
{
    public interface IAppFornecedorService 
    {
        void AdicionaFornecedor(Fornecedor fornecedor);
        Fornecedor ObterFornecedor(int id);
        List<Fornecedor> ObtemTodos();
        void AtualizaFornecedor(Fornecedor forncedor);
        void RemoveForncedor(int id);
    }
}