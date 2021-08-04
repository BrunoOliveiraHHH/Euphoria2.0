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
            listItem.Add(new ItemExp("0", "1"));
            listItem.Add(new ItemExp("300", "2"));
            listItem.Add(new ItemExp("900", "3"));
            listItem.Add(new ItemExp("2.700", "4"));
            listItem.Add(new ItemExp("6.500", "5"));
            listItem.Add(new ItemExp("14.000", "6"));
            listItem.Add(new ItemExp("23.000", "7"));
            listItem.Add(new ItemExp("34.000", "8"));
            listItem.Add(new ItemExp("48.000", "9"));
            listItem.Add(new ItemExp("64.000", "10"));
            listItem.Add(new ItemExp("85.000", "11"));
            listItem.Add(new ItemExp("100.000", "12"));
            listItem.Add(new ItemExp("120.000", "13"));
            listItem.Add(new ItemExp("140.000", "14"));
            listItem.Add(new ItemExp("165.000", "15"));
            listItem.Add(new ItemExp("195.000", "16"));
            listItem.Add(new ItemExp("225.000", "17"));
            listItem.Add(new ItemExp("265.000", "18"));
            listItem.Add(new ItemExp("305.000", "19"));
            listItem.Add(new ItemExp("355.000", "20"));

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
            column.ColumnName = "Nvl1";
            dtNvl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP1";
            dtNvl.Columns.Add(column);

            listNvl = preencheListaNvl(listNvl);

            int j = 20;

            for (int i = 0; i <= 19; i++)
            {
                DataRow linha = dtNvl.NewRow();
                linha["Nvl"] = listNvl[i].nvl;
                linha["XP"] = listNvl[i].exp;
                if (listNvl.Count > j)
                {
                    if (!String.IsNullOrEmpty(listNvl[j].nvl) && !String.IsNullOrEmpty(listNvl[j].exp))
                    {
                        linha["Nvl1"] = listNvl[j].nvl;
                        linha["XP1"] = listNvl[j].exp;
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
            listItem.Add(new ItemExp("300", "1"));
            listItem.Add(new ItemExp("600", "2"));
            listItem.Add(new ItemExp("1.200", "3"));
            listItem.Add(new ItemExp("1.700", "4"));
            listItem.Add(new ItemExp("3.500", "5"));
            listItem.Add(new ItemExp("4.000", "6"));
            listItem.Add(new ItemExp("5.000", "7"));
            listItem.Add(new ItemExp("6.000", "8"));
            listItem.Add(new ItemExp("7.500", "9"));
            listItem.Add(new ItemExp("9.000", "10"));
            listItem.Add(new ItemExp("10.500", "11"));
            listItem.Add(new ItemExp("11.500", "12"));
            listItem.Add(new ItemExp("13.500", "13"));
            listItem.Add(new ItemExp("15.000", "14"));
            listItem.Add(new ItemExp("18.000", "15"));
            listItem.Add(new ItemExp("20.000", "16"));
            listItem.Add(new ItemExp("25.000", "17"));
            listItem.Add(new ItemExp("27.000", "18"));
            listItem.Add(new ItemExp("30.000", "19"));
            listItem.Add(new ItemExp("40.000", "20"));

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

            listDia = preencheListaDia(listDia);


            for (int i = 0; i < listDia.Count(); i++)
            {
                DataRow linha = dtDia.NewRow();
                linha["Nvl"] = listDia[i].nvl;
                linha["XP por Dia"] = listDia[i].exp;

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

            int j = 11;
            int k = 23;

            for (int i = 0; i <= 10; i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["ND"] = listNd[i].nvl;
                linha["XP"] = listNd[i].exp;
                if (listNd.Count > j)
                {
                    if (!String.IsNullOrEmpty(listNd[j].nvl) && !String.IsNullOrEmpty(listNd[j].exp))
                    {
                        linha["ND/1"] = listNd[j].nvl;
                        linha["XP/1"] = listNd[j].exp;
                        j++;
                    }
                }
                if (listNd.Count > k)
                {
                    if (!String.IsNullOrEmpty(listNd[k].nvl) && !String.IsNullOrEmpty(listNd[k].exp))
                    {
                        linha["ND/2"] = listNd[k].nvl;
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
            listItem.Add(new ItemExp("0 ou 10", "0"));
            listItem.Add(new ItemExp("25", "1/8"));
            listItem.Add(new ItemExp("50", "1/4"));
            listItem.Add(new ItemExp("100", "1/2"));
            listItem.Add(new ItemExp("200", "1"));
            listItem.Add(new ItemExp("450", "2"));
            listItem.Add(new ItemExp("700", "3"));
            listItem.Add(new ItemExp("1.100", "4"));
            listItem.Add(new ItemExp("1.800", "5"));
            listItem.Add(new ItemExp("2.300", "6"));
            listItem.Add(new ItemExp("2.900", "7"));
            listItem.Add(new ItemExp("3.900", "8"));
            listItem.Add(new ItemExp("5.000", "9"));
            listItem.Add(new ItemExp("5.900", "10"));
            listItem.Add(new ItemExp("7.200", "11"));
            listItem.Add(new ItemExp("8.400", "12"));
            listItem.Add(new ItemExp("10.000", "13"));
            listItem.Add(new ItemExp("11.500", "14"));
            listItem.Add(new ItemExp("13.000", "15"));
            listItem.Add(new ItemExp("15.000", "16"));
            listItem.Add(new ItemExp("18.000", "17"));
            listItem.Add(new ItemExp("20.000", "18"));
            listItem.Add(new ItemExp("22.000", "19"));
            listItem.Add(new ItemExp("25.000", "20"));
            listItem.Add(new ItemExp("33.000", "21"));
            listItem.Add(new ItemExp("41.000", "22"));
            listItem.Add(new ItemExp("50.000", "23"));
            listItem.Add(new ItemExp("62.000", "24"));
            listItem.Add(new ItemExp("75.000", "25"));
            listItem.Add(new ItemExp("90.000", "26"));
            listItem.Add(new ItemExp("105.000", "27"));
            listItem.Add(new ItemExp("120.000", "28"));
            listItem.Add(new ItemExp("135.000", "29"));
            listItem.Add(new ItemExp("155.000", "30"));

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
                linha["Qtd"] = listNd[i].nvl;
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
