using System;
using System.Collections.Generic;
using System.Data;

namespace Euphoria.Dados
{
    public class ModificadoresDados
    {
        private List<ItemModificador> listNvl = new List<ItemModificador>();
        private List<ItemModificador> listNd = new List<ItemModificador>();
        private List<ItemModificador> listHab = new List<ItemModificador>();

        #region Mod. Por Nvl
        public DataTable MontaDtNvl(DataTable dtNvl)
        {
            dtNvl = new DataTable();

            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Nvl"
            };
            dtNvl.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Mod. BP"
            };
            dtNvl.Columns.Add(column);

            listNvl = PreencheListaNvl(listNvl);

            foreach (ItemModificador itemModificador in listNvl)
            {
                DataRow linha = dtNvl.NewRow();
                linha["Nvl"] = itemModificador.Item;
                linha["Mod. BP"] = itemModificador.Mod;
                dtNvl.Rows.Add(linha);
            }

            return dtNvl;
        }
        private List<ItemModificador> PreencheListaNvl(List<ItemModificador> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemModificador("1", "+2"));
            listItem.Add(new ItemModificador("2", "+2"));
            listItem.Add(new ItemModificador("3", "+2"));
            listItem.Add(new ItemModificador("4", "+2"));
            listItem.Add(new ItemModificador("5", "+3"));
            listItem.Add(new ItemModificador("6", "+3"));
            listItem.Add(new ItemModificador("7", "+3"));
            listItem.Add(new ItemModificador("8", "+3"));
            listItem.Add(new ItemModificador("9", "+4"));
            listItem.Add(new ItemModificador("10", "+4"));
            listItem.Add(new ItemModificador("11", "+4"));
            listItem.Add(new ItemModificador("12", "+4"));
            listItem.Add(new ItemModificador("13", "+5"));
            listItem.Add(new ItemModificador("14", "+5"));
            listItem.Add(new ItemModificador("15", "+5"));
            listItem.Add(new ItemModificador("16", "+5"));
            listItem.Add(new ItemModificador("17", "+6"));
            listItem.Add(new ItemModificador("18", "+6"));
            listItem.Add(new ItemModificador("19", "+6"));
            listItem.Add(new ItemModificador("20", "+6"));

            return listItem;
        }
        #endregion

        #region Mod. Por ND
        public DataTable MontaDtNd(DataTable dtNd)
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "ND"
            };
            dtNd.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Mod. BP"
            };
            dtNd.Columns.Add(column);

            listNd = PreencheLista(listNd);

            foreach (ItemModificador itemModificador in listNd)
            {
                DataRow linha = dtNd.NewRow();
                linha["ND"] = itemModificador.Item;
                linha["Mod. BP"] = itemModificador.Mod;
                dtNd.Rows.Add(linha);
            }

            return dtNd;
        }
        private List<ItemModificador> PreencheLista(List<ItemModificador> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemModificador("0", "+2"));
            listItem.Add(new ItemModificador("1/8", "+2"));
            listItem.Add(new ItemModificador("1/4", "+2"));
            listItem.Add(new ItemModificador("1/2", "+2"));
            listItem.Add(new ItemModificador("1", "+2"));
            listItem.Add(new ItemModificador("2", "+2"));
            listItem.Add(new ItemModificador("3", "+2"));
            listItem.Add(new ItemModificador("4", "+2"));
            listItem.Add(new ItemModificador("5", "+3"));
            listItem.Add(new ItemModificador("6", "+3"));
            listItem.Add(new ItemModificador("7", "+3"));
            listItem.Add(new ItemModificador("8", "+3"));
            listItem.Add(new ItemModificador("9", "+4"));
            listItem.Add(new ItemModificador("10", "+4"));
            listItem.Add(new ItemModificador("11", "+4"));
            listItem.Add(new ItemModificador("12", "+4"));
            listItem.Add(new ItemModificador("13", "+5"));
            listItem.Add(new ItemModificador("14", "+5"));
            listItem.Add(new ItemModificador("15", "+5"));
            listItem.Add(new ItemModificador("16", "+5"));
            listItem.Add(new ItemModificador("17", "+6"));
            listItem.Add(new ItemModificador("18", "+6"));
            listItem.Add(new ItemModificador("19", "+6"));
            listItem.Add(new ItemModificador("20", "+6"));
            listItem.Add(new ItemModificador("21", "+7"));
            listItem.Add(new ItemModificador("22", "+7"));
            listItem.Add(new ItemModificador("23", "+7"));
            listItem.Add(new ItemModificador("24", "+7"));
            listItem.Add(new ItemModificador("25", "+8"));
            listItem.Add(new ItemModificador("26", "+8"));
            listItem.Add(new ItemModificador("27", "+8"));
            listItem.Add(new ItemModificador("28", "+8"));
            listItem.Add(new ItemModificador("29", "+9"));
            listItem.Add(new ItemModificador("30", "+9"));

            return listItem;
        }
        #endregion

        #region Mod. Po Valor de Habilidade
        public DataTable MontaDtHab(DataTable dtHab)
        {
            dtHab = new DataTable();

            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Valor de Habilidade"
            };
            dtHab.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Mod."
            };
            dtHab.Columns.Add(column);

            listHab = PreencheListaHab(listHab);

            foreach (ItemModificador item in listHab)
            {
                DataRow linha = dtHab.NewRow();
                linha["Valor de Habilidade"] = item.Item;
                linha["Mod."] = item.Mod;
                dtHab.Rows.Add(linha);

            }

            return dtHab;
        }
        private List<ItemModificador> PreencheListaHab(List<ItemModificador> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemModificador("1", "-5"));
            listItem.Add(new ItemModificador("2-3", "-4"));
            listItem.Add(new ItemModificador("4-5", "-3"));
            listItem.Add(new ItemModificador("6-7", "-2"));
            listItem.Add(new ItemModificador("8-9", "-1"));
            listItem.Add(new ItemModificador("10-11", "0"));
            listItem.Add(new ItemModificador("12-13", "+1"));
            listItem.Add(new ItemModificador("14-15", "+2"));
            listItem.Add(new ItemModificador("16-17", "+3"));
            listItem.Add(new ItemModificador("18-19", "+4"));
            listItem.Add(new ItemModificador("20-21", "+5"));
            listItem.Add(new ItemModificador("22-23", "+6"));
            listItem.Add(new ItemModificador("24-25", "+7"));
            listItem.Add(new ItemModificador("26-27", "+8"));
            listItem.Add(new ItemModificador("28-29", "+9"));
            listItem.Add(new ItemModificador("30", "+10"));

            return listItem;
        }
        #endregion
    }
}
