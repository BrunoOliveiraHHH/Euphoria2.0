namespace Euphoria.Dados
{
    public class ItemModificador
    {
        private string item;
        private string mod;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        public string Mod
        {
            get { return mod; }
            set { mod = value; }
        }

        public ItemModificador(string item, string mod)
        {
            Mod = mod;
            Item = item;
        }


    }
}
