using ProjetoDDD.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infra.Data.Entity;

namespace ProjetoDDD.Infra.Data.Repositories
{
    public class PratoRepository : IPratoRepository
    {
        private BancoDeDados bd = new BancoDeDados();

        public void AdicionaPrato(Prato prato)
        {
            bd.Pratos.Add(prato);
            bd.SaveChanges();
        }

        public void AtualizaPrato(Prato prato)
        {
            bd.Pratos.Add(prato);
            bd.SaveChanges();
        }

        public List<Prato> ObtemTodos()
        {
            return bd.Pratos.ToList();
        }

        public Prato ObterPrato(int id)
        {
            return bd.Pratos.Find(id);
        }

        public void RemovePrato(int id)
        {
            bd.Pratos.Remove(bd.Pratos.Find(id));
        }
    }
}