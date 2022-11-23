using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venda.Models;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class FrmClientes : Form

    {
        Cidade ci;
        Cliente cl;
        public FrmClientes()
        {
            InitializeComponent();
        }

        void limpaControles()
        {
            txtID.Text = "";
            txtNome.Clear();
            cboCidade.SelectedIndex = -1;
            txtUF.Text = "";
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            cboCidade.DataSource = ci.Consultar();
            cboCidade.DisplayMember = "Nome";
            cboCidade.ValueMember = "id";

            limpaControles();
            carregarGrid("");

            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;
        }

        private void BtnAlterar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;
            cl = new Cliente()
            {
                ID = int.Parse(txtID.Text),
                Nome = txtNome.Text,
                idCidade = (int)cboCidade.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked

            };
            cl.Alterar();
            limpaControles();
            carregarGrid("");
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                txtID.Text = dgvClientes.CurrentRow.Cells["id"].Value.ToString();
                txtNome.Text = dgvClientes.CurrentRow.Cells["nome"].Value.ToString();
                cboCidade.Text = dgvClientes.CurrentRow.Cells["cidade"].Value.ToString();
                txtUF.Text = dgvClientes.CurrentRow.Cells["uf"].Value.ToString();
                chkVenda.Text = dgvClientes.CurrentRow.Cells["venda"].ToString();
                mskCPF.Text = dgvClientes.CurrentRow.Cells["cpf"].Value.ToString();
                dtpDataNasc.Text = dgvClientes.CurrentRow.Cells["dataNasc"].Value.ToString();
                txtRenda.Text = dgvClientes.CurrentRow.Cells["renda"].Value.ToString();
                picFoto.Text = dgvClientes.CurrentRow.Cells["foto"].Value.ToString();

            }
        }

        private void picFoto_Click_1(object sender, EventArgs e)
        {
            ofdArquivo.InitialDirectory = "D:/fotos/cliente/";
            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();
            picFoto.ImageLocation = ofdArquivo.FileName;
        }

        private void BtnIncluir_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;
            cl = new Cliente()
            {
                Nome = txtNome.Text,
                idCidade = (int)cboCidade.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.Parse(txtRenda.Text),
                cpf = mskCPF.Text,
                foto = picFOTO.ImageLocation,
                venda = chkVenda.Checked
            };
            cl.Incluir();
            limpaControles();
            carregarGrid("");
        }

        private void cboCidade_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCidade.SelectedIndex == -1)
            {
                DataRowView reg = (DataRowView)cboCidade.SelectedItem;
                txtUF.Text = reg["uf"].ToString();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            if (MessageBox.Show("Deseja excluir o cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente()
                {
                    ID = int.Parse(txtID.Text)
                };

                cl.Excluir();

                limpaControles();
                carregarGrid("");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpaControles();
            carregarGrid("");
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
