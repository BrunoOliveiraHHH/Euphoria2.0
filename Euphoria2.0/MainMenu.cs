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
        private CalculoDeExperiencia calculo = new CalculoDeExperiencia();
        private Experiencia experiencia = new Experiencia();

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

        private void calculoMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            LimpaTexto();
            IniciaDtg();
        }

        private void btnCalcularPlayer_Click(object sender, EventArgs e)
        {
            lblTotalDividido.Text = calculo.CalculoPlayer(txtTotalXP.Text.ToString(), txtQtdPlayer.Text.ToString());
        }

        private void btnCacular_Click(object sender, EventArgs e)
        {
            lblTotal.Text = calculo.CalculoXP(txtQtdXP.Text.ToString(), txtQtdMon.Text.ToString());
        }

        private void btnCalcularEncontro_Click(object sender, EventArgs e)
        {
           lblDificuldade.Text = calculo.CalcularEncontro(txtTotalEncontro.Text.ToString(), txtMediaNvl.Text.ToString());
        }

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

        private void modPorNDSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //dtgFront.DataSource = modificadores.preencheDtg();
        }

        private void modPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //dtgFront.DataSource = modificadores.preencheDtg();
        }

        private void modPorHabSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //dtgFront.DataSource = modificadores.preencheDtg();
        }

        private void gemasSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //dtgFront.DataSource = tesouro.preencheDtg();
        }

        private void objetosSubMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //dtgFront.DataSource = tesouro.preencheDtg();
        }
    }
}
