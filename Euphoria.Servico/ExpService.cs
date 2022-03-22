using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servico
{
    public class ExpService
    {
        private readonly ExperienciaDados _dados = new ExperienciaDados();

        public DataTable ExpPorND(DataTable dtNd)
        {
            return _dados.MontaDtNd(dtNd);
        }

        public DataTable MultideXP(DataTable dtMulti)
        {
            return _dados.MontaDtMulti(dtMulti);
        }

        public DataTable ExpPorNvl(DataTable dtNvl)
        {
            return _dados.MontaDtNvl(dtNvl);
        }

        public DataTable ExpPorDia(DataTable dtDia)
        {
            return _dados.MontaDtDia(dtDia);
        }

        public DataTable ExpPorDif(DataTable dtDif)
        {
            return _dados.MontaDtDificuldade(dtDif);
        }
    }
}
