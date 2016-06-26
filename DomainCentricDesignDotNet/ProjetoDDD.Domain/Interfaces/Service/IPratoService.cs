using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Domain.Interfaces.Service
{
    public interface IPratoService
    {
        double VerificarEAplicarPromocao(Prato prato);
        double PratoComSucoGratis(Prato prato);
    }
}
