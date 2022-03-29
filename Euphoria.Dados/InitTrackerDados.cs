using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euphoria.Dados
{
    public class InitTrackerDados
    {
        private List<ItemCRUD> listCRUD = new List<ItemCRUD>();
        private Int64 id = 1;

        #region Save
        public DataTable SaveTracker(DataTable dtCRUD, ItemCRUD item)
        {
            if (dtCRUD == null && item != null)
            {
                dtCRUD = new DataTable();
                item.Id = id;
                listCRUD.Add(item);
            }
            else if (dtCRUD != null && item != null)
            {
                dtCRUD.Columns["Pontos de Vida"].ColumnName = "PV";
                dtCRUD.Columns["Classe de Armadura"].ColumnName = "CA";
                dtCRUD.Columns["Iniciativa"].ColumnName = "Init";

                listCRUD = PreencheListaDt(dtCRUD, item);
                dtCRUD = new DataTable();
            }

            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "ID"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Nome"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Init"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "PV"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "CA"
            };
            dtCRUD.Columns.Add(column);

            foreach (ItemCRUD itemL in listCRUD)
            {
                DataRow linha = dtCRUD.NewRow();
                linha["ID"] = itemL.Id.ToString();
                linha["Nome"] = itemL.Nome;
                linha["Init"] = itemL.Init.ToString();
                linha["PV"] = itemL.Hp.ToString();
                linha["CA"] = itemL.Ca.ToString();
                dtCRUD.Rows.Add(linha);
            }

            if (dtCRUD.Columns.Contains("PV") || dtCRUD.Columns.Contains("CA") || dtCRUD.Columns.Contains("Init"))
            {
                dtCRUD.Columns["PV"].ColumnName = "Pontos de Vida";
                dtCRUD.Columns["CA"].ColumnName = "Classe de Armadura";
                dtCRUD.Columns["Init"].ColumnName = "Iniciativa";
            }

            return dtCRUD;
        }

        private List<ItemCRUD> PreencheListaDt(DataTable dtCRUD, ItemCRUD itemIn)
        {
            listCRUD.Clear();

            foreach (DataRow dr in dtCRUD.Rows)
            {
                listCRUD.Add(new ItemCRUD
                {
                    Id = Convert.ToInt64(dr["ID"].ToString()),
                    Nome = dr["Nome"].ToString(),
                    Init = Convert.ToInt64(dr["Init"].ToString()),
                    Hp = Convert.ToInt64(dr["PV"].ToString()),
                    Ca = Convert.ToInt64(dr["CA"].ToString())
                });
            }

            itemIn.Id = Convert.ToInt64(listCRUD.Count) + 1;
            listCRUD.Add(itemIn);

            return listCRUD;
        }
        #endregion

        #region Update
        public DataTable UpdateTracker(DataTable dtCRUD, ItemCRUD item)
        {
            dtCRUD.Columns["Pontos de Vida"].ColumnName = "PV";
            dtCRUD.Columns["Classe de Armadura"].ColumnName = "CA";
            dtCRUD.Columns["Iniciativa"].ColumnName = "Init";

            listCRUD = PreencheListaDtUpdate(dtCRUD, item);
            dtCRUD = new DataTable();

            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "ID"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Nome"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Init"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "PV"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "CA"
            };
            dtCRUD.Columns.Add(column);

            foreach (ItemCRUD itemL in listCRUD)
            {
                DataRow linha = dtCRUD.NewRow();
                linha["ID"] = itemL.Id.ToString();
                linha["Nome"] = itemL.Nome;
                linha["Init"] = itemL.Init.ToString();
                linha["PV"] = itemL.Hp.ToString();
                linha["CA"] = itemL.Ca.ToString();
                dtCRUD.Rows.Add(linha);
            }

            if (dtCRUD.Columns.Contains("PV") || dtCRUD.Columns.Contains("CA") || dtCRUD.Columns.Contains("Init"))
            {
                dtCRUD.Columns["PV"].ColumnName = "Pontos de Vida";
                dtCRUD.Columns["CA"].ColumnName = "Classe de Armadura";
                dtCRUD.Columns["Init"].ColumnName = "Iniciativa";
            }

            return dtCRUD;
        }

        private List<ItemCRUD> PreencheListaDtUpdate(DataTable dtCRUD, ItemCRUD itemIn)
        {
            Boolean _out = false;
            listCRUD.Clear();

            foreach (DataRow dr in dtCRUD.Rows)
            {
                listCRUD.Add(new ItemCRUD
                {
                    Id = Convert.ToInt64(dr["ID"].ToString()),
                    Nome = dr["Nome"].ToString(),
                    Init = Convert.ToInt64(dr["Init"].ToString()),
                    Hp = Convert.ToInt64(dr["PV"].ToString()),
                    Ca = Convert.ToInt64(dr["CA"].ToString())
                });
            }

            List<ItemCRUD> listAlterada = new List<ItemCRUD>();

            foreach (ItemCRUD item in listCRUD)
            {
                if (item.Id == itemIn.Id)
                {
                    item.Nome = itemIn.Nome;
                    item.Hp = itemIn.Hp;
                    item.Init = itemIn.Init;
                    item.Ca = itemIn.Ca;
                    _out = true;
                }
                listAlterada.Add(item);
            }

            if (_out)
            {
                return listAlterada;
            }
            else
            {
                return listCRUD;
            }
        }
        #endregion

        #region Delete
        public DataTable DeleteTracker(DataTable dtCRUD, ItemCRUD item)
        {

            dtCRUD.Columns["Pontos de Vida"].ColumnName = "PV";
            dtCRUD.Columns["Classe de Armadura"].ColumnName = "CA";
            dtCRUD.Columns["Iniciativa"].ColumnName = "Init";

            listCRUD = PreencheListaDtDelete(dtCRUD, item.Id);
            dtCRUD = new DataTable();

            DataColumn column;

            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "ID"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Nome"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Init"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "PV"
            };
            dtCRUD.Columns.Add(column);

            column = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "CA"
            };
            dtCRUD.Columns.Add(column);

            foreach (ItemCRUD itemL in listCRUD)
            {
                DataRow linha = dtCRUD.NewRow();
                linha["ID"] = itemL.Id.ToString();
                linha["Nome"] = itemL.Nome;
                linha["Init"] = itemL.Init.ToString();
                linha["PV"] = itemL.Hp.ToString();
                linha["CA"] = itemL.Ca.ToString();
                dtCRUD.Rows.Add(linha);
            }

            if (dtCRUD.Columns.Contains("PV") || dtCRUD.Columns.Contains("CA") || dtCRUD.Columns.Contains("Init"))
            {
                dtCRUD.Columns["PV"].ColumnName = "Pontos de Vida";
                dtCRUD.Columns["CA"].ColumnName = "Classe de Armadura";
                dtCRUD.Columns["Init"].ColumnName = "Iniciativa";
            }

            return dtCRUD;
        }

        private List<ItemCRUD> PreencheListaDtDelete(DataTable dtCRUD, Int64 Id)
        {
            listCRUD.Clear();

            foreach (DataRow dr in dtCRUD.Rows)
            {
                listCRUD.Add(new ItemCRUD
                {
                    Id = Convert.ToInt64(dr["ID"].ToString()),
                    Nome = dr["Nome"].ToString(),
                    Init = Convert.ToInt64(dr["Init"].ToString()),
                    Hp = Convert.ToInt64(dr["PV"].ToString()),
                    Ca = Convert.ToInt64(dr["CA"].ToString())
                });
            }

            foreach (ItemCRUD itemCRUD in listCRUD)
            {
                if (itemCRUD.Id == Id)
                {
                    listCRUD.Remove(itemCRUD);                    
                }
                if(listCRUD.Count == 0)
                {
                    break;
                }
            }

            return listCRUD;
        }
        #endregion


    }
}
