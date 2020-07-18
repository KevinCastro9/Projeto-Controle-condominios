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
    public partial class ConsultarUsuarios : Form
    {
        public ConsultarUsuarios()
        {
            InitializeComponent();

            CmbPesquisa.Items.Add("*");
            CmbPesquisa.Items.Add("LOGIN");
            CmbPesquisa.Items.Add("NOME");
            CmbPesquisa.Items.Add("CARGO");

            txtNome.Visible = false;
            cmbCargo.Visible = false;
            label2.Visible = false;

            login login = new login();
            string salvarCargos = "";
            int i = 1;
            login.envio = "teste";


            while (login.envio != "")
            {
                login.envio = "";
                login.selectCargos();
                salvarCargos += "|" + login.envio;
                i++;
            }
            string[] cargos = salvarCargos.Split((char)'|');
            int testee = cargos.Count();
            for (int x = 0; x <= testee - 1; x++)
            {
                if (cargos[x] != "")
                {
                    cmbCargo.Items.Add(cargos[x]);
                }

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

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            if (CmbPesquisa.Text == "NOME")
            {
                string NOME = "%" + txtNome.Text + "%";
                cmd.CommandText = "select * from UsuarioDesck where Nome like @NOME";
                cmd.Parameters.AddWithValue("@NOME", NOME);
            }
            if (CmbPesquisa.Text == "*")
            {
                
                cmd.CommandText = "select * from UsuarioDesck";
               
            }
            if (CmbPesquisa.Text == "CARGO")
            {
                string CARGO =  cmbCargo.Text ;
                cmd.CommandText = "select * from UsuarioDesck where Cargo = @CARGO";
                cmd.Parameters.AddWithValue("@CARGO", CARGO);
            }
            if (CmbPesquisa.Text == "LOGIN")
            {
                string LOGIN = txtNome.Text;
                cmd.CommandText = "select * from UsuarioDesck where Login = @LOGIN";
                cmd.Parameters.AddWithValue("@LOGIN", LOGIN);
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
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    label2.Visible = false;
                    cmbCargo.Visible = false;
                    txtNome.Visible = false;
                    txtNome.Text = "";
                    cmbCargo.Text = "";
                    label2.Visible = false;
                    cmbCargo.Visible = false;
                    txtNome.Visible = false;
                    txtNome.Text = "";
                    cmbCargo.Text = "";
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
                cmbCargo.Visible = false;
            }
            if (CmbPesquisa.Text == "*")
            {
                label2.Text = "";
                label2.Visible = false;
                txtNome.Visible = false;
                cmbCargo.Visible = false;
            }
            if (CmbPesquisa.Text == "CARGO")
            {
                label2.Text = "CARGO:";
                label2.Visible = true;
                txtNome.Visible = false;
                cmbCargo.Visible = true;
            }
            if (CmbPesquisa.Text == "LOGIN")
            {
                label2.Text = "LOGIN:";
                label2.Visible = true;
                txtNome.Visible = true;
                cmbCargo.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            cmbCargo.Visible = false;
            txtNome.Visible = false;
            txtNome.Text = "";
            cmbCargo.Text = "";
            CmbPesquisa.Text = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        }
    }
}
