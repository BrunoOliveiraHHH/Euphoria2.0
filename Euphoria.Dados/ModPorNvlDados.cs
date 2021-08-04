using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ModPorNvlDados
    {
        private DataTable dtNd = null;

        
    }
    public partial class Nivel
    {
        private string Nvl;
        private string Mod;

        public string nvl
        {
            get { return Nvl; }
            set { Nvl = value; }
        }
        public string mod
        {
            get { return Mod; }
            set { Mod = value; }
        }
        public Nivel(string MOD, string NVL)
        {
            nvl = NVL;
            mod = MOD;
        }
    }
}
