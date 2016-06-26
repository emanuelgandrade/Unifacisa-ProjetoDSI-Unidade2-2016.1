using ProjetoDDD.Domain.Interfaces.Service;
using System;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repository;

namespace ProjetoDDD.Domain.Services.Service
{
    public class PratoService : IPratoService
    {
        private IPratoRepository repository;

        public PratoService(IPratoRepository repository)
        {
            this.repository = repository;
        }

        public double PratoComSucoGratis(Prato prato)
        {
            throw new NotImplementedException();
        }

        public double VerificarEAplicarPromocao(Prato prato)
        {
            throw new NotImplementedException();
        }
    }
}
