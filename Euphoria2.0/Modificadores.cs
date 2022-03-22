using Euphoria.Servico;
using System.Data;

namespace Euphoria2._0
{
    public class Modificadores
    {
        private readonly ModService _service = new ModService();
        private readonly DataTable dt = null;

        public DataTable PreencheDtg(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return _service.ModPorND(dt);
                case 2:
                    return _service.ModPorNvl(dt);
                case 3:
                    return _service.ModPorHab(dt);
                default:
                    return null;
            }
        }
    }
}
