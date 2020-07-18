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
    public partial class CadastroVisitantes : Form
    {
        public CadastroVisitantes()
        {
            InitializeComponent();
            //txtCPF.Text = "000000000/00";
            //txtRG.Text = "00.000.000-0";
            //txtTele.Text = "000000000";
            cmbEstadoTele.Text = "11";
            label7.Visible = false;
            label8.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;

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
            int i = 1;
            CmbSexo.Items.Add("Masculino");
            CmbSexo.Items.Add("Feminino");
            CmbSexo.Items.Add("Indefinido");

            login.selectNumeroApt();
            int numeroApt = login.tem17;
            for (int j = 0; j <= numeroApt; j++)
            {
                if (j == 0)
                {
                    cmbApt.Items.Add("T");
                }
                else
                {
                    cmbApt.Items.Add(j);
                }
            }
            login.tem16 = "teste";
            while (login.tem16 != "")
            {
                login.tem16 = "";
                login.selectBlocos(i);
                if (login.tem16 != "")
                {
                    cmbBloco.Items.Add(login.tem16);
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
            if (TxtNome.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
            if (txtCPF.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
            if (txtRG.Text == "")
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }
            if (CmbSexo.Text =="")
            {
                label15.Visible = true;
            }
            else
            {
                label15.Visible = false;
            }
            if (cmbDia.Text =="" || CmbMes.Text == "" || cmbAno.Text == "")
            {
                label16.Visible = true;
            }
            else
            {
                label16.Visible = false;
            }
           
            if (cmbEstadoTele.Text == "" || txtTele.Text == "")
            {
                label17.Visible = true;
            }
            else
            {
                label17.Visible = false;
            }
            
            if (cmbBloco.Text == "")
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }
            if (cmbApt.Text == "")
            {
                label19.Visible = true;
            }
            else
            {
                label19.Visible = false;
            }
            string men;
            string val = txtCPF.Text;

            if (val.Length == 11 && CPF.IsCpf(val))
            {
                login login = new login();
                login.SelectCPFVISI(val);
                if (login.tem42 == true)
                {
                    MessageBox.Show("O Visitante já esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (TxtNome.Text != "" && txtCPF.Text != "" && txtRG.Text != "" && CmbSexo.Text != "" && cmbDia.Text != "" && CmbMes.Text != "" && cmbAno.Text != "" && cmbEstadoTele.Text != "" && txtTele.Text != "" && cmbBloco.Text != "" && cmbApt.Text != "")
                    {


                        string dataNasc = cmbAno.Text + CmbMes.Text + cmbDia.Text;
                        //     string dataNasc = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                        login.selectcodbloco(cmbBloco.Text);
                        int codBloco = login.tem19;
                        //string interfone = codBloco.ToString() + cmbApt.Text;
                        string sexo = "";
                        if (CmbSexo.Text == "Masculino")
                        {
                            sexo = "M";
                        }
                        else
                        {
                            if (CmbSexo.Text == "Feminino")
                            {
                                sexo = "F";
                            }
                            else
                            {
                                sexo = "I";
                            }
                        }


                        string tele1 = cmbEstadoTele.Text + txtTele.Text;

                        login.cadastrarVisitante(TxtNome.Text, txtCPF.Text, txtRG.Text, sexo, dataNasc, tele1, codBloco, cmbApt.Text);
                        if (login.tem21 = true)
                        {
                            MessageBox.Show("Visitante Cadastrado com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar Visitante, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        TxtNome.Text = "";
                        txtCPF.Text = "";
                        txtRG.Text = "";
                        CmbSexo.Text = "";
                        cmbDia.Text = "";
                        CmbMes.Text = "";
                        cmbAno.Text = "";
                        txtTele.Text = "";
                        cmbBloco.Text = "";
                        cmbApt.Text = "";

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
                txtCPF.Text = "";
            }
           
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }
    }
}
