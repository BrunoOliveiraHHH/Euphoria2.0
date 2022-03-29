using Euphoria.Dados;
using System;
using System.Data;
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
        private readonly InitTracker tracker = new InitTracker();
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
            panel3.Visible = false;
        }

        private void IniciaDtg()
        {
            if (dtgFront.DataSource == null)
            {
                dtgFront.DataSource = experiencia.PreencheDtg(5);
            }
        }

        private void PainelEstaticas()
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel1.Visible = false;
        }

        private void TxtQtdXP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
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
            panel3.Visible = false;
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
            PainelEstaticas();
            dtgArmad.DataSource = experiencia.PreencheDtg(1);
        }

        private void ExpPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = experiencia.PreencheDtg(2);
        }

        private void ExpPorDifSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = experiencia.PreencheDtg(3);
        }

        private void ExpPorDiaSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = experiencia.PreencheDtg(4);
        }


        private void MultiExpSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = experiencia.PreencheDtg(5);
        }
        #endregion

        #region Modificadores
        private void ModPorNDSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = modificadores.PreencheDtg(1);
        }

        private void ModPorNvlSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = modificadores.PreencheDtg(2);
        }

        private void ModPorHabSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = modificadores.PreencheDtg(3);
        }
        #endregion

        #region Tesouros

        #region Gemas
        private void G10PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(1);
        }

        private void G50PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(2);
        }

        private void G100PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(3);
        }

        private void G500PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(4);
        }

        private void G1000PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(5);
        }

        private void G5000PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgGemas(6);
        }
        #endregion

        #region Obejtos de Arte
        private void ODe25PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(1);
        }

        private void ODe250PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(2);
        }

        private void ODe750PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(3);
        }

        private void ODe2500PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(4);
        }

        private void ODe7500PoSubMenu_Click(object sender, EventArgs e)
        {
            PainelEstaticas();
            dtgArmad.DataSource = tesouro.PreencheDtgObjetos(5);
        }
        #endregion

        #endregion

        #region Armadilhas
        private void ArmadilhasMenu_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            dtgArmad.DataSource = armadilhas.PreencheDtg();
        }
        #endregion

        #region CRUD Init Tracker

        private Int64 ID;
        private DataTable dt;

        private void InitTrackerMenu_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

        }

        private void DtgCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt64(dtgCRUD.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dtgCRUD.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtInit.Text = dtgCRUD.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHP.Text = dtgCRUD.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAC.Text = dtgCRUD.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void LimparDados()
        {
            txtAC.Text = "";
            txtHP.Text = "";
            txtInit.Text = "";
            txtName.Text = "";
            ID = 0;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            LimparDados();
            txtName.Focus();
            ID = 0;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAC.Text != "" && txtHP.Text != "" && txtInit.Text != "" && txtName.Text != "")
            {
                ItemCRUD item = new ItemCRUD();
                item.Id = ID;
                item.Nome = txtName.Text.ToString();
                item.Init = Convert.ToInt64(txtInit.Text.ToString());
                item.Hp = Convert.ToInt64(txtHP.Text.ToString());
                item.Ca = Convert.ToInt64(txtAC.Text.ToString());

                dt = (DataTable)dtgCRUD.DataSource;
                dtgCRUD.DataSource = tracker.UpdateTracker(dt, item);

                LimparDados();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtAC.Text != "" && txtHP.Text != "" && txtInit.Text != "" && txtName.Text != "")
            {
                ItemCRUD item = new ItemCRUD();
                item.Nome = txtName.Text.ToString();
                item.Init = Convert.ToInt64(txtInit.Text.ToString());
                item.Hp = Convert.ToInt64(txtHP.Text.ToString());
                item.Ca = Convert.ToInt64(txtAC.Text.ToString());

                if (dtgCRUD.DataSource != null)
                {
                    dt = (DataTable)dtgCRUD.DataSource;
                    dtgCRUD.DataSource = tracker.SaveTracker(dt, item);
                }
                else
                {
                    dt = (DataTable)dtgCRUD.DataSource;
                    dtgCRUD.DataSource = tracker.SaveTracker(dt, item);
                }
                LimparDados();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                ItemCRUD item = new ItemCRUD();
                item.Id = ID;

                dt = (DataTable)dtgCRUD.DataSource;
                dtgCRUD.DataSource = tracker.DeleteTracker(dt, item);
                dt = (DataTable)dtgCRUD.DataSource;

                if (dt.Rows.Count == 0)
                {
                    dtgCRUD.DataSource = new DataTable();
                }

                LimparDados();
            }
            else
            {
                MessageBox.Show("Selecione um item da tabela.");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            dtgCRUD.DataSource = new DataTable();
            LimparDados();
        }

        #endregion

    }
}
