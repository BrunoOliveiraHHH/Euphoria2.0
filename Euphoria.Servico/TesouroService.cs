using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servico
{
    public class TesouroService
    {
        TesourosDados _dados = new TesourosDados();

        public DataTable montaDtGemas(DataTable dtGemas, int tipo)
        {
            return _dados.montaDtGemas(dtGemas,tipo);
        }

        public DataTable montaDtObjetos(DataTable dtObjeto, int tipo)
        {
            return _dados.montaDtObjetos(dtObjeto, tipo);
        }
    }
}
