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
    public partial class CadastroDepartamento : Form
    {
        public CadastroDepartamento()
        {
            InitializeComponent();
            cmbEstadoTele.Text = "11";
            TxtTelefone.Text = "000000000";
            for (int o = 11; o <= 99; o++)
            {
                cmbEstadoTele.Items.Add(o);
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
            if(TxtNomeDepart.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Nome Departamento!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            if (cmbEstadoTele.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo de DDD!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtTelefone.Text == "" || TxtTelefone.Text.Length != 9)
            {
                MessageBox.Show("Por gentileza preencha o campo Telefone!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(txtCargo.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo de Cargo!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(TxtNomeDepart.Text != "" && txtCargo.Text != "")
            {
                login login = new login();
                login.selectCodDepar(TxtNomeDepart.Text);
                int codDepartamento2 = login.tem47;
                login.selectCargosDep(txtCargo.Text, codDepartamento2);

                if (login.tem48 == true || codDepartamento2 == 0)
                {
                    if (codDepartamento2 == 0)
                    {
                        MessageBox.Show("Departamento não cadastrado ainda!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cargo já cadastrado!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                else
                {
                    if (TxtNomeDepart.Text != "" && cmbEstadoTele.Text != "" && TxtTelefone.Text != "" && txtCargo.Text != "")
                    {
                        
                        login.selectCodDepar(TxtNomeDepart.Text);
                        int codDepartamento = login.tem47;
                        //  login.buscarCodCargos();
                        // int codDepartamento = login.tem10;
                        if (codDepartamento != 0)
                        {
                            login.cadastrarCargo(txtCargo.Text, codDepartamento);
                            txtCargo.Text = "";
                            MessageBox.Show("Cargo Cadastrado com sucesso!!", "Cargo Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }


                    }
                }
            }
            
           
                
            
            

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TxtNomeDepart.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Nome Departamento!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (cmbEstadoTele.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo de DDD!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtTelefone.Text == "" || TxtTelefone.Text.Length != 9)
            {
                MessageBox.Show("Por gentileza preencha o campo Telefone!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (TxtNomeDepart.Text != "" && TxtTelefone.Text != "" && cmbEstadoTele.Text != "")
            {
                login login = new login();
                //   login.buscarCodCargos();
                //     int codDepartamento2 = login.tem10;
                string telefone = TxtTelefone.Text;
                string ddd = cmbEstadoTele.Text;

                string telefone2 = ddd + telefone;
                //  int telefone3 = 0;
                login.cadastrarDepartamento(TxtNomeDepart.Text, telefone2);
                //int codDepartamento3 = codDepartamento2 + 1;
                //login.updateCodCargos(codDepartamento3);



                MessageBox.Show("Departamento Cadastrado com sucesso, por gentileza cadastre os Cargos!!", "Departamento Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
            }
           
        }

        private void CmbEstadoTele_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtCargo.Text = "";
            TxtNomeDepart.Text = "";
            TxtTelefone.Text = "";
            cmbEstadoTele.Text = "";
        }
    }
}
