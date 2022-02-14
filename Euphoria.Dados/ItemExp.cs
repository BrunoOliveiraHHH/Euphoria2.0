using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphoria.Dados
{
    public class ItemExp
    {
        private String Item;
        private String Exp;

        public String item
        {
            get { return Item; }
            set { Item = value; }
        }

        public String exp
        {
            get { return Exp; }
            set { Exp = value; }
        }

        public ItemExp(String Item, String XP)
        {
            exp = XP;
            item = Item;
        }
    }
}
