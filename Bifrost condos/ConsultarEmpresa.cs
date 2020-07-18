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
    public partial class ConsultarEmpresa : Form
    {
        public ConsultarEmpresa()
        {
            InitializeComponent();

            cmbAno.Visible = false;
            CmbMes.Visible = false;
            cmbDia.Visible = false;
            txtNome.Visible = false;
            txtPesquisar.Visible = false;
            label3.Visible = false;
            CmbPesquisa.Items.Add("DATA SERVIÇO");
            CmbPesquisa.Items.Add("*");
            CmbPesquisa.Items.Add("CNPJ");
            CmbPesquisa.Items.Add("NOME");


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

            cmbAno.Visible = false;
            cmbDia.Visible = false;
            CmbMes.Visible = false;

        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsultarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            

            if(CmbPesquisa.Text == "*")
            {
                cmd.CommandText = "select * from Servicos";
            }
            if (CmbPesquisa.Text == "NOME")
            {
                string Empresa = txtNome.Text;
                cmd.CommandText = "select * from Servicos where Empresa = @Empresa";
                cmd.Parameters.AddWithValue("@Empresa", Empresa);
            }
            if (CmbPesquisa.Text == "DATA SERVIÇO")
            {
                string Empresa = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                cmd.CommandText = "select * from Servicos where dataServico = @Empresa";
                cmd.Parameters.AddWithValue("@Empresa", Empresa);
            }
            if (CmbPesquisa.Text == "CNPJ")
            {
                string Empresa = txtPesquisar.Text;
                cmd.CommandText = "select * from Servicos where CNPJ = @Empresa";
                cmd.Parameters.AddWithValue("@Empresa", Empresa);
            }

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                //Executar Comando
                dr = cmd.ExecuteReader();

                int nColunas = dr.FieldCount;

                for (int i = 0; i < nColunas; i++)
                {
                    dataGridView2.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
                }
                string[] linhaDados = new string[nColunas];
                while (dr.Read())
                {
                    for (int a = 0; a < nColunas; a++)
                    {
                        if (dr.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = dr.GetInt32(a).ToString();
                        }
                        if (dr.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = dr.GetString(a).ToString();
                        }

                        if (dr.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = dr.GetDateTime(a).ToString();
                        }
                    }

                    dataGridView2.Rows.Add(linhaDados);
                }
                if(linhaDados[0] == null)
                {
                    MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    CmbPesquisa.Text = "";
                    txtPesquisar.Text = "";
                    txtNome.Text = "";
                    cmbDia.Visible = false;
                    CmbMes.Visible = false;
                    cmbAno.Visible = false;
                    txtNome.Visible = false;
                    txtPesquisar.Visible = false;
                    label2.Visible = false;
                }

                conexão.desconectar();

            }
            catch
            {

                MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(CmbPesquisa.Text == "*")
            {
                label2.Text = "";
                txtPesquisar.Visible = false;
                cmbAno.Visible = false;
                cmbDia.Visible = false;
                CmbMes.Visible = false;
                txtNome.Visible = false;
                label3.Visible = false;
            }
          
            if(CmbPesquisa.Text == "CNPJ")
            {
                label2.Visible = true;
                label2.Text = CmbPesquisa.Text + " :";
                label3.Visible = true;
                txtPesquisar.Visible = true;
                cmbAno.Visible = false;
                cmbDia.Visible = false;
                CmbMes.Visible = false;
                txtNome.Visible = false;
               
            }
            if (CmbPesquisa.Text == "DATA SERVIÇO")
            {
                label2.Visible = true;
                label2.Text = CmbPesquisa.Text + " :";
                txtPesquisar.Visible = false;
                cmbAno.Visible = true;
                cmbDia.Visible = true;
                CmbMes.Visible = true;
                txtNome.Visible = false;
                label3.Visible = false;
            }
            if(CmbPesquisa.Text == "NOME")
            {
                label2.Visible = true;
                label2.Text = CmbPesquisa.Text + " :";
                txtPesquisar.Visible = false;
                cmbAno.Visible = false;
                cmbDia.Visible = false;
                CmbMes.Visible = false;
                txtNome.Visible = true;
                label3.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            CmbPesquisa.Text = "";
            txtPesquisar.Text = "";
            txtNome.Text = "";
            cmbDia.Visible = false;
            CmbMes.Visible = false;
            cmbAno.Visible = false;
            txtNome.Visible = false;
            txtPesquisar.Visible = false;
            label2.Visible = false;
        }
    }
}
