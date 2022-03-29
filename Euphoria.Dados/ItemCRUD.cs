using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euphoria.Dados
{
    public class ItemCRUD
    {
        private Int64 id;
        private string nome;
        private Int64 init;
        private Int64 hp;
        private Int64 ca;

        public Int64 Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Int64 Init
        {
            get { return init; }
            set { init = value; }
        }

        public Int64 Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public Int64 Ca
        {
            get { return ca; }
            set { ca = value; }
        }

        public ItemCRUD(Int64 id, string nome, Int64 init, Int64 hp, Int64 ca)
        {
            Nome = nome;
            Init = init;
            Hp = hp;
            Ca = ca;
            Id = id;
        }

        public ItemCRUD()
        {

        }
    }
}
