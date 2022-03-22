using System;

namespace Euphoria.Dados
{
    public class ItemPersonagem
    {
        private String ND;
        private String FACIL;
        private String MEDIO;
        private String DIFICIL;
        private String MORTAL;

        public string Nd
        {
            get { return ND; }
            set { ND = value; }
        }
        public string Facil
        {
            get { return FACIL; }
            set { FACIL = value; }
        }
        public string Medio
        {
            get { return MEDIO; }
            set { MEDIO = value; }

        }
        public string Dificil
        {
            get { return DIFICIL; }
            set { DIFICIL = value; }

        }
        public string Mortal
        {
            get { return MORTAL; }
            set { MORTAL = value; }

        }
        public ItemPersonagem(String ND, String FACIL, String MEDIO, String DIFICIL, String MORTAL)
        {
            Nd = ND;
            Facil = FACIL;
            Medio = MEDIO;
            Dificil = DIFICIL;
            Mortal = MORTAL;
        }
    }
}
