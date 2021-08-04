using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphoria.Dados
{
    public class ItemPersonagem
    {
        private String ND;
        private String FACIL;
        private String MEDIO;
        private String DIFICIL;
        private String MORTAL;

        public string nd
        {
            get { return ND; }
            set { ND = value; }
        }
        public string facil
        {
            get { return FACIL; }
            set { FACIL = value; }
        }
        public string medio
        {
            get { return MEDIO; }
            set { MEDIO = value; }

        }
        public string dificil
        {
            get { return DIFICIL; }
            set { DIFICIL = value; }

        }
        public string mortal
        {
            get { return MORTAL; }
            set { MORTAL = value; }

        }
        public ItemPersonagem(String ND, String FACIL, String MEDIO, String DIFICIL, String MORTAL)
        {
            nd = ND;
            facil = FACIL;
            medio = MEDIO;
            dificil = DIFICIL;
            mortal = MORTAL;
        }
    }
}
