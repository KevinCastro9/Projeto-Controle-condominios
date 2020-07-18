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
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
            login login = new login();
            string salvarCargos = "";
            int i = 1;
            login.envio = "teste";
            

            while (login.envio != "")
            {
                login.envio = "";
                login.selectCargos();
                salvarCargos += "|" + login.envio;
                i++;
            }
            //string[] cargos = salvarCargos.Split((char)'|');
            //int testee = cargos.Count();
            //for (int x = 0; x <= testee - 1; x++)
            //{
            //    if (cargos[x] != "")
            //    {
            //        cmbCargo.Items.Add(cargos[x]);
            //    }

            //}
            login.selectCargos();
            int con = login.tem31.Count();
            //string[] cargos = {con};
            //for (int a = 0; a <= con; a++)
            //{

            //    cargos[a] = login.tem31[a];
            //}

            int testee = login.tem31.Count();
            for (int x = 0; x <= testee - 1; x++)
            {
                if (login.tem31[x] != "" && login.tem31[x] != null)
                {
                    cmbCargo.Items.Add(login.tem31[x]);
                }

            }
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            string men;
            string val = TxtCPF.Text;
            if (val.Length == 11 && CPF.IsCpf(val))
            {
                login login = new login();
                login.selectUsuario(TxtCPF.Text);
                if (login.tem45 == true)
                {
                    MessageBox.Show("Usuario Já cadastrado!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Por gentileza preencha o campo Nome!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (cmbCargo.Text == "")
                    {
                        MessageBox.Show("Por gentileza preencha o campo Cargo!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (txtLogin.Text == "")
                    {
                        MessageBox.Show("Por gentileza preencha o campo Login!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (txtSenha.Text == "")
                    {
                        MessageBox.Show("Por gentileza preencha o campo Senha!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (txtNome.Text != "" && cmbCargo.Text != "" && txtLogin.Text != "" && txtSenha.Text != "")
                    {

                        login.selectCodCargo(cmbCargo.Text);
                        int codCargo = login.tem44;
                        login.selectCPFFuncionario(TxtCPF.Text);
                        if (login.tem37 == true)
                        {
                            login.cadastrarUsuario(txtLogin.Text, txtSenha.Text, txtNome.Text, codCargo, txtAssinatura.Text, TxtCPF.Text);
                            if (login.tem20 = true)
                            {
                                MessageBox.Show("Usuario cadastrado com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                MessageBox.Show("Erro ao cadastrar Usuario, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            txtLogin.Text = "";
                            txtSenha.Text = "";
                            txtNome.Text = "";
                            cmbCargo.Text = "";
                            txtAssinatura.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Funcionario ainda não cadastrado !!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }




            }
            else
            {
                MessageBox.Show("CPF inválido !!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
    }
}
