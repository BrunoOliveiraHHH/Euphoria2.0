using Euphoria.Servico;
using System.Data;

namespace Euphoria2._0
{
    public class Armadilhas
    {
        private readonly ArmadilhasService _service = new ArmadilhasService();
        private readonly DataTable dt = null;

        public DataTable PreencheDtg()
        {
            return _service.Armadilhas(dt);
        }
    }
}
