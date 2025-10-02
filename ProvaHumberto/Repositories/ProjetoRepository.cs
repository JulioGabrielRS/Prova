using ProvaHumberto.Models;
using System.Collections.Generic;
using System.Linq;

namespace EleicaoAPI.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private static List<Projeto> projetos = new List<Projeto>();
        private static List<Visita> visitas = new List<Visita>();

        public void AddProjeto(Projeto projeto)
        {
            projetos.Add(projeto);
        }

        public IEnumerable<Projeto> GetAllProjetos()
        {
            return projetos;
        }

        public IEnumerable<Visita> GetVisitasPorNumeroProjeto(int numeroProjeto)
        {
            return visitas.Where(v => v.NroProjeto == numeroProjeto);
        }

        public void AddVisita(Visita visita)
        {
            visitas.Add(visita);
        }
    }
}