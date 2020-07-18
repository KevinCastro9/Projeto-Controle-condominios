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
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();

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
            login.tem16 = "teste";
            int i = 1;
            cmbBlocos.Items.Add("*");
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
            for (int y = 1900; y <= 2020; y++)
            {
                cmbAno.Items.Add(y);
            }
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbHoraEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Titulo!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAviso.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Aviso!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (cmbBlocos.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o campo Blocos!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtTitulo.Text != "" && txtAviso.Text != ""  && cmbBlocos.Text != "" && cmbDia.Text != "" && CmbMes.Text != "" && cmbAno.Text != "")
            {
                try
                {
                    login login = new login();
                    string data = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                    string codAviso = data + "-" + txtTitulo.Text;
                    login.selectNomeLogado();
                    string assina = login.tem25;
                    login.cadastrarAvisos(codAviso, txtTitulo.Text, data, cmbBlocos.Text, txtAviso.Text, assina);

                    txtTitulo.Text = "";
                    txtAviso.Text = "";
                    
                    cmbBlocos.Text = "";
                    MessageBox.Show("Cadastro Realizado com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar Aviso!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
