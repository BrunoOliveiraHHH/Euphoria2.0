using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphoria.Dados
{
    public class ItemTesouro
    {
       private string Item;
        private string Valor;

        public string item
        {
            get { return Item; }
            set { Item = value; }
        }

        public string valor
        {
            get { return Valor; }
            set { Valor = value; }
        }

        public ItemTesouro(string Item, string Valor)
        {
            valor = Valor;
            item = Item;
        }
    }
}
