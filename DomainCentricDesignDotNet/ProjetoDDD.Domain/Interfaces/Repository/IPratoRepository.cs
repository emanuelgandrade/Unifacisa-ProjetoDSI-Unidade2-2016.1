using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repository
{
    public interface IPratoRepository
    {
        void AdicionaPrato(Prato prato);
        Prato ObterPrato(int id);
        List<Prato> ObtemTodos();
        void AtualizaPrato(Prato prato);
        void RemovePrato(int id);
    }
}