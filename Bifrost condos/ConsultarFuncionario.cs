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
    public partial class ConsultarFuncionario : Form
    {
        public ConsultarFuncionario()
        {
            InitializeComponent();

            CmbPesquisa.Items.Add("*");
            CmbPesquisa.Items.Add("NOME");
            CmbPesquisa.Items.Add("CPF");
            CmbPesquisa.Items.Add("RG");
            CmbPesquisa.Items.Add("CARGO");
            CmbPesquisa.Items.Add("DEPARTAMENTO");
            login login = new login();
            string salvarCargos = "";

            string salvarDepartamentos = "";

            int l = 1;
            login.envio2 = "teste";
            while (login.envio2 != "")
            {
                login.envio2 = "";
                login.selectDepartamento();
                salvarDepartamentos += "|" + login.envio2;
                l++;
            }
            string[] Departamentos = salvarDepartamentos.Split((char)'|');
            int testee2 = Departamentos.Count();
            for (int a = 0; a <= testee2 - 1; a++)
            {
                if (Departamentos[a] != "")
                {
                    comboBox2.Items.Add(Departamentos[a]);

                }

            }

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
                    comboBox1.Items.Add(cargos[x]);
                }

            }

            txtNome.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;

        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ConsultarFuncionario_Load(object sender, EventArgs e)
        {

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
                cmd.CommandText = "select * from Funcionario";
            }
            if (CmbPesquisa.Text == "NOME")
            {
                string Funcionario = "%" + txtNome.Text + "%";
                cmd.CommandText = "SELECT * FROM Funcionario WHERE Nome LIKE @Funcionario";
                cmd.Parameters.AddWithValue("@Funcionario", Funcionario);
            }
            if (CmbPesquisa.Text == "RG")
            {
                string RG = txtNome.Text;
                cmd.CommandText = "SELECT * FROM Funcionario WHERE RG = @RG";
                cmd.Parameters.AddWithValue("@RG", RG);
            }
            if (CmbPesquisa.Text == "CPF")
            {
                string CPF = txtNome.Text;
                cmd.CommandText = "SELECT * FROM Funcionario WHERE CPF = @CPF";
                cmd.Parameters.AddWithValue("@CPF", CPF);
            }
            if (CmbPesquisa.Text == "CARGO")
            {
                string CARGO = comboBox1.Text;
                cmd.CommandText = "SELECT * FROM Funcionario WHERE Cargo = @CARGO";
                cmd.Parameters.AddWithValue("@CARGO", CARGO);
            }
            if (CmbPesquisa.Text == "DEPARTAMENTO")
            {
                string DEPARTAMENTO = comboBox2.Text;
                cmd.CommandText = "SELECT * FROM Funcionario WHERE Departamento = @DEPARTAMENTO";
                cmd.Parameters.AddWithValue("@DEPARTAMENTO", DEPARTAMENTO);
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
                    txtNome.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    comboBox1.Visible = false;
                    txtNome.Text = "";
                    CmbPesquisa.Text = "";
                    comboBox1.Text = "";

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
                txtNome.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
            if (CmbPesquisa.Text == "NOME")
            {
                label2.Text = "NOME:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
            if (CmbPesquisa.Text == "RG")
            {
                label2.Text = "RG:";
                label2.Visible = true;
                txtNome.Visible = true;
                label4.Visible = true;
                label3.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
            if (CmbPesquisa.Text == "CPF")
            {
                label2.Text = "CPF:";
                label2.Visible = true;
                txtNome.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
            if (CmbPesquisa.Text == "CARGO")
            {
                label2.Text = "CARGO:";
                label2.Visible = true;
                comboBox1.Visible = true;
                txtNome.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                comboBox2.Visible = false;

            }
            if (CmbPesquisa.Text == "DEPARTAMENTO")
            {
                label2.Text = "DEPARTAMENTO:";
                label2.Visible = true;
                comboBox2.Visible = true;
                comboBox1.Visible = false;
                txtNome.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
               
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtNome.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            txtNome.Text = "";
            CmbPesquisa.Text = "";
            comboBox1.Text = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        }
    }
}
