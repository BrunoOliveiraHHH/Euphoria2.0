namespace Euphoria.Dados
{
    public class ItemTesouro
    {
        private string item;
        private string valor;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public ItemTesouro(string item, string valor)
        {
            Valor = valor;
            Item = item;
        }
    }
}
