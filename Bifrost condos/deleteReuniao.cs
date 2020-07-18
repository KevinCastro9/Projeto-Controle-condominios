using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Bifrost_condos
{

    public partial class deleteReuniao : Form
    {
        public string codd = "";


        public deleteReuniao(string teste)
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


            for (int m = 0; m <= 23; m++)
            {
                if (m < 10)
                {
                    cmbHoraEntrada.Items.Add("0" + m + ":00");


                }
                else
                {
                    cmbHoraEntrada.Items.Add(m + ":00");

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
            for (int y = 1900; y <= 2020; y++)
            {
                cmbAno.Items.Add(y);

            }

            // Conexão conexão = new Conexão();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            codd = teste;



            cmd.CommandText = "select * from REUNIAO where COD_REUNIAO = @codReuniao";
            cmd.Parameters.AddWithValue("@codReuniao", codd);


            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                dr.Read();
                txtTema.Text = dr.GetString(1);
                txtTopicos.Text = dr.GetString(6).Replace("+", "\r\n"); ;
                txtLocal.Text = dr.GetString(2);
                txtResumo.Text = dr.GetString(4);
                string data2 = dr.GetDateTime(3).ToString();
                string data3 = data2.Substring(0, 10);
                string[] data = data3.Split((char)'/');
                // .Split((char)'-');
                cmbDia.Text = data[0];
                CmbMes.Text = data[1];
                cmbAno.Text = data[2];
                cmbHoraEntrada.Text = dr.GetString(5);

                
            }
            catch (SqlException e)
            {
                // this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }


        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                login login = new login();
                string codk = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text + "-" + cmbHoraEntrada.Text;
                string date = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                string topi = txtTopicos.Text.Replace("\r\n", "+");
                login.updateNoCadastroReuniao(codd, txtTema.Text, topi, txtLocal.Text, date, cmbHoraEntrada.Text, txtResumo.Text);
                MessageBox.Show("Cadastro Realizado com sucesso!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLocal.Text = "";
                txtResumo.Text = "";
                txtTema.Text = "";
                txtTopicos.Text = "";
                cmbAno.Text = "";
                cmbDia.Text = "";
                CmbMes.Text = "";
                cmbHoraEntrada.Text = "";
                this.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao realizar o cadastro!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                login login = new login();
                string codDelete = codd;
                login.deletarReuniao(codDelete);
                MessageBox.Show("Reunião excluida com sucesso!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLocal.Text = "";
                txtResumo.Text = "";
                txtTema.Text = "";
                txtTopicos.Text = "";
                cmbAno.Text = "";
                cmbDia.Text = "";
                CmbMes.Text = "";
                cmbHoraEntrada.Text = "";
                this.Visible = false;

            }
            catch
            {
                MessageBox.Show("Erro ao excluir a reunião!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
