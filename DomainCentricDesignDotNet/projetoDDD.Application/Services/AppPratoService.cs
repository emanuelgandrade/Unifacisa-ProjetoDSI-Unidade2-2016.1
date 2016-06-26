using ProjetoDDD.Domain.Interfaces.Service;
using ProjetoDDD.Domain.Entities;

namespace projetoDDD.Application.Services
{
    public class AppPratoService : IPratoService
    {
        private IPratoService service;
        
        public AppPratoService (IPratoService pratoService)
        {
            service = pratoService;
        }

        public double PratoComSucoGratis(Prato prato)
        {
            return service.PratoComSucoGratis(prato);
        }

        public double VerificarEAplicarPromocao(Prato prato)
        {
            return service.VerificarEAplicarPromocao(prato);
        }
    }
}
