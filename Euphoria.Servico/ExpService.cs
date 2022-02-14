using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servico
{
    public class ExpService
    {
        private ExperienciaDados _dados = new ExperienciaDados();

        public DataTable ExpPorND(DataTable dtNd)
        {
            return _dados.montaDtNd(dtNd);
        }

        public DataTable MultideXP(DataTable dtMulti)
        {
            return _dados.montaDtMulti(dtMulti);
        }

        public DataTable ExpPorNvl(DataTable dtNvl)
        {
            return _dados.montaDtNvl(dtNvl);
        }

        public DataTable ExpPorDia(DataTable dtDia)
        {
            return _dados.montaDtDia(dtDia);
        }

        public DataTable ExpPorDif(DataTable dtDif)
        {
            return _dados.montaDtDificuldade(dtDif);
        }
    }
}
