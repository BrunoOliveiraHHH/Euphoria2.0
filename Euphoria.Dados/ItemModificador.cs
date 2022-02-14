using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphoria.Dados
{
    public class ItemModificador
    {
        private string Item;
        private string Mod;

        public string item
        {
            get { return Item; }
            set { Item = value; }
        }

        public string mod
        {
            get { return Mod; }
            set { Mod = value; }
        }

        public ItemModificador(string Item, string Mod)
        {
            mod = Mod;
            item = Item;
        }


    }
}
