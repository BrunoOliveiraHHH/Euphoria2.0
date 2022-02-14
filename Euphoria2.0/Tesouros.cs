using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Euphoria.Servico;

namespace Euphoria2._0
{
    public class Tesouros
    {
        private TesouroService _service = new TesouroService();
        private DataTable dt = null;

        public DataTable preencheDtgGemas(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return _service.montaDtGemas(dt,tipo);
                case 2:
                    return _service.montaDtGemas(dt, tipo);
                case 3:
                    return _service.montaDtGemas(dt, tipo);
                case 4:
                    return _service.montaDtGemas(dt, tipo);
                case 5:
                    return _service.montaDtGemas(dt, tipo);
                case 6:
                    return _service.montaDtGemas(dt, tipo);
                default:
                    return null;
            }
        }

        public DataTable preencheDtgObjetos(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return _service.montaDtObjetos(dt, tipo);
                case 2:
                    return _service.montaDtObjetos(dt, tipo);
                case 3:
                    return _service.montaDtObjetos(dt, tipo);
                case 4:
                    return _service.montaDtObjetos(dt, tipo);
                case 5:
                    return _service.montaDtObjetos(dt, tipo);
                default:
                    return null;
            }
        }
    }
}
