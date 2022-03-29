using Euphoria.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Euphoria.Dados;

namespace Euphoria2._0
{
    public class InitTracker
    {
        private readonly InitTrackerService _service = new InitTrackerService();

        public DataTable SaveTracker(DataTable dt, ItemCRUD item)
        {
            return _service.SaveTracker(dt, item);
        }

        public DataTable UpdateTracker(DataTable dt, ItemCRUD item)
        {
            return _service.UpdateTracker(dt, item);
        }

        public DataTable DeleteTracker(DataTable dt, ItemCRUD item)
        {
            return _service.DeleteTracker(dt, item);
        }
    }
}
