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
   
    public partial class cadastrarReunião : Form
    {
        public string cod = "";
        public string tt = "";
        public string codUpdate = "";



        public cadastrarReunião()
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
            cmbDia2.Text = dataac.Substring(0, 2);
            string mes = mesmes;
            if (mes.Length > 1)
            {
                CmbMes.Text = dataac.Substring(3, 2);
                cmbMes2.Text = dataac.Substring(3, 2);
            }
            else
            {
                CmbMes.Text = "0" + dataac.Substring(3, 1);
                cmbMes2.Text = "0" + dataac.Substring(3, 1);
            }

            cmbAno.Text = dataac.Substring(6, 4);
            cmbAno2.Text = dataac.Substring(6, 4);

            for (int m = 0; m <= 23; m++)
            {
                if (m < 10)
                {
                    cmbHoraEntrada.Items.Add("0" + m + ":00");
                    cmbHoraEntrada2.Items.Add("0" + m + ":00");

                }
                else
                {
                    cmbHoraEntrada.Items.Add(m + ":00");
                    cmbHoraEntrada2.Items.Add(m + ":00");
                }

            }
            for (int c = 1; c <= 31; c++)
            {
                if (c.ToString().Length == 1)
                {
                    cmbDia.Items.Add("0" + c);
                    cmbDia2.Items.Add("0" + c);
                }
                else
                {
                    cmbDia.Items.Add(c);
                    cmbDia2.Items.Add(c);
                }

            }

            for (int h = 1; h <= 12; h++)
            {

                if (h < 10)
                {
                    CmbMes.Items.Add("0" + h);
                    cmbMes2.Items.Add("0" + h);
                }
                else
                {
                    CmbMes.Items.Add(h);
                    cmbMes2.Items.Add(h);
                }

            }
            for (int y = 1900; y <= 2020; y++)
            {
                cmbAno.Items.Add(y);
                cmbAno2.Items.Add(y);
            }
        }

        private void CadastrarReunião_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtTema.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Tema da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtTopicos.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Topicos da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtLocal.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Local da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (txtResumo.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Resumo da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (cmbDia.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Dia da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (CmbMes.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Mês da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (cmbAno.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Ano da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (cmbHoraEntrada.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o Campo Hora da Reunião!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                if (txtTema.Text != "" && txtLocal.Text != "" && txtResumo.Text != "" && txtTopicos.Text != "" && cmbDia.Text != "" && CmbMes.Text != "" && cmbAno.Text != "" && cmbHoraEntrada.Text != "")
                {
                    login login = new login();
                    string dataReuniao = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                    string codReuniao = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text + "-" + cmbHoraEntrada.Text;
                    string topicos = txtTopicos.Text.Replace("\r\n", "+");
                    login.cadastrarReuniao(txtTema.Text, topicos, txtLocal.Text, dataReuniao, cmbHoraEntrada.Text, txtResumo.Text);
                    

                    cmbHoraEntrada.Text = "";
                    txtTema.Text = "";
                    txtTopicos.Text = "";
                    txtLocal.Text = "";
                    txtResumo.Text = "";
                    cmbAno.Text = "";
                    cmbDia.Text = "";
                    CmbMes.Text = "";
                    MessageBox.Show("Cadastro Realizado com sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar, verifique as informações e tente novamente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void Button3_Click(object sender, EventArgs e)
        {
            tt = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            
            SqlDataReader dr;

            string data = cmbDia2.Text + "/" + cmbMes2.Text + "/" + cmbAno2.Text;
            string codReuniao = data + "-" + cmbHoraEntrada2.Text;
            string hora = cmbHoraEntrada2.Text;
            cmd.CommandText = "select * from REUNIAO where TEMA_CENTRAL = @temaCentral and HORA_REUNIAO = @horaReuniao and DATA_HORA = @dataReuniao";
            cmd.Parameters.AddWithValue("@horaReuniao", hora);
            cmd.Parameters.AddWithValue("@temaCentral", txtTema2.Text);
            cmd.Parameters.AddWithValue("@dataReuniao", data);

            

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
                        if(a == 0)
                        {
                            codReuniao = dr.GetInt32(a).ToString();
                        }
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
                    cod = linhaDados[0];
                    dataGridView2.Rows.Add(linhaDados);
                }
                codUpdate = codReuniao;
                if (linhaDados[0] == null)
                {
                    MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    txtTema2.Text = "";
                    cmbHoraEntrada2.Text = "";

                }

                conexão.desconectar();

            }
            catch
            {

                MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
           
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tt = "x";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = "select * from REUNIAO";


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
                    txtTema2.Text = "";
                    cmbHoraEntrada2.Text = "";

                }

                conexão.desconectar();

            }
            catch
            {

                MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tt = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            txtTema2.Text = "";
            cmbHoraEntrada2.Text = "";
            cmbAno2.Text = "";
            cmbMes2.Text = "";
            cmbDia2.Text = "";
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tt == "")
            {
                if (MessageBox.Show("Deseja Editar ou Excluir a Reunião selecionada!!", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    login login = new login();
                    // login.GravarPRaupdate(codUpdate);
                    string tek = codUpdate;
                    deleteReuniao frmp = new deleteReuniao(codUpdate);
                    
                    frmp.Show();
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    txtTema2.Text = "";
                    cmbHoraEntrada2.Text = "";
                }
                else
                {
                    MessageBox.Show("Por gentileza pesquise a Reunião separadamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {

            }
            
           
        }
       

        private void Timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void DataGridView2_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            
        }

        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
