using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ModPorNDDados
    {
        private DataTable dtNd = null;

        
    }
    public partial class ND
    {
        private string Nd;
        private string Mod;

        public string nd
        {
            get { return Nd; }
            set { Nd = value; }
        }
        public string mod
        {
            get { return Mod; }
            set { Mod = value; }
        }
        public ND(string MOD, string ND)
        {
            nd = ND;
            mod = MOD;
        }
    }
}
