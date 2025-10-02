using ProvaHumberto.Models;

namespace ProvaHumberto.Repositories
{
    public interface IProjetoRepository
    {
        void AddProjeto(Projeto projeto);
        IEnumerable<Projeto> GetAllProjetos();
        IEnumerable<Visita> GetVisitasPorNumeroProjeto(int numeroProjeto);
        void AddVisita(Visita visita);
    }
}