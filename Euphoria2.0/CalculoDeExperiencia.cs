using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;

namespace Euphoria2._0
{
    public class CalculoDeExperiencia
    {
        private Multiplicadores multi = new Multiplicadores();

        public string CalculoXP(string xp, string qtdMonstro)
        {
            try
            {
                Int64 XP = int.Parse(xp);
                Int64 Monstro = int.Parse(qtdMonstro);
                double total = 0;
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
            catch
            {
                return "Preenchimento invalido, preencher apenas com numeros.";
            }
        }

        public string CalculoPlayer(string xp, string qtdPlayer)
        {
            try
            {
                Int64 XP = int.Parse(xp);
                Int64 player = int.Parse(qtdPlayer);
                double total = 0;

                total = XP / player;

                return total.ToString();
            }
            catch
            {
                return "Preenchimento invalido, preencher apenas com numeros.";
            }
        }

        public string CalcularEncontro(string xp, string mediaNvl)
        {
            try
            {
                Int64 XP = int.Parse(xp);
                Int64 nvl = int.Parse(mediaNvl);
                string dificuldade = "";

                switch (nvl)
                {
                    case 1:
                        if (XP <= 25)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 25 & XP <= 50)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 50 & XP <= 75)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 75 & XP <= 100)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 2:
                        if (XP <= 50)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 50 & XP <= 100)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 100 & XP <= 150)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 150 & XP <= 200)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 3:
                        if (XP <= 75)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 75 & XP <= 150)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 150 & XP <= 225)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 225 & XP <= 400)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 4:
                        if (XP <= 125)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 125 & XP <= 250)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 250 & XP <= 375)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 375 & XP <= 500)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 5:
                        if (XP <= 250)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 250 & XP <= 500)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 500 & XP <= 750)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 750 & XP <= 1100)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 6:
                        if (XP <= 300)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 300 & XP <= 600)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 600 & XP <= 900)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 900 & XP <= 1400)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 7:
                        if (XP <= 350)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 350 & XP <= 750)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 750 & XP <= 1100)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 1100 & XP <= 1700)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 8:
                        if (XP <= 450)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 450 & XP <= 900)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 900 & XP <= 1400)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 1400 & XP <= 2100)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 9:
                        if (XP <= 550)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 550 & XP <= 1100)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 1100 & XP <= 1600)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 1600 & XP <= 2400)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 10:
                        if (XP <= 600)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 600 & XP <= 1200)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 1200 & XP <= 1900)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 1900 & XP <= 2800)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 11:
                        if (XP <= 800)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 800 & XP <= 1600)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 1600 & XP <= 2400)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 2400 & XP <= 3600)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 12:
                        if (XP <= 1000)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 1000 & XP <= 2000)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 2000 & XP <= 3000)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 3000 & XP <= 4500)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 13:
                        if (XP <= 1100)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 1100 & XP <= 2200)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 2200 & XP <= 3400)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 3400 & XP <= 5100)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 14:
                        if (XP <= 1250)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 1250 & XP <= 2500)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 2500 & XP <= 3800)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 3800 & XP <= 5700)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 15:
                        if (XP <= 1400)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 1400 & XP <= 2800)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 2800 & XP <= 4300)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 4300 & XP <= 6400)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 16:
                        if (XP <= 1600)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 1600 & XP <= 3200)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 3200 & XP <= 4800)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 4800 & XP <= 7200)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 17:
                        if (XP <= 2000)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 2000 & XP <= 3900)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 3900 & XP <= 5900)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 5900 & XP <= 8800)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 18:
                        if (XP <= 2100)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 2100 & XP <= 4200)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 4200 & XP <= 6300)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 6300 & XP <= 9500)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 19:
                        if (XP <= 2400)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 2400 & XP <= 4900)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 4900 & XP <= 7300)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 7300 & XP <= 10900)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;
                    case 20:
                        if (XP <= 2800)
                        {
                            dificuldade = "Fácil";
                        }
                        else if (XP > 2800 & XP <= 5700)
                        {
                            dificuldade = "Médio";
                        }
                        else if (XP > 5700 & XP <= 8500)
                        {
                            dificuldade = "Difícil";
                        }
                        else if (XP > 8500 & XP <= 12700)
                        {
                            dificuldade = "Mortal";
                        }
                        else
                        {
                            dificuldade = "Impossível";
                        }

                        break;

                }

                return dificuldade;
            }
            catch
            {
                return "Preenchimento invalido, preencher apenas com numeros.";
            }
        }
    }
}
