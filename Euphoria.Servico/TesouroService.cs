using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servico
{
    public class TesouroService
    {
        private readonly TesourosDados _dados = new TesourosDados();

        public DataTable MontaDtGemas(DataTable dtGemas, int tipo)
        {
            return _dados.MontaDtGemas(dtGemas, tipo);
        }

        public DataTable MontaDtObjetos(DataTable dtObjeto, int tipo)
        {
            return _dados.MontaDtObjetos(dtObjeto, tipo);
        }
    }
}
