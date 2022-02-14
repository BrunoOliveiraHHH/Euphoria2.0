using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class TesourosDados
    {
        #region Listas
        List<ItemTesouro> listGemas = new List<ItemTesouro>();
        List<ItemTesouro> listObjetosDeArte = new List<ItemTesouro>();
        #endregion

        #region Gemas

        private string dados(int Dado)
        {
            switch (Dado)
            {
                case 1:
                    return "d12";
                case 2:
                    return "d12";
                case 3:
                    return "d10";
                case 4:
                    return "d6";
                case 5:
                    return "d8";
                case 6:
                    return "d4";
                default:
                    return null;
            }
 
        }

        public DataTable montaDtGemas(DataTable dtGemas,int tipo)
        {
            dtGemas = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = dados(tipo);
            dtGemas.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Descrição da Pedra";
            dtGemas.Columns.Add(column);

            listGemas = preencheListaGemas(listGemas,tipo);

            foreach (ItemTesouro item in listGemas)
            {
                DataRow linha = dtGemas.NewRow();
                linha[0] = item.item;
                linha[1] = item.valor;

                dtGemas.Rows.Add(linha);
            }

            return dtGemas;
        }

        private List<ItemTesouro> preencheListaGemas(List<ItemTesouro> listItem, int tipo)
        {
            listItem.Clear();

            switch (tipo)
            {
                case 1: //Gemas de 10 Po
                    listItem.Add(new ItemTesouro("1", "Azurita (azul escuro mosqueado opaco)"));
                    listItem.Add(new ItemTesouro("2", "Ágata malhada (marrom, azul, branca ou vermelho translúcido e listrado)"));
                    listItem.Add(new ItemTesouro("3", "Quartzo azul (azul claro transparente)"));
                    listItem.Add(new ItemTesouro("4", "Ágata ocular (círculos translúcidos de cinza, branco, marrom, azul ou verde)"));
                    listItem.Add(new ItemTesouro("5", "Hematita (cinza escuro opaco)"));
                    listItem.Add(new ItemTesouro("6", "Lápis lazúli (azul claro e escuro opaco com manchas amarelas)"));
                    listItem.Add(new ItemTesouro("7", "Malaquita (opaco estriado com verde claro e escuro)"));
                    listItem.Add(new ItemTesouro("8", "Ágata musgo (rosa translúcido ou amarelo claro com cinza musgo ou marcas verdes)"));
                    listItem.Add(new ItemTesouro("9", "Obsidiana (preto opaco)"));
                    listItem.Add(new ItemTesouro("10", "Rodocrosita (azul claro opaco)"));
                    listItem.Add(new ItemTesouro("11", "Olho de tigre (marrom translúcido com centro dourado)"));
                    listItem.Add(new ItemTesouro("12", "Turquesa (azul esverdeado claro opaco)"));
                    return listItem;

                case 2://Gemas de 50 Po
                    listItem.Add(new ItemTesouro("1", "Pedra de sangue (cinza escuro opaco com manchas vermelhas)"));
                    listItem.Add(new ItemTesouro("2", "Cornalina (de laranja a vermelho amarronzado opaco)"));
                    listItem.Add(new ItemTesouro("3", "Calcedônia (branco opaco)"));
                    listItem.Add(new ItemTesouro("4", "Crisoprásio (verde translúcido)"));
                    listItem.Add(new ItemTesouro("5", "Citrina (amarelo claro amarronzado transparente)"));
                    listItem.Add(new ItemTesouro("6", "Jaspe (azul, preto ou marrom opaco)"));
                    listItem.Add(new ItemTesouro("7", "Pedra lunar (branco translúcido com azul claro brilhante)"));
                    listItem.Add(new ItemTesouro("8", "Ônix (faixas opacas de preto e branco, ou preto ou branco puro)"));
                    listItem.Add(new ItemTesouro("9", "Quartzo (branco transparente, cinza ou amarelo esfumaçado)"));
                    listItem.Add(new ItemTesouro("10", "Sardônica (faixas opacas de vermelho e branco)"));
                    listItem.Add(new ItemTesouro("11", "Quartzo rosa estrela (pedra rosa translúcida com centro branco em forma de estrela)"));
                    listItem.Add(new ItemTesouro("12", "Zircônio (azul esverdeado claro transparente)"));
                    return listItem;

                case 3://Gemas de 100 Po
                    listItem.Add(new ItemTesouro("1", "Âmbar (transparente entre ouro aquoso e ouro vívido)"));
                    listItem.Add(new ItemTesouro("2", "Ametista (púrpura profundo transparente)"));
                    listItem.Add(new ItemTesouro("3", "Crisoberilo (transparente entre amarelo esverdeado e verde claro)"));
                    listItem.Add(new ItemTesouro("4", "Coral (carmesim opaco)"));
                    listItem.Add(new ItemTesouro("5", "Granada (vermelho, marrom esverdeado ou branco transparente)"));
                    listItem.Add(new ItemTesouro("6", "Jade (verde claro, verde escuro ou branco translúcido)"));
                    listItem.Add(new ItemTesouro("7", "Jato (preto profundo opaco)"));
                    listItem.Add(new ItemTesouro("8", "Pérola (branco, amarelo ou rosa opaco e lustroso)"));
                    listItem.Add(new ItemTesouro("9", "Espinela (vermelho, vermelho amarronzado ou verde escuro transparente)"));
                    listItem.Add(new ItemTesouro("10", "Turmalina (verde, azul, marrom ou vermelho claro transparente)"));
                    return listItem;

                case 4://Gemas de 500 Po
                    listItem.Add(new ItemTesouro("1", "Alexandrita (verde escuro transparente)"));
                    listItem.Add(new ItemTesouro("2", "Água-marinha (azul esverdeado clarotransparente)"));
                    listItem.Add(new ItemTesouro("3", "Pérola negra (preto puro opaco)"));
                    listItem.Add(new ItemTesouro("4", "Espinela azul (azul escuro transparente)"));
                    listItem.Add(new ItemTesouro("5", "Peridoto (verde oliva vívido transparente)"));
                    listItem.Add(new ItemTesouro("6", "Topázio (amarelo-ouro transparente)"));
                    return listItem;

                case 5://Gemas de 1000 Po
                    listItem.Add(new ItemTesouro("1", "Opala negra (verde escuro translúcido com preto mosqueado e manchas douradas)"));
                    listItem.Add(new ItemTesouro("2", "Safira azul (de azul claro a azul médio transparente)"));
                    listItem.Add(new ItemTesouro("3", "Esmeralda (verde escuro brilhante transparente)"));
                    listItem.Add(new ItemTesouro("4", "Opala de fogo (vermelho fogo translúcido)"));
                    listItem.Add(new ItemTesouro("5", "Opala (azul claro translúcido mosqueado de verde e dourado)"));
                    listItem.Add(new ItemTesouro("6", "Rubi estrela (rubi translucido com centro branco em forma de estrela)"));
                    listItem.Add(new ItemTesouro("7", "Safira estrela (safira azul translúcida com centro branco em forma de estrela)"));
                    listItem.Add(new ItemTesouro("8", "Safira amarela (amarelo fogo ou amarelo esverdeado transparente)"));
                    return listItem;

                case 6://Gemas de 5000 Po
                    listItem.Add(new ItemTesouro("1", "Safira negra (preto lustroso transparente com destaques brilhantes)"));
                    listItem.Add(new ItemTesouro("2", "Diamante (azul claro, canário, rosa, marrom ou azul transparente)"));
                    listItem.Add(new ItemTesouro("3", "Jacinto (laranja fogo transparente)"));
                    listItem.Add(new ItemTesouro("4", "Rubi (de vermelho claro a carmesim escuro transparente)"));
                    return listItem;

                default:
                    return listItem;
            }            
        }
        
        #endregion

        #region Objetos de Arte
        private string dadosArte(int Dado)
        {
            switch (Dado)
            {
                case 1:
                    return "d10";
                case 2:
                    return "d10";
                case 3:
                    return "d10";
                case 4:
                    return "d10";
                case 5:
                    return "d8";
                default:
                    return null;
            }

        }

        public DataTable montaDtObjetos(DataTable dtObjeto, int tipo)
        {
            dtObjeto = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = dadosArte(tipo);
            dtObjeto.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Objeto";
            dtObjeto.Columns.Add(column);

            listObjetosDeArte = preencheListaObjeto(listObjetosDeArte, tipo);

            foreach (ItemTesouro item in listObjetosDeArte)
            {
                DataRow linha = dtObjeto.NewRow();
                linha[0] = item.item;
                linha[1] = item.valor;

                dtObjeto.Rows.Add(linha);
            }

            return dtObjeto;
        }

        private List<ItemTesouro> preencheListaObjeto(List<ItemTesouro> listItem, int tipo)
        {
            listItem.Clear();

            switch (tipo)
            {
                case 1: //Objetos de Arte de 25 Po
                    listItem.Add(new ItemTesouro("1", "Jarro de prata"));
                    listItem.Add(new ItemTesouro("2", "Estatueta esculpida em osso"));
                    listItem.Add(new ItemTesouro("3", "Bracelete de ouro pequeno"));
                    listItem.Add(new ItemTesouro("4", "Vestimenta de tecido dourado"));
                    listItem.Add(new ItemTesouro("5", "Máscara de veludo negra costurada com fios de prata"));
                    listItem.Add(new ItemTesouro("6", "Cálice de cobre com filigrana prateada"));
                    listItem.Add(new ItemTesouro("7", "Par de dados de osso com gravuras"));
                    listItem.Add(new ItemTesouro("8", "Pequeno espelho numa moldura de madeira pintada"));
                    listItem.Add(new ItemTesouro("9", "Lenço de seda bordado"));
                    listItem.Add(new ItemTesouro("10", "Broche de ouro com um retrato pintado dentro"));
                    return listItem;

                case 2: //Objetos de Arte de 250 Po
                    listItem.Add(new ItemTesouro("1", "Anel de ouro cravejado com pedras de sangue"));
                    listItem.Add(new ItemTesouro("2", "Estatueta esculpida em marfim"));
                    listItem.Add(new ItemTesouro("3", "Bracelete de ouro largo"));
                    listItem.Add(new ItemTesouro("4", "Gargantilha de prata com um pingente de pedra preciosa"));
                    listItem.Add(new ItemTesouro("5", "Coroa de bronze"));
                    listItem.Add(new ItemTesouro("6", "Robe de seda com adornos de ouro"));
                    listItem.Add(new ItemTesouro("7", "Grande tapeçaria elegante"));
                    listItem.Add(new ItemTesouro("8", "Caneca de bronze com jades incrustadas"));
                    listItem.Add(new ItemTesouro("9", "Caixa de miniaturas de animais em turquesa"));
                    listItem.Add(new ItemTesouro("10", "Gaiola de pássaro de ouro com filigrana de electro"));
                    return listItem;

                case 3: //Objetos de Arte de 750 Po
                    listItem.Add(new ItemTesouro("1", "Cálice de prata cravejado com pedras da lua"));
                    listItem.Add(new ItemTesouro("2", "Espada longa de lâmina prateada com conjunto de jatos no cabo"));
                    listItem.Add(new ItemTesouro("3", "Harpa de madeira exótica com marfim incrustado e gemas de zircónio"));
                    listItem.Add(new ItemTesouro("4", "Pequeno ídolo de ouro"));
                    listItem.Add(new ItemTesouro("5", "Pente de ouro em formato de dragão cravejada com granadas vermelhas nos olhos"));
                    listItem.Add(new ItemTesouro("6", "Rolha de garrafa gravada com folhas de ouro e cravejada com ametistas"));
                    listItem.Add(new ItemTesouro("7", "Adaga de electro cerimonial com uma pérola negra no pomo"));
                    listItem.Add(new ItemTesouro("8", "Broche de prata e ouro"));
                    listItem.Add(new ItemTesouro("9", "Estatueta de obsidiana com detalhes e incrustações de ouro"));
                    listItem.Add(new ItemTesouro("10", "Máscara de guerra de ouro pintada"));
                    return listItem;

                case 4: //Objetos de Arte de 2500 Po
                    listItem.Add(new ItemTesouro("1", "Corrente de ouro elegante cravejada com uma opala de fogo"));
                    listItem.Add(new ItemTesouro("2", "Antiga pintura obra-prima"));
                    listItem.Add(new ItemTesouro("3", "Manto de seda e veludo bordado com diversas pedras da lua cravejadas"));
                    listItem.Add(new ItemTesouro("4", "Bracelete de platina cravejado com uma safira"));
                    listItem.Add(new ItemTesouro("5", "Luvas bordadas com lascas de joias"));
                    listItem.Add(new ItemTesouro("6", "Peúga cheia de joias"));
                    listItem.Add(new ItemTesouro("7", "Caixa de música de ouro"));
                    listItem.Add(new ItemTesouro("8", "Argola de ouro cravejada com quatro águas marinhas"));
                    listItem.Add(new ItemTesouro("9", "Tapa-olho com um olho falso cravejado em uma safira azul e uma pedra da lua"));
                    listItem.Add(new ItemTesouro("10", "Um colar de pequenas pérolas rosas"));
                    return listItem;

                case 5: //Objetos de Arte de 750 Po
                    listItem.Add(new ItemTesouro("1", "Coroa de ouro cheia de joias"));
                    listItem.Add(new ItemTesouro("2", "Anel de platina cheio de joias"));
                    listItem.Add(new ItemTesouro("3", "Pequena estatueta de ouro cravejada com rubis"));
                    listItem.Add(new ItemTesouro("4", "Taça de ouro cravejada com esmeraldas"));
                    listItem.Add(new ItemTesouro("5", "Caixa de joias de ouro com filigrana de platina"));
                    listItem.Add(new ItemTesouro("6", "Sarcófago infantil de ouro pintado"));
                    listItem.Add(new ItemTesouro("7", "Jogo de tabuleiro de jade com peças de ouro maciço"));
                    listItem.Add(new ItemTesouro("8", "Chifre de marfim adornado com filigrana de ouro"));
                    return listItem;

                default:
                    return listItem;
            }
        }
        #endregion
    }
}
