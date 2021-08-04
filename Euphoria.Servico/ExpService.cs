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
    }
}
