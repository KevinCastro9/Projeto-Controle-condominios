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
    public partial class EmpresasCadastros : Form
    {
        public EmpresasCadastros()
        {
            InitializeComponent();
            label24.Visible = false;
            label25.Visible = false;
            label5.Visible = false;
            label10.Visible = false;
            label26.Visible = false;            
            label13.Visible = false;
            label15.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label16.Visible = false;
            label32.Visible = false;

            for (int o = 11; o <= 99; o++)
            {
                cmbEstadoTele.Items.Add(o);
                
            }
        }

        private void TxtNomeEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (TxtCNPJ.Text == "")
            {
                label25.Visible = true;
            }
            else
            {
                label25.Visible = false;
            }
            if (TxtNomeEmpresa.Text == "")
            {
                label24.Visible = true;
            }
            else
            {
                label24.Visible = false;
            }

            if (txtRazao.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            if (txtNomeFantasia.Text == "")
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }
            if (txtEmail.Text == "")
            {
                label26.Visible = true;
            }
            else
            {
                label26.Visible = false;
            }
            if (txtEndereco.Text == "")
            {
                label13.Visible = true;
            }
            else
            {
                label13.Visible = false;
            }
            if (txtNumero.Text == "")
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
           
            if (txtBairro.Text == "")
            {
                label30.Visible = true;
            }
            else
            {
                label30.Visible = false;
            }
            if (txtCep.Text == "")
            {
                label31.Visible = true;
            }
            else
            {
                label31.Visible = false;
            }
            if (txtPais.Text == "")
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
            if (cmbEstadoTele.Text == "" || txtTelefone.Text == "")
            {
                label32.Visible = true;
            }
            else
            {
                label32.Visible = false;
            }
            string confirmaEmail = txtEmail.Text;
            string confirmaEmail2 = confirmaEmail.ToUpper();
            bool valor = confirmaEmail2.Contains("@") && confirmaEmail2.Contains(".COM");
            if (valor == true)
            {

            }
            else
            {
                label26.Visible = true;
                MessageBox.Show("Por Gentileza Digite um e-mail válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            login login = new login();

           

            if (login.ValidaCNPJ(TxtCNPJ.Text) == true && TxtCNPJ.Text.Length == 18)
            {
                string CNPJGrava7 = TxtCNPJ.Text;
                string cnpjNovo6 = CNPJGrava7.Replace(".", "");
                string cnpjNovo5 = cnpjNovo6.Replace("/", "");
                string cnpjNovo4 = cnpjNovo5.Replace("-", "");

                login.SelectCNPJ(cnpjNovo4);
                

                if (login.tem40 == true)
                {
                    MessageBox.Show("Empresa já cadastrada !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (TxtNomeEmpresa.Text != "" && TxtCNPJ.Text != "" && txtRazao.Text != "" && txtNomeFantasia.Text != "" && txtEmail.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCep.Text != "" && txtPais.Text != "" && cmbEstadoTele.Text != "" && txtTelefone.Text != "")
                    {

                        int numero = Convert.ToInt32(txtNumero.Text);
                        string tele = cmbEstadoTele.Text + txtTelefone.Text;
                        string CNPJGrava = TxtCNPJ.Text;
                        string cnpjNovo = CNPJGrava.Replace(".", "");
                        string cnpjNovo2 = cnpjNovo.Replace("/", "");
                        string cnpjNovo3 = cnpjNovo2.Replace("-", "");



                        

                        login.cadastrarEmpresa(cnpjNovo3, TxtNomeEmpresa.Text, txtRamo.Text, txtRazao.Text, txtNomeFantasia.Text, txtCep.Text, txtEndereco.Text, numero, txtComplemento.Text, txtBairro.Text, txtPais.Text, txtEmail.Text, txtInEstadual.Text, txtInMunicipal.Text, tele);

                        if (login.tem34 = true)
                        {
                            MessageBox.Show("Empresa Cadastrada com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtBairro.Text = "";
                            txtCep.Text = "";
                            TxtCNPJ.Text = "";
                            txtComplemento.Text = "";
                            txtEmail.Text = "";
                            txtEndereco.Text = "";
                            txtInEstadual.Text = "";
                            txtInMunicipal.Text = "";
                            TxtNomeEmpresa.Text = "";
                            txtNomeFantasia.Text = "";
                            txtNumero.Text = "";
                            txtPais.Text = "";
                            txtRamo.Text = "";
                            txtRazao.Text = "";
                            txtTelefone.Text = "";
                            cmbEstadoTele.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar Empresa, tente novamente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Gentileza preencha todos os Campos Obrigatórios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

               
            }
            else
            {
                MessageBox.Show("CNPJ Inválido!", "Validador de CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
