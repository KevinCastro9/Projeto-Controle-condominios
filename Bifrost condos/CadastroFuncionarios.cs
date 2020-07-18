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
    public partial class CadastroFuncionarios : Form
    {

        //aqui 
        public CadastroFuncionarios()
        {
            InitializeComponent();
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
           
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
            
            string salvarCargos = "";
            string salvarDepartamentos = "";

            int i = 1;
            int l = 1;
            //login.envio = "teste";
            login.envio2 = "teste";

            //while (login.envio != "")
            //{
            //    login.envio = "";            
            //    login.selectCargos(i);
            //    salvarCargos += "|" + login.envio;               
            //    i++;
            //}
            login.selectCargos();
            int con = login.tem31.Count();
            //string[] cargos = {con};
            //for (int a = 0; a <= con; a++)
            //{
               
            //    cargos[a] = login.tem31[a];
            //}
            
            int testee = login.tem31.Count();
            for (int x=0; x <= testee - 1; x++)
            {
                if (login.tem31[x] != "" && login.tem31[x] != null)
                {
                    cmbCargo.Items.Add(login.tem31[x]);
                }
                
            }
            //while (login.envio2 != "")
            //{
            //    login.envio2 = "";
            //    login.selectDepartamento(l);
            //    salvarDepartamentos += "|" + login.envio2;
            //    l++;
            //}
            login.selectDepartamento();
          //  int con1 = login.tem32.Count();
         //   string[] Departamentos = salvarDepartamentos.Split((char)'|');
            int testee2 = login.tem32.Count();
            for (int a = 0; a <= testee2 - 1; a++)
            {
                if (login.tem32[a] != "" && login.tem32[a] != null )
                {
                    CmbDepartamento.Items.Add(login.tem32[a]);
                    
                }

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

            for (int m = 0; m <= 23; m++)
            {
                if (m < 10)
                {
                    cmbHoraEntrada.Items.Add("0" + m + ":00" );
                    cmbHoraSaida.Items.Add("0" + m + ":00");
                }
                else
                {
                    cmbHoraEntrada.Items.Add(m + ":00");
                    cmbHoraSaida.Items.Add(m + ":00");
                }
                
            }
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            if (txtNomeFun.Text == "")
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
            if (cmbDia.Text == "" || CmbMes.Text == "" || cmbAno.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }

            if (txtRG.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                label8.Visible = false;
            }
            if (TxtCPF.Text == "")
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
            if (cmbEstadoTele.Text == "" || TxtTelefone.Text == "")
            {
                label10.Visible = true;
            }
            else
            {
                label10.Visible = false;
            }

            if (cmbCargo.Text == "")
            {
                label11.Visible = true;
            }
            else
            {
                label11.Visible = false;
            }
            if (CmbDepartamento.Text == "")
            {
                label12.Visible = true;
            }
            else
            {
                label12.Visible = false;
            }
            if (cmbHoraEntrada.Text == "")
            {
                label13.Visible = true;
            }
            else
            {
                label13.Visible = false;
            }
            if (cmbHoraSaida.Text == "")
            {
                label14.Visible = true;
            }
            else
            {
                label14.Visible = false;
            }

            //string men;
            //string val = TxtCPF.Text;

            //if (CPF.IsCpf(val))
            //{

            //}
            //else
            //{
            //    label9.Visible = true;
            //    MessageBox.Show("Por Gentileza Digite um CPF válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TxtCPF.Text = "";
            //}
            string men;
            string val = TxtCPF.Text;
            if (val.Length == 11 && CPF.IsCpf(val))
            {
                login login = new login();
                login.selectCPFFuncionario(val);
                if (login.tem37 == true)
                {
                    MessageBox.Show("O Funcionário já esta cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtNomeFun.Text != "" && cmbDia.Text != "" && CmbMes.Text != "" && cmbAno.Text != "" && txtRG.Text != "" && TxtCPF.Text != "" && cmbEstadoTele.Text != "" && TxtTelefone.Text != "" && cmbCargo.Text != "" && CmbDepartamento.Text != "" && cmbHoraEntrada.Text != "" && cmbHoraSaida.Text != ""/* && txtEndereco.Text != "" && txtNumeroCasa.Text != ""*/)
                    {
                        try
                        {
                            string dataNasc = "";
                            string endereco = "";
                            string ddd = "";
                            string RG = "";
                            string CPF = "";
                            string telefone = "";
                            string telefone2 = "";
                            CPF = TxtCPF.Text;
                            RG = txtRG.Text;

                            telefone = TxtTelefone.Text;
                            ddd = cmbEstadoTele.Text;

                            telefone2 = ddd + telefone;
                            //   endereco = txtEndereco.Text + " Nº" + txtNumeroCasa.Text + " " + txtComplemento.Text;

                            //      dataNasc = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                            dataNasc = cmbAno.Text + CmbMes.Text + cmbDia.Text;
                            // login login = new login();
                            login.codCargoFunc(cmbCargo.Text);
                            int codCargo = login.tem33;

                            login.cadastrarFuncionario(CPF, txtNomeFun.Text, RG, telefone2, cmbHoraEntrada.Text, cmbHoraSaida.Text, dataNasc, codCargo);
                            if (login.tem7 == true)
                            {
                                MessageBox.Show("Cadastro Realizado com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                MessageBox.Show("Erro ao cadastrar, verifique as informações e tente novamente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            txtNomeFun.Text = "";
                            cmbDia.Text = "";
                            CmbMes.Text = "";
                            cmbAno.Text = "";
                            txtRG.Text = "";
                            TxtCPF.Text = "";
                            cmbEstadoTele.Text = "";
                            TxtTelefone.Text = "";
                            cmbCargo.Text = "";
                            CmbDepartamento.Text = "";
                            cmbHoraEntrada.Text = "";
                            cmbHoraSaida.Text = "";


                        }
                        catch
                        {
                            MessageBox.Show("Erro ao cadastrar, verifique as informações e tente novamente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Gentileza preencha todos os Campos Obrigatórios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
               
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
