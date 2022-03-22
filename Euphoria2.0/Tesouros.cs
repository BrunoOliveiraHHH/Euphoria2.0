using Euphoria.Servico;
using System.Data;

namespace Euphoria2._0
{
    public class Tesouros
    {
        private readonly TesouroService _service = new TesouroService();
        private readonly DataTable dt = null;

        public DataTable PreencheDtgGemas(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return _service.MontaDtGemas(dt, tipo);
                case 2:
                    return _service.MontaDtGemas(dt, tipo);
                case 3:
                    return _service.MontaDtGemas(dt, tipo);
                case 4:
                    return _service.MontaDtGemas(dt, tipo);
                case 5:
                    return _service.MontaDtGemas(dt, tipo);
                case 6:
                    return _service.MontaDtGemas(dt, tipo);
                default:
                    return null;
            }
        }

        public DataTable PreencheDtgObjetos(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return _service.MontaDtObjetos(dt, tipo);
                case 2:
                    return _service.MontaDtObjetos(dt, tipo);
                case 3:
                    return _service.MontaDtObjetos(dt, tipo);
                case 4:
                    return _service.MontaDtObjetos(dt, tipo);
                case 5:
                    return _service.MontaDtObjetos(dt, tipo);
                default:
                    return null;
            }
        }
    }
}
