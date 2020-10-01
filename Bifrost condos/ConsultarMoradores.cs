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
    public partial class ConsultarMoradores : Form
    {
        public ConsultarMoradores()
        {
            InitializeComponent();

            CmbPesquisa.Items.Add("NOME");
            CmbPesquisa.Items.Add("CPF");
            CmbPesquisa.Items.Add("RG");
            CmbPesquisa.Items.Add("APARTAMENTO");
            CmbPesquisa.Items.Add("GARAGEM");
            login login = new login();


            int i = 1;
            login.tem16 = "teste";
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

            txtNome.Visible = false;
            cmbApt.Visible = false;
            cmbBlocos.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
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

            
            if (CmbPesquisa.Text == "NOME")
            {
                
                    string Morador = txtNome.Text;
                    cmd.CommandText = "select * from MORADORES where NOME = @Morador";
                    cmd.Parameters.AddWithValue("@Morador", Morador);
                
               
            }
            if (CmbPesquisa.Text == "CPF")
            {
                string CPF = txtNome.Text;
                cmd.CommandText = "select * from MORADORES where  CPF = @CPF";
                cmd.Parameters.AddWithValue("@CPF", CPF);
            }
            if (CmbPesquisa.Text == "RG")
            {
                string RG = txtNome.Text;
                cmd.CommandText = "select * from MORADORES where  RG = @RG";
                cmd.Parameters.AddWithValue("@RG", RG);
            }
            if (CmbPesquisa.Text == "GARAGEM")
            {
                string Garagem = txtNome.Text;
                cmd.CommandText = "select * from MORADORES where  GARAGEM = @Garagem";
                cmd.Parameters.AddWithValue("@Garagem", Garagem);
            }
            if (CmbPesquisa.Text == "APARTAMENTO")
            {
                string Apartamento = cmbApt.Text;
                string Blocos = cmbBlocos.Text;
                login login = new login();
                login.selectcodbloco(Blocos);
                int codBloco = login.tem19;
               
                cmd.CommandText = "select * from MORADORES where  COD_BLOCO = @Blocos and APARTAMENTO = @Apartamento";
                cmd.Parameters.AddWithValue("@Apartamento", Apartamento);
                cmd.Parameters.AddWithValue("@Blocos", codBloco);
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
                if (linhaDados[0] == null && linhaDados[1] == null)
                {
                    MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    txtNome.Visible = false;
                    cmbApt.Visible = false;
                    cmbBlocos.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    txtNome.Text = "";
                    cmbApt.Text = "";
                    cmbBlocos.Text = "";
                    CmbPesquisa.Text = "";


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
            
            if (CmbPesquisa.Text == "NOME")
            {
                label2.Text = "NOME:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                cmbApt.Visible = false;
                cmbBlocos.Visible = false;
            }
            if (CmbPesquisa.Text == "CPF")
            {
                label2.Text = "CPF:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = false;
                label4.Visible = true;
                cmbApt.Visible = false;
                cmbBlocos.Visible = false;
            }
            if (CmbPesquisa.Text == "RG")
            {
                label2.Text = "RG:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                cmbApt.Visible = false;
                cmbBlocos.Visible = false;
            }

            if (CmbPesquisa.Text == "GARAGEM")
            {
                label2.Text = "GARAGEM:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                cmbApt.Visible = false;
                cmbBlocos.Visible = false;
            }
            if (CmbPesquisa.Text == "APARTAMENTO")
            {
                label2.Text = "APARTAMENTO:";
                label2.Visible = true;
                txtNome.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                cmbApt.Visible = true;
                cmbBlocos.Visible = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtNome.Visible = false;
            cmbApt.Visible = false;
            cmbBlocos.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtNome.Text = "";
            cmbApt.Text = "";
            cmbBlocos.Text = "";
            CmbPesquisa.Text = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        }
    }
}
