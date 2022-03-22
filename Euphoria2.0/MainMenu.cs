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
        private readonly CalculoDeExperiencia calculo = new CalculoDeExperiencia();
        private readonly Experiencia experiencia = new Experiencia();
        private readonly Modificadores modificadores = new Modificadores();
        private readonly Tesouros tesouro = new Tesouros();
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

            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Info"
            };
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

        private void HomeMenu_Click(object sender, EventArgs e)
        {
            InicializarTela();
            LimpaTexto();
        }
        #endregion

        #region Calculo de XP
        private void CalculoMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            LimpaTexto();
            IniciaDtg();
        }

        private void BtnCalcularPlayer_Click(object sender, EventArgs e)
        {
            if (lblTotalDividido.Text.Length > 0)
            {
                lblTotalDividido.Text = String.Empty;
            }

            lblTotalDividido.Text = calculo.CalculoPlayer(txtTotalXP.Text.ToString(), txtQtdPlayer.Text.ToString());
        }

        private void BtnCacular_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Length > 0)
            {
                lblTotal.Text = String.Empty;
            }
            lblTotal.Text = calculo.CalculoXP(txtQtdXP.Text.ToString(), txtQtdMon.Text.ToString());
        }

        private void BtnCalcularEncontro_Click(object sender, EventArgs e)
        {
            if (lblDificuldade.Text.Length > 0)
            {
                lblDificuldade.Text = String.Empty;
            }
           lblDificuldade.Text = calculo.CalcularEncontro(txtTotalEncontro.Text.ToString(), txtMediaNvl.Text.ToString(), txtQntdJogadoresEncounter.Text.ToString());
        }
        #endregion

        #region Experiencia
        private void ExpPorNDSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(1);
        }

        private void ExpPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(2);
        }

        private void ExpPorDifSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(3);
        }

        private void ExpPorDiaSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(4);
        }


        private void MultiExpSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = experiencia.preencheDtg(5);            
        }
        #endregion

        #region Modificadores
        private void ModPorNDSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = modificadores.preencheDtg(1);
        }

        private void ModPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = modificadores.preencheDtg(2);
        }

        private void ModPorHabSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = modificadores.preencheDtg(3);
        }
        #endregion

        #region Tesouros

        #region Gemas
        private void G10PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(1);
        }

        private void G50PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(2);
        }

        private void G100PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(3);
        }

        private void G500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(4);
        }

        private void G1000PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(5);
        }

        private void G5000PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgGemas(6);
        }
        #endregion

        #region Obejtos de Arte
        private void ODe25PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(1);
        }

        private void ODe250PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(2);
        }

        private void ODe750PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(3);
        }

        private void ODe2500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(4);
        }

        private void ODe7500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dtgFront.DataSource = tesouro.preencheDtgObjetos(5);
        }
        #endregion

        #endregion

        private void TxtQtdXP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
