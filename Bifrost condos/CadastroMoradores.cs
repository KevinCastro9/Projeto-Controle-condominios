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
    public partial class CadastroMoradores : Form
    {
        public CadastroMoradores()
        {
            InitializeComponent();
            //TxtCPF.Text = "00000000000";
            //txtRG.Text = "00.000.000-0";
            //TxtTelefone.Text = "000000000";
            //cmbEstadoTele.Text = "11";
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label20.Visible = false;
            label19.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            bool cadErro = false;

            for (int o = 11; o <= 99; o++)
            {
                cmbEstadoTele.Items.Add(o);
            }

            string diadia = System.DateTime.Now.Day + "";
            if (diadia.Length == 1)
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
                CmbMes.Text = "0" + dataac.Substring(3, 1);
            }

            cmbAno.Text = dataac.Substring(6, 4);


            login login = new login();

            CmbSexo.Items.Add("Masculino");
            CmbSexo.Items.Add("Feminino");
            CmbSexo.Items.Add("Indefinido");
            int i = 1;
            login.tem16 = "teste";
            login.selectNumeroApt();
            int numeroApt = login.tem17;
            for (int j = 0; j <= numeroApt; j++)
            {
                if (j == 0)
                {
                    cmbApt.Items.Add("0");
                }
                else
                {
                    cmbApt.Items.Add(j);
                }
            }
            while (login.tem16 != "")
            {
                login.tem16 = "";
                login.selectBlocos(i);
                if (login.tem16 != "")
                {
                    cmbBlocos.Items.Add(login.tem16);
                }

                i++;
            }

            for (int c = 1; c <= 31; c++)
            {
                if (c.ToString().Length == 1)
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
            //for (int y = 1900; y <= 2020; y++)
            //{
            //    cmbAno.Items.Add(y);
            //}


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
            if (txtNome.Text == "")
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
            if (TxtCPF.Text == "")
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
            if (txtRG.Text == "")
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
            if (CmbSexo.Text == "")
            {
                label17.Visible = true;
            }
            else
            {
                label17.Visible = false;
            }
            if (cmbDia.Text == "" || CmbMes.Text == "" || cmbAno.Text == "")
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }
            
            if (cmbEstadoTele.Text == "" || TxtTelefone.Text == "")
            {
                label20.Visible = true;
            }
            else
            {
                label20.Visible = false;
            }
            
            if (cmbBlocos.Text == "")
            {
                label19.Visible = true;
            }
            else
            {
                label19.Visible = false;
            }
            if (cmbApt.Text == "")
            {
                label21.Visible = true;
            }
            else
            {
                label21.Visible = false;
            }
            if (txtGaragem.Text == "")
            {
                label22.Visible = true;
            }
            else
            {
                label22.Visible = false;
            }
            if (txtEmail.Text == "")
            {
                label23.Visible = true;
            }
            else
            {
                label23.Visible = false;
            }
            string confirmaEmail = txtEmail.Text;
            string confirmaEmail2 = confirmaEmail.ToUpper();
            bool valor = confirmaEmail2.Contains("@") && confirmaEmail2.Contains(".COM");
            if (valor == true)
            {
               
            }
            else
            {
                label23.Visible = true;
                MessageBox.Show("Por Gentileza Digite um e-mail válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            string men;
            string val = TxtCPF.Text;
            
            if (val.Length == 11 && CPF.IsCpf(val))
            {
                login login = new login();
                login.selectCPFMorador(val);
                if (login.tem35 == true)
                {
                    MessageBox.Show("O Morador já esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtNome.Text != "" && TxtCPF.Text != "" && txtRG.Text != "" && CmbSexo.Text != "" && cmbDia.Text != "" && CmbMes.Text != "" && cmbAno.Text != "" && cmbEstadoTele.Text != "" && TxtTelefone.Text != "" && cmbBlocos.Text != "" && cmbApt.Text != "" && txtGaragem.Text != "" && txtEmail.Text != "")
                    {
                        bool cadErro = false;
                        //  login login = new login();
                        login.selectcodbloco(cmbBlocos.Text);
                        int codBloco = login.tem19;
                        string interfone = codBloco.ToString() + cmbApt.Text;
                        // string datanasc = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                        string datanasc = cmbAno.Text + CmbMes.Text + cmbDia.Text;
                        string CPF = TxtCPF.Text.Replace("/", "");
                        string sexo = "";
                        switch (CmbSexo.Text)
                        {
                            case "Masculino":
                                sexo = "M";
                                break;
                            case "Feminino":
                                sexo = "F";
                                break;
                            case "Indefinido":
                                sexo = "I";
                                break;
                            default:

                                break;
                        }
                        login.selectcodbloco(cmbBlocos.Text);
                        int codBlocoMorador = login.tem19;
                        string tele = cmbEstadoTele.Text + TxtTelefone.Text;
                        login.cadastrarMoradores(txtNome.Text, CPF, txtRG.Text, sexo, datanasc, tele, codBlocoMorador, cmbApt.Text, interfone, txtGaragem.Text, txtEmail.Text);
                        if (login.tem18 == true)
                        {
                            MessageBox.Show("Morador Cadastrado com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar Morador!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cadErro = true;

                        }

                        if (cadErro == false)
                        {
                            txtNome.Text = "";
                            TxtCPF.Text = "";
                            txtRG.Text = "";
                            CmbSexo.Text = "";
                            cmbDia.Text = "";
                            CmbMes.Text = "";
                            cmbAno.Text = "";
                            TxtTelefone.Text = "";
                            cmbBlocos.Text = "";
                            cmbApt.Text = "";
                            txtGaragem.Text = "";
                            txtEmail.Text = "";
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
                label15.Visible = true;
                MessageBox.Show("Por Gentileza Digite um CPF válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCPF.Text = "";
            }
           

            

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TxtRG_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
