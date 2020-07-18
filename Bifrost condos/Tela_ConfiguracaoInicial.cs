using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bifrost_condos
{
    public partial class Tela_ConfiguracaoInicial : Form
    {
        public Tela_ConfiguracaoInicial()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TxtRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntCadastrar_Click(object sender, EventArgs e)
        {
            if (TxtNomeCondominio.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Nome!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtEnderecoCondominio.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Endereço!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtNDeBlocos.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Numero de Blocos!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtNDeApts.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Numero de Apartamento por Blocos!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtNomeAdm.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Nome Admistradora!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtNumeroCasa.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Numero Predio!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtNomeCondominio.Text != "" && TxtEnderecoCondominio.Text != "" && TxtNDeBlocos.Text != "" && TxtNDeApts.Text != "" && TxtNomeAdm.Text != "" && txtNumeroCasa.Text != "")
            {
                try
                {
                    login login = new login();
                    string endereco = TxtEnderecoCondominio + " Nº " + txtNumeroCasa;
                    login.ConfigInicial(TxtNomeCondominio.Text, endereco, TxtNDeBlocos.Text, TxtNDeApts.Text, TxtNomeAdm.Text);
                    MessageBox.Show(" Cadastro Realizado com Sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    login.AlterarPrimeiroAcesso();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(" Não foi possivel realizar o Cadastro!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                TxtNomeCondominio.Text = "";
                TxtEnderecoCondominio.Text = "";
                TxtNDeBlocos.Text = "";
                TxtNDeApts.Text = "";
                TxtNomeAdm.Text = "";

                ConfiguracaoBlocos frmp = new ConfiguracaoBlocos();
                frmp.Show();
                this.Visible = false;
            }
           


        }

        private void TxtNDeApts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
