using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ExperienciaDados
    {
        #region Listas
        private List<ItemPersonagem> listPersonagem = new List<ItemPersonagem>();
        private List<ItemExp> listNvl = new List<ItemExp>();
        private List<ItemExp> listDia = new List<ItemExp>();
        private List<ItemExp> listNd = new List<ItemExp>();
        #endregion

        #region ND por Personagem
        public DataTable montaDtDificuldade(DataTable dtDificuldade)
        {
            dtDificuldade = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND";
            dtDificuldade.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "FACIL";
            dtDificuldade.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "MEDIO";
            dtDificuldade.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "DIFICIL";
            dtDificuldade.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "MORTAL";
            dtDificuldade.Columns.Add(column);

            listPersonagem = preencheListaDificuldade(listPersonagem);

            foreach (ItemPersonagem personagem in listPersonagem)
            {
                DataRow linha = dtDificuldade.NewRow();
                linha["ND"] = personagem.nd;
                linha["FACIL"] = personagem.facil;
                linha["MEDIO"] = personagem.medio;
                linha["DIFICIL"] = personagem.dificil;
                linha["MORTAL"] = personagem.mortal;

                dtDificuldade.Rows.Add(linha);
            }

            return dtDificuldade;
        }
        private List<ItemPersonagem> preencheListaDificuldade(List<ItemPersonagem> listItem)
        {
            listItem.Add(new ItemPersonagem("1", "25", "50", "75", "100"));
            listItem.Add(new ItemPersonagem("2", "50", "100", "150", "200"));
            listItem.Add(new ItemPersonagem("3", "75", "150", "225", "400"));
            listItem.Add(new ItemPersonagem("4", "125", "250", "375", "500"));
            listItem.Add(new ItemPersonagem("5", "250", "500", "750", "1.100"));
            listItem.Add(new ItemPersonagem("6", "300", "600", "900", "1.400"));
            listItem.Add(new ItemPersonagem("7", "350", "750", "1.100", "1.700"));
            listItem.Add(new ItemPersonagem("8", "450", "900", "1.400", "2.100"));
            listItem.Add(new ItemPersonagem("9", "550", "1.100", "1.600", "2.400"));
            listItem.Add(new ItemPersonagem("10", "600", "1.200", "1.900", "2.800"));
            listItem.Add(new ItemPersonagem("11", "800", "1.600", "2.400", "3.600"));
            listItem.Add(new ItemPersonagem("12", "1.000", "2.000", "3.000", "4.500"));
            listItem.Add(new ItemPersonagem("13", "1.100", "2.200", "3.400", "5.100"));
            listItem.Add(new ItemPersonagem("14", "1.250", "2.500", "3.800", "5.700"));
            listItem.Add(new ItemPersonagem("15", "1.400", "2.800", "4.300", "6.400"));
            listItem.Add(new ItemPersonagem("16", "1.600", "3.200", "4.800", "7.200"));
            listItem.Add(new ItemPersonagem("17", "2.000", "3.900", "5.900", "8.800"));
            listItem.Add(new ItemPersonagem("18", "2.100", "4.200", "6.300", "9.500"));
            listItem.Add(new ItemPersonagem("19", "2.400", "4.900", "7.300", "10.900"));
            listItem.Add(new ItemPersonagem("20", "2.800", "5.700", "8.500", "12.700"));
            return listItem;
        }
        #endregion

        #region XP por Nvl
        private List<ItemExp> preencheListaNvl(List<ItemExp> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemExp("1", "0"));
            listItem.Add(new ItemExp("2", "300"));
            listItem.Add(new ItemExp("3", "900"));
            listItem.Add(new ItemExp("4", "2.700"));
            listItem.Add(new ItemExp("5", "6.500"));
            listItem.Add(new ItemExp("6", "14.000"));
            listItem.Add(new ItemExp("7", "23.000"));
            listItem.Add(new ItemExp("8", "34.000"));
            listItem.Add(new ItemExp("9", "48.000"));
            listItem.Add(new ItemExp("10", "64.000"));
            listItem.Add(new ItemExp("11", "85.000"));
            listItem.Add(new ItemExp("12", "100.000"));
            listItem.Add(new ItemExp("13", "120.000"));
            listItem.Add(new ItemExp("14", "140.000"));
            listItem.Add(new ItemExp("15", "165.000"));
            listItem.Add(new ItemExp("16", "195.000"));
            listItem.Add(new ItemExp("17", "225.000"));
            listItem.Add(new ItemExp("18", "265.000"));
            listItem.Add(new ItemExp("19", "305.000"));
            listItem.Add(new ItemExp("20", "355.000"));

            return listItem;
        }
        public DataTable montaDtNvl(DataTable dtNvl)
        {
            dtNvl = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl";
            dtNvl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP";
            dtNvl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl/1";
            dtNvl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP/1";
            dtNvl.Columns.Add(column);

            listNvl = preencheListaNvl(listNvl);

            int j = 10;

            for (int i = 0; i <= 9; i++)
            {
                DataRow linha = dtNvl.NewRow();
                linha["Nvl"] = listNvl[i].item;
                linha["XP"] = listNvl[i].exp;
                if (listNvl.Count > j)
                {
                    if (!String.IsNullOrEmpty(listNvl[j].item) && !String.IsNullOrEmpty(listNvl[j].exp))
                    {
                        linha["Nvl/1"] = listNvl[j].item;
                        linha["XP/1"] = listNvl[j].exp;
                        j++;
                    }
                }
                dtNvl.Rows.Add(linha);

            }

            return dtNvl;
        }
        #endregion

        #region XP por Dia
        private List<ItemExp> preencheListaDia(List<ItemExp> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemExp("1", "300"));
            listItem.Add(new ItemExp("2", "600"));
            listItem.Add(new ItemExp("3", "1.200"));
            listItem.Add(new ItemExp("4", "1.700"));
            listItem.Add(new ItemExp("5", "3.500"));
            listItem.Add(new ItemExp("6", "4.000"));
            listItem.Add(new ItemExp("7", "5.000"));
            listItem.Add(new ItemExp("8", "6.000"));
            listItem.Add(new ItemExp("9", "7.500"));
            listItem.Add(new ItemExp("10", "9.000"));
            listItem.Add(new ItemExp("11", "10.500"));
            listItem.Add(new ItemExp("12", "11.500"));
            listItem.Add(new ItemExp("13", "13.500"));
            listItem.Add(new ItemExp("14", "15.000"));
            listItem.Add(new ItemExp("15", "18.000"));
            listItem.Add(new ItemExp("16", "20.000"));
            listItem.Add(new ItemExp("17", "25.000"));
            listItem.Add(new ItemExp("18", "27.000"));
            listItem.Add(new ItemExp("19", "30.000"));
            listItem.Add(new ItemExp("20", "40.000"));

            return listItem;
        }
        public DataTable montaDtDia(DataTable dtDia)
        {
            dtDia = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl";
            dtDia.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP por Dia";
            dtDia.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl/1";
            dtDia.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP por Dia/1";
            dtDia.Columns.Add(column);

            listDia = preencheListaDia(listDia);

            int j = 10;

            for (int i = 0; i <= 9; i++)
            {
                DataRow linha = dtDia.NewRow();
                linha["Nvl"] = listDia[i].item;
                linha["XP por Dia"] = listDia[i].exp;
                if (listDia.Count > j)
                {
                    if (!String.IsNullOrEmpty(listDia[j].item) && !String.IsNullOrEmpty(listDia[j].exp))
                    {
                        linha["Nvl/1"] = listDia[j].item;
                        linha["XP por Dia/1"] = listDia[j].exp;
                        j++;
                    }
                }
                dtDia.Rows.Add(linha);

            }

            return dtDia;
        }
        #endregion

        #region XP por ND
        public DataTable montaDtNd(DataTable dtNd)
        {
            dtNd = new DataTable();

            DataColumn column;

            #region Colunas
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND/1";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP/1";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND/2";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP/2";
            dtNd.Columns.Add(column);
            listNd = preencheListaND(listNd);
            #endregion

            int j = 12;
            int k = 24;

            for (int i = 0; i <= 11; i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["ND"] = listNd[i].item;
                linha["XP"] = listNd[i].exp;
                if (listNd.Count > j)
                {
                    if (!String.IsNullOrEmpty(listNd[j].item) && !String.IsNullOrEmpty(listNd[j].exp))
                    {
                        linha["ND/1"] = listNd[j].item;
                        linha["XP/1"] = listNd[j].exp;
                        j++;
                    }
                }
                if (listNd.Count > k)
                {
                    if (!String.IsNullOrEmpty(listNd[k].item) && !String.IsNullOrEmpty(listNd[k].exp))
                    {
                        linha["ND/2"] = listNd[k].item;
                        linha["XP/2"] = listNd[k].exp;
                        k++;
                    }
                }
                dtNd.Rows.Add(linha);
            }

            return dtNd;
        }
        private List<ItemExp> preencheListaND(List<ItemExp> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemExp("0"  ,"0 ou 10"));
            listItem.Add(new ItemExp("1/8", "25"));
            listItem.Add(new ItemExp("1/4", "50"));
            listItem.Add(new ItemExp("1/2", "100"));
            listItem.Add(new ItemExp("1", "200"));
            listItem.Add(new ItemExp("2", "450"));
            listItem.Add(new ItemExp("3", "700"));
            listItem.Add(new ItemExp("4", "1.100"));
            listItem.Add(new ItemExp("5", "1.800"));
            listItem.Add(new ItemExp("6", "2.300"));
            listItem.Add(new ItemExp("7", "2.900"));
            listItem.Add(new ItemExp("8", "3.900"));
            listItem.Add(new ItemExp("9", "5.000"));
            listItem.Add(new ItemExp("10", "5.900"));
            listItem.Add(new ItemExp("11", "7.200"));
            listItem.Add(new ItemExp("12", "8.400"));
            listItem.Add(new ItemExp("13", "10.000"));
            listItem.Add(new ItemExp("14", "11.500"));
            listItem.Add(new ItemExp("15", "13.000"));
            listItem.Add(new ItemExp("16", "15.000"));
            listItem.Add(new ItemExp("17", "18.000"));
            listItem.Add(new ItemExp("18", "20.000"));
            listItem.Add(new ItemExp("19", "22.000"));
            listItem.Add(new ItemExp("20", "25.000"));
            listItem.Add(new ItemExp("21", "33.000"));
            listItem.Add(new ItemExp("22", "41.000"));
            listItem.Add(new ItemExp("23", "50.000"));
            listItem.Add(new ItemExp("24", "62.000"));
            listItem.Add(new ItemExp("25", "75.000"));
            listItem.Add(new ItemExp("26", "90.000"));
            listItem.Add(new ItemExp("27", "105.000"));
            listItem.Add(new ItemExp("28", "120.000"));
            listItem.Add(new ItemExp("29", "135.000"));
            listItem.Add(new ItemExp("30", "155.000"));


            return listItem;
        }
        #endregion
    
        #region Multi de XP
        public DataTable montaDtMulti(DataTable dtMulti)
        {
            dtMulti = new DataTable();

            DataColumn column;

            #region Colunas
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Qtd";
            dtMulti.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Multi";
            dtMulti.Columns.Add(column);

            listNd = preencheListaMulti(listNd);
            #endregion

            for (int i = 0; i <= 5; i++)
            {
                DataRow linha = dtMulti.NewRow();
                linha["Qtd"] = listNd[i].item;
                linha["Multi"] = listNd[i].exp;
                dtMulti.Rows.Add(linha);
            }

            dtMulti.Columns["Qtd"].ColumnName = "Quantidade de Monstros";
            dtMulti.Columns["Multi"].ColumnName = "Multiplicador de EXP";

            return dtMulti;
        }
        private List<ItemExp> preencheListaMulti(List<ItemExp> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemExp("1", "x1"));
            listItem.Add(new ItemExp("2", "x1.5"));
            listItem.Add(new ItemExp("3-6", "x2"));
            listItem.Add(new ItemExp("7-10", "2.5"));
            listItem.Add(new ItemExp("11-14", "x3"));
            listItem.Add(new ItemExp("15 ou Mais", "x4"));

            return listItem;
        }
        #endregion    
    }
}
