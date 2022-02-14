using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euphoria2._0
{
    public partial class MainMenu : Form
    {
        #region Members
        private CalculoDeExperiencia calculo = new CalculoDeExperiencia();
        private Experiencia experiencia = new Experiencia();
        private Modificadores modificadores = new Modificadores();
        private Tesouros tesouro = new Tesouros();
        #endregion

        #region Methods
        public MainMenu()
        {
            InitializeComponent();
            InicializarTela();
        }

        private void InicializarTela()
        {
            panel1.Visible = false;            
        }

        private void IniciaDtg()
        {
            DataTable dt = new DataTable();
            DataColumn column;
            String Linha = "Utilizar os Menus 'Experência','Modificadores' e 'Tesouros', o Resultado irá aparecer aqui";

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Info";
            dt.Columns.Add(column);

            DataRow linha = dt.NewRow();
            linha["Info"] = Linha;
            dt.Rows.Add(linha);

            if (dtgFront.DataSource == null)
            {
                dtgFront.DataSource = dt;                
            }
        }

        private void LimpaTexto()
        {
            lblTotal.Text = "";
            lblTotalDividido.Text = "";
            lblDificuldade.Text = "";
            txtTotalEncontro.Text = "";
            txtMediaNvl.Text = "";
            txtTotalXP.Text = "";
            txtQtdPlayer.Text = "";
            txtQtdXP.Text = "";
            txtQtdMon.Text = "";
            dtgFront.DataSource = null;
        }

        private void homeMenu_Click(object sender, EventArgs e)
        {
            InicializarTela();
            LimpaTexto();
        }
        #endregion

        #region Calculo de XP
        private void calculoMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            LimpaTexto();
            IniciaDtg();
        }

        private void btnCalcularPlayer_Click(object sender, EventArgs e)
        {
            if (lblTotalDividido.Text.Length > 0)
            {
                lblTotalDividido.Text = String.Empty;
            }

            lblTotalDividido.Text = calculo.CalculoPlayer(txtTotalXP.Text.ToString(), txtQtdPlayer.Text.ToString());
        }

        private void btnCacular_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                lblTotal.Text = String.Empty;
            }
            lblTotal.Text = calculo.CalculoXP(txtQtdXP.Text.ToString(), txtQtdMon.Text.ToString());
        }

        private void btnCalcularEncontro_Click(object sender, EventArgs e)
        {
            if (lblDificuldade.Text.Length > 0)
            {
                lblDificuldade.Text = String.Empty;
            }
           lblDificuldade.Text = calculo.CalcularEncontro(txtTotalEncontro.Text.ToString(), txtMediaNvl.Text.ToString());
        }
        #endregion

        #region Experiencia
        private void expPorNDSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(1);
        }

        private void expPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(2);
        }

        private void expPorDifSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(3);
        }

        private void expPorDiaSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(4);
        }


        private void multiExpSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(5);            
        }
        #endregion

        #region Modificadores
        private void modPorNDSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = modificadores.preencheDtg(1);
        }

        private void modPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = modificadores.preencheDtg(2);
        }

        private void modPorHabSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = modificadores.preencheDtg(3);
        }
        #endregion

        #region Tesouros

        #region Gemas
        private void g10PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(1);
        }

        private void g50PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(2);
        }

        private void g100PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(3);
        }

        private void g500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(4);
        }

        private void g1000PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(5);
        }

        private void g5000PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(6);
        }
        #endregion

        #region Obejtos de Arte
        private void oDe25PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(1);
        }

        private void oDe250PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(2);
        }

        private void oDe750PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(3);
        }

        private void oDe2500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(4);
        }

        private void oDe7500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(5);
        }
        #endregion

        #endregion

        private void txtQtdXP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
