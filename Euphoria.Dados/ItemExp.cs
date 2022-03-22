using System;

namespace Euphoria.Dados
{
    public class ItemExp
    {
        private String item;
        private String exp;

        public String Item
        {
            get { return item; }
            set { item = value; }
        }

        public String Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public ItemExp(String item, String XP)
        {
            Exp = XP;
            Item = item;
        }
    }
}
