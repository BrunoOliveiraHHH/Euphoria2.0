using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ModificadoresDados
    {
        private List<ItemModificador> listNvl = new List<ItemModificador>();
        private List<ItemModificador> listNd = new List<ItemModificador>();

        #region Mod. Por Nvl
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
            column.ColumnName = "Mod. BP";
            dtNvl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl 1";
            dtNvl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod. BP 1";
            dtNvl.Columns.Add(column);

            listNvl = preencheListaNvl(listNvl);

            int j = 11;

            for (int i = 0; i <= 10; i++)
            {
                DataRow linha = dtNvl.NewRow();
                linha["Nvl"] = listNvl[i].valor;
                linha["Mod. BP"] = listNvl[i].mod;
                if (listNvl.Count > j)
                {
                    if (!String.IsNullOrEmpty(listNvl[j].valor) && !String.IsNullOrEmpty(listNvl[j].mod))
                    {
                        linha["Nvl 1"] = listNvl[j].valor;
                        linha["Mod. BP 1"] = listNvl[j].mod;
                        j++;
                    }
                }
                dtNvl.Rows.Add(linha);

            }

            return dtNvl;
        }
        private List<ItemModificador> preencheListaNvl(List<ItemModificador> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemModificador("+2", "1"));
            listItem.Add(new ItemModificador("+2", "2"));
            listItem.Add(new ItemModificador("+2", "3"));
            listItem.Add(new ItemModificador("+2", "4"));
            listItem.Add(new ItemModificador("+3", "5"));
            listItem.Add(new ItemModificador("+3", "6"));
            listItem.Add(new ItemModificador("+3", "7"));
            listItem.Add(new ItemModificador("+3", "8"));
            listItem.Add(new ItemModificador("+4", "9"));
            listItem.Add(new ItemModificador("+4", "10"));
            listItem.Add(new ItemModificador("+4", "11"));
            listItem.Add(new ItemModificador("+4", "12"));
            listItem.Add(new ItemModificador("+5", "13"));
            listItem.Add(new ItemModificador("+5", "14"));
            listItem.Add(new ItemModificador("+5", "15"));
            listItem.Add(new ItemModificador("+5", "16"));
            listItem.Add(new ItemModificador("+6", "17"));
            listItem.Add(new ItemModificador("+6", "18"));
            listItem.Add(new ItemModificador("+6", "19"));
            listItem.Add(new ItemModificador("+6", "20"));

            return listItem;
        }
        #endregion
        
        #region Mod. Por ND
        public DataTable montaDtNd(DataTable dtNd)
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod. BP";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND 1";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod. BP 1";
            dtNd.Columns.Add(column);

            listNd = preencheLista(listNd);

            int j = 25;

            for (int i = 0; i <= 24; i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["ND"] = listNd[i].valor;
                linha["Mod. BP"] = listNd[i].mod;
                if (listNd.Count > j)
                {
                    if (!String.IsNullOrEmpty(listNd[j].valor) && !String.IsNullOrEmpty(listNd[j].mod))
                    {
                        linha["ND 1"] = listNd[j].valor;
                        linha["Mod. BP 1"] = listNd[j].mod;
                        j++;
                    }
                }
                dtNd.Rows.Add(linha);

            }

            return dtNd;
        }
        private List<ItemModificador> preencheLista(List<ItemModificador> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemModificador("+2", "0"));
            listItem.Add(new ItemModificador("+2", "1/8"));
            listItem.Add(new ItemModificador("+2", "1/4"));
            listItem.Add(new ItemModificador("+2", "1/2"));
            listItem.Add(new ItemModificador("+2", "1"));
            listItem.Add(new ItemModificador("+2", "2"));
            listItem.Add(new ItemModificador("+2", "3"));
            listItem.Add(new ItemModificador("+2", "4"));
            listItem.Add(new ItemModificador("+3", "5"));
            listItem.Add(new ItemModificador("+3", "6"));
            listItem.Add(new ItemModificador("+3", "7"));
            listItem.Add(new ItemModificador("+3", "8"));
            listItem.Add(new ItemModificador("+4", "9"));
            listItem.Add(new ItemModificador("+4", "10"));
            listItem.Add(new ItemModificador("+4", "11"));
            listItem.Add(new ItemModificador("+4", "12"));
            listItem.Add(new ItemModificador("+5", "13"));
            listItem.Add(new ItemModificador("+5", "14"));
            listItem.Add(new ItemModificador("+5", "15"));
            listItem.Add(new ItemModificador("+5", "16"));
            listItem.Add(new ItemModificador("+6", "17"));
            listItem.Add(new ItemModificador("+6", "18"));
            listItem.Add(new ItemModificador("+6", "19"));
            listItem.Add(new ItemModificador("+6", "20"));
            listItem.Add(new ItemModificador("+7", "21"));
            listItem.Add(new ItemModificador("+7", "22"));
            listItem.Add(new ItemModificador("+7", "23"));
            listItem.Add(new ItemModificador("+7", "24"));
            listItem.Add(new ItemModificador("+8", "25"));
            listItem.Add(new ItemModificador("+8", "26"));
            listItem.Add(new ItemModificador("+8", "27"));
            listItem.Add(new ItemModificador("+8", "28"));
            listItem.Add(new ItemModificador("+9", "29"));
            listItem.Add(new ItemModificador("+9", "30"));

            return listItem;
        }
        #endregion

        private List<Habilidade> list = new List<Habilidade>();

        public DataTable carregaDtg()
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Valor de Habilidade";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod.";
            dtNd.Columns.Add(column);

            list = preencheLista(list);

            int j = 25;

            foreach (Habilidade item in list)
            {
                DataRow linha = dtNd.NewRow();
                linha["Valor de Habilidade"] = item.valor;
                linha["Mod."] = item.modi;
                dtNd.Rows.Add(linha);

            }

            return dtNd;
        }
        private List<Habilidade> preencheLista(List<Habilidade> listItem)
        {
            listItem.Clear();
            listItem.Add(new Habilidade("-5", "1"));
            listItem.Add(new Habilidade("-4", "2-3"));
            listItem.Add(new Habilidade("-3", "4-5"));
            listItem.Add(new Habilidade("-2", "6-7"));
            listItem.Add(new Habilidade("-1", "8-9"));
            listItem.Add(new Habilidade("+0", "10-11"));
            listItem.Add(new Habilidade("+1", "12-13"));
            listItem.Add(new Habilidade("+2", "14-15"));
            listItem.Add(new Habilidade("+3", "16-17"));
            listItem.Add(new Habilidade("+4", "18-19"));
            listItem.Add(new Habilidade("+5", "20-21"));
            listItem.Add(new Habilidade("+6", "22-23"));
            listItem.Add(new Habilidade("+7", "24-25"));
            listItem.Add(new Habilidade("+8", "26-27"));
            listItem.Add(new Habilidade("+9", "28-29"));
            listItem.Add(new Habilidade("+10", "30"));

            return listItem;
        }
    }
}
