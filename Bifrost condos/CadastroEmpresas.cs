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
    public partial class CadastroEmpresas : Form
    {
        public CadastroEmpresas()
        {
            InitializeComponent();
            
            label14.Visible = false;
            label5.Visible = false;
            label13.Visible = false;
            label15.Visible = false;
            label16.Visible = false;

            //TxtCNPJ.Text = "00.000.000/0000-00";
            //txtCPF.Text = "000000000/00";
            //txtTeleEmpresa.Text = "000000000";
            //txtTeleFuncio.Text = "000000000";


            //for (int o = 11; o <= 99; o++)
            //{
            //    cmbEstadoTele.Items.Add(o);
            //    cmbTele1.Items.Add(o);
            //}
            //cmbTele1.Text = "11";
            //cmbEstadoTele.Text = "11";
            //string dataac = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string diadia = System.DateTime.Now.Day + "";
            if(diadia.Length == 1)
            {
                diadia = "0" + diadia;
            }
            string mesmes = System.DateTime.Now.Month + "";
            if (mesmes.Length == 1)
            {
                mesmes = "0" + mesmes;
            }
            string anoano = System.DateTime.Now.Year + "";
            string dataac = diadia + "/" + mesmes + "/" + anoano;
            cmbDia.Text = dataac.Substring(0, 2);
            string mes = mesmes;
            if (mes.Length > 1)
            {
                CmbMes.Text = dataac.Substring(3, 2);
            }
            else
            {
                CmbMes.Text = "0" + dataac.Substring(3,1);
            }
           
            cmbAno.Text = dataac.Substring(6, 4);


            for (int c = 1; c <= 31; c++)
            {
                if(c.ToString().Length == 1)
                {
                    cmbDia.Items.Add("0" + c);
                }
                else
                {
                    cmbDia.Items.Add(c);
                }
                
            }

            for (int h = 1; h <= 12; h++)
            {

                if (h < 10)
                {
                    CmbMes.Items.Add("0" + h);
                }
                else
                {
                    CmbMes.Items.Add(h);
                }

            }
            string ANot = dataac.Substring(6, 4);
            int ultAno = Convert.ToInt32(ANot);

            for (int y = 1900; y <= ultAno; y++)
            {
                cmbAno.Items.Add(y);
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

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
           
            if (txtNomeFuncionario.Text == "")
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
            if (txtCPF.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            if (txtMotivo.Text == "")
            {
                label13.Visible = true;
            }
            else
            {
                label13.Visible = false;
            }
            if (cmbTele1.Text == "" || txtTeleFuncio.Text == "")
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
            
            if (cmbDia.Text == "" || CmbMes.Text == "" || cmbAno.Text == "")
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
           
            if ( TxtCNPJ.Text != "" && txtNomeFuncionario.Text != "" && txtCPF.Text != "" && txtMotivo.Text != "" && cmbTele1.Text != "" && txtTeleFuncio.Text != "" && cmbDia.Text != "" && CmbMes.Text != "" && cmbAno.Text != "")
            {
                login login = new login();
               // string data = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                string data = cmbAno.Text + CmbMes.Text + cmbDia.Text;
                string telef = cmbTele1.Text + txtTeleFuncio.Text;
                login.cadastrarServicos(TxtCNPJ.Text, txtNomeFuncionario.Text, txtCPF.Text, txtMotivo.Text, data, telef);
                if (login.tem11 = true)
                {
                    MessageBox.Show("Serviço Cadastrado com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Serviço, tente novamente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                TxtNomeEmpresa.Text = "";
                TxtCNPJ.Text = "";
                txtNomeFuncionario.Text = "";
                txtCPF.Text = "";
                txtMotivo.Text = "";
                cmbDia.Text = "";
                CmbMes.Text = "";
                cmbAno.Text = "";
                txtTeleFuncio.Text = "";
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //if (TxtCNPJ.Text != "")
            //{
            //    login login = new login();
            //    login.buscarNomeEmpresa(TxtCNPJ.Text);
            //    login.buscarTelefoneDaEmpresa(TxtCNPJ.Text);
            //    if (login.tem13 == "true" & login.tem15 == "true")
            //    {
            //        MessageBox.Show("Empresa ainda não cadastrada, Por gentileza realize o cadastro!!", "Empresa não localizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        TxtNomeEmpresa.Text = login.tem12;
            //  //      txtTeleEmpresa.Text = login.tem14;
            //        MessageBox.Show("Empresa cadastrada, Por gentileza realize o cadastro do novo Serviço!!", "Empresa cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por gentileza preencha o campo CNPJ!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }
    }
}
