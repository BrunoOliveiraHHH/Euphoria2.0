using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servico
{
    public class ArmadilhasService
    {
        private readonly ArmadilhasDados _dados = new ArmadilhasDados();

        public DataTable Armadilhas(DataTable dtArmad)
        {
            return _dados.MontaDtArmad(dtArmad);
        }
    }
}
