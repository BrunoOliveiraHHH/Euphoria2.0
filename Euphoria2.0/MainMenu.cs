using System;
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
        private readonly Armadilhas armadilhas = new Armadilhas();
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
            panel2.Visible = false;
        }

        private void IniciaDtg()
        {
            if (dtgFront.DataSource == null)
            {
                dtgFront.DataSource = experiencia.PreencheDtg(5); ;
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
            panel2.Visible = false;
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
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = experiencia.PreencheDtg(1);
        }

        private void ExpPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = experiencia.PreencheDtg(2);
        }

        private void ExpPorDifSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = experiencia.PreencheDtg(3);
        }

        private void ExpPorDiaSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = experiencia.PreencheDtg(4);
        }


        private void MultiExpSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = experiencia.PreencheDtg(5);
        }
        #endregion

        #region Modificadores
        private void ModPorNDSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = modificadores.PreencheDtg(1);
        }

        private void ModPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = modificadores.PreencheDtg(2);
        }

        private void ModPorHabSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = modificadores.PreencheDtg(3);
        }
        #endregion

        #region Tesouros

        #region Gemas
        private void G10PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(1);
        }

        private void G50PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(2);
        }

        private void G100PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(3);
        }

        private void G500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(4);
        }

        private void G1000PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(5);
        }

        private void G5000PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(6);
        }
        #endregion

        #region Obejtos de Arte
        private void ODe25PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(1);
        }

        private void ODe250PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(2);
        }

        private void ODe750PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(3);
        }

        private void ODe2500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(4);
        }

        private void ODe7500PoSubMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(5);
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

        #region Armadilhas
        private void ArmadilhasMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = armadilhas.PreencheDtg();
        }
        #endregion
    }
}
