using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servico
{
    public class ModService
    {
        private readonly ModificadoresDados _dados = new ModificadoresDados();

        public DataTable ModPorND(DataTable dtNd)
        {
            return _dados.MontaDtNd(dtNd);
        }

        public DataTable ModPorHab(DataTable dtHab)
        {
            return _dados.MontaDtHab(dtHab);
        }

        public DataTable ModPorNvl(DataTable dtNvl)
        {
            return _dados.MontaDtNvl(dtNvl);
        }
    }
}
