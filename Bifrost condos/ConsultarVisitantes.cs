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
    public partial class ConsultarVisitantes : Form
    {
        public ConsultarVisitantes()
        {
            InitializeComponent();

            CmbPesquisa.Items.Add("*");
            CmbPesquisa.Items.Add("NOME");
            CmbPesquisa.Items.Add("CPF");
            CmbPesquisa.Items.Add("RG");

            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtNome.Visible = false;
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            if (CmbPesquisa.Text == "*")
            {
                cmd.CommandText = "select * from Visitantes";
            }
            if (CmbPesquisa.Text == "NOME")
            {
                string Visitante = "%" + txtNome.Text + "%";
                cmd.CommandText = "select * from Visitantes where NomeVisitante like @Visitante";
                cmd.Parameters.AddWithValue("@Visitante", Visitante);
            }
            if (CmbPesquisa.Text == "CPF")
            {
                string CPF = txtNome.Text;
                cmd.CommandText = "select * from Visitantes where CPF = @CPF";
                cmd.Parameters.AddWithValue("@CPF", CPF);
            }
            if (CmbPesquisa.Text == "RG")
            {
                string RG = txtNome.Text;
                cmd.CommandText = "select * from Visitantes where RG = @RG";
                cmd.Parameters.AddWithValue("@RG", RG);
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
                if (linhaDados[0] == null)
                {
                    MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label2.Visible = false;
                    txtNome.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    CmbPesquisa.Text = "";
                    txtNome.Text = "";
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();


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
            if (CmbPesquisa.Text == "*")
            {
                label2.Text = "";
                label2.Visible = false;
                txtNome.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

            }
            if (CmbPesquisa.Text == "NOME")
            {
                label2.Text = "NOME:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                
            }
            if (CmbPesquisa.Text == "CPF")
            {
                label2.Text = "CPF:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = false;
                label4.Visible = true;

            }
            if (CmbPesquisa.Text == "RG")
            {
                label2.Text = "RG:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = true;
                label4.Visible = false;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtNome.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            CmbPesquisa.Text = "";
            txtNome.Text = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        }
    }
}
