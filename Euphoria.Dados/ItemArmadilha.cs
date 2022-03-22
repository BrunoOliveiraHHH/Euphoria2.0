namespace Euphoria.Dados
{
    public class ItemArmadilha
    {
        private string item;
        private string descricao;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public ItemArmadilha(string item, string descricao)
        {
            Descricao = descricao;
            Item = item;
        }
    }
}
