using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;

namespace projetoDDD.Application.Interfaces
{
    public interface IAppPratoService
    {
        void AdicionaPrato(Prato prato);
        Prato ObterPrato(int id);
        List<Prato> ObtemTodos();
        void AtualizaPrato(Prato prato);
        void RemovePrato(int id);
    }
}