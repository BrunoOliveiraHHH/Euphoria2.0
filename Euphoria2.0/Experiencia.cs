using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Servico;
using System.Data;

namespace Euphoria2._0
{
    public class Experiencia
    {
        private ExpService _service = new ExpService();
        private DataTable dt = null;

        public DataTable preencheDtg(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return _service.ExpPorND(dt);
                case 2:
                    return _service.ExpPorNvl(dt);
                case 3:
                    return _service.ExpPorDif(dt);
                case 4:
                    return _service.ExpPorDia(dt);
                case 5:
                    return _service.MultideXP(dt);
                default:
                    return null;
            }
        }
    }
}
