using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphoria.Dados
{
    public class ItemModificador
    {
        private string Valor;
        private string Mod;

        public string valor
        {
            get { return Valor; }
            set { Valor = value; }
        }

        public string mod
        {
            get { return Mod; }
            set { Mod = value; }
        }

        public ItemModificador(string Valor, string Mod)
        {
            mod = Mod;
            valor = Valor;
        }


    }
}
