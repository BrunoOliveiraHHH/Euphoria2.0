using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Servico;
using System.Data;

namespace Euphoria2._0
{
    public class Modificadores
    {
        private ModService _service = new ModService();
        private DataTable dt = null;

        public DataTable preencheDtg(int tipo)
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
