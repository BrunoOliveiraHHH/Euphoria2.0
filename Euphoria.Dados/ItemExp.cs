using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphoria.Dados
{
    public class ItemExp
    {
        private String Nvl;
        private String Exp;

        public String nvl
        {
            get { return Nvl; }
            set { Nvl = value; }
        }

        public String exp
        {
            get { return Exp; }
            set { Exp = value; }
        }

        public ItemExp(String Nvl, String XP)
        {
            exp = XP;
            nvl = Nvl;
        }
    }
}
