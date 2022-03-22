using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;

namespace Euphoria2._0
{
    public class CalculoDeExperiencia
    {
        private readonly Multiplicadores multi = new Multiplicadores();

        public string CalculoXP(string xp, string qtdMonstro)
        {
            Int64 XP = int.Parse(xp);
            Int64 Monstro = int.Parse(qtdMonstro);
            double total;
            if (Monstro == 2)
            {
                total = XP * multi.MULTI_1_5;
            }
            else if (Monstro >= 3 && Monstro <= 6)
            {
                total = XP * multi.MULTI_2;
            }
            else if (Monstro >= 7 && Monstro <= 10)
            {
                total = XP * multi.MULTI_2_5;
            }
            else if (Monstro >= 11 && Monstro <= 14)
            {
                total = XP * multi.MULTI_3;
            }
            else if (Monstro >= 15)
            {
                total = XP * multi.MULTI_4;
            }
            else
            {
                total = XP;
            }

            return total.ToString();
        }

        public string CalculoPlayer(string xp, string qtdPlayer)
        {

            Int64 XP = int.Parse(xp);
            Int64 player = int.Parse(qtdPlayer);
            double total;

            total = XP / player;

            return total.ToString();

        }

        public string CalcularEncontro(string xp, string mediaNvl, string qntPlayer)
        {

            Int64 XP = int.Parse(xp);
            Int64 nvl = int.Parse(mediaNvl);
            Int64 qntP = int.Parse(qntPlayer);
            string dificuldade;
            Int64 facil;
            Int64 medio;
            Int64 dificil;
            Int64 mortal;

            switch (nvl)
            {
                case 1:

                    facil = qntP * 25;
                    medio = qntP * 50;
                    dificil = qntP * 75;
                    mortal = qntP * 100;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 2:

                    facil = qntP * 50;
                    medio = qntP * 100;
                    dificil = qntP * 150;
                    mortal = qntP * 200;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 3:
                    facil = qntP * 75;
                    medio = qntP * 150;
                    dificil = qntP * 225;
                    mortal = qntP * 400;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 4:
                    facil = qntP * 125;
                    medio = qntP * 250;
                    dificil = qntP * 375;
                    mortal = qntP * 500;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 5:
                    facil = qntP * 250;
                    medio = qntP * 500;
                    dificil = qntP * 750;
                    mortal = qntP * 1100;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 6:
                    facil = qntP * 300;
                    medio = qntP * 600;
                    dificil = qntP * 900;
                    mortal = qntP * 1400;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 7:
                    facil = qntP * 350;
                    medio = qntP * 750;
                    dificil = qntP * 1100;
                    mortal = qntP * 1700;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 8:
                    facil = qntP * 450;
                    medio = qntP * 900;
                    dificil = qntP * 1400;
                    mortal = qntP * 2100;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 9:
                    facil = qntP * 550;
                    medio = qntP * 1100;
                    dificil = qntP * 1600;
                    mortal = qntP * 2400;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 10:
                    facil = qntP * 600;
                    medio = qntP * 1200;
                    dificil = qntP * 1900;
                    mortal = qntP * 2800;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 11:
                    facil = qntP * 800;
                    medio = qntP * 1600;
                    dificil = qntP * 2400;
                    mortal = qntP * 3600;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 12:
                    facil = qntP * 1000;
                    medio = qntP * 2000;
                    dificil = qntP * 3000;
                    mortal = qntP * 4500;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 13:
                    facil = qntP * 1100;
                    medio = qntP * 2200;
                    dificil = qntP * 3400;
                    mortal = qntP * 5100;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 14:
                    facil = qntP * 1250;
                    medio = qntP * 2500;
                    dificil = qntP * 3800;
                    mortal = qntP * 5700;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 15:
                    facil = qntP * 1400;
                    medio = qntP * 2800;
                    dificil = qntP * 4300;
                    mortal = qntP * 6400;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 16:
                    facil = qntP * 1600;
                    medio = qntP * 3200;
                    dificil = qntP * 4800;
                    mortal = qntP * 7200;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 17:
                    facil = qntP * 2000;
                    medio = qntP * 3900;
                    dificil = qntP * 5900;
                    mortal = qntP * 8800;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 18:
                    facil = qntP * 2100;
                    medio = qntP * 4200;
                    dificil = qntP * 6300;
                    mortal = qntP * 9500;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 19:
                    facil = qntP * 2400;
                    medio = qntP * 4900;
                    dificil = qntP * 7300;
                    mortal = qntP * 10900;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;
                case 20:
                    facil = qntP * 2800;
                    medio = qntP * 5700;
                    dificil = qntP * 8500;
                    mortal = qntP * 12700;

                    if (XP <= facil)
                    {
                        dificuldade = "Fácil";
                    }
                    else if (XP > facil & XP <= medio)
                    {
                        dificuldade = "Médio";
                    }
                    else if (XP > medio & XP <= dificil)
                    {
                        dificuldade = "Difícil";
                    }
                    else if (XP > dificil & XP <= mortal)
                    {
                        dificuldade = "Mortal";
                    }
                    else
                    {
                        dificuldade = "Impossível";
                    }

                    break;

                default:
                    dificuldade = "Nível Inválido";
                    break;

            }

            return dificuldade;
        }
    }
}
