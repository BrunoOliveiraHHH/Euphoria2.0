using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servico
{
    public class ModService
    {
        private ModificadoresDados _dados = new ModificadoresDados();

        public DataTable ModPorND(DataTable dtNd)
        {
            return _dados.montaDtNd(dtNd);
        }

        public DataTable ModPorHab(DataTable dtHab)
        {
            return _dados.montaDtHab(dtHab);
        }

        public DataTable ModPorNvl(DataTable dtNvl)
        {
            return _dados.montaDtNvl(dtNvl);
        }
    }
}
