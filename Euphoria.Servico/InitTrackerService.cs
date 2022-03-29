using Euphoria.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euphoria.Servico
{
    public class InitTrackerService
    {
        private readonly InitTrackerDados _dao = new InitTrackerDados();

        public DataTable SaveTracker(DataTable dt, ItemCRUD item)
        {
            return _dao.SaveTracker(dt, item);
        }

        public DataTable UpdateTracker(DataTable dt,ItemCRUD item)
        {
            return _dao.UpdateTracker(dt, item);
        }

        public DataTable DeleteTracker(DataTable dt, ItemCRUD item)
        {
            return _dao.DeleteTracker(dt, item);
        }
    }
}
