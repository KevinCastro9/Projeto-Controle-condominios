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
    public partial class Encomendas : Form
    {
        public Encomendas()
        {
            InitializeComponent();

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

            string dataac = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            int conn = dataac.Length;
            if(conn == 8)
            {
                cmbDia.Text = "0" + dataac.Substring(0, 1);
            }
            else
            {
                cmbDia.Text = dataac.Substring(0, 2);
            }
            
            string mes = System.DateTime.Now.Month.ToString();
            if (mes.Length > 1)
            {
                CmbMes.Text = dataac.Substring(3, 2);
            }
            else
            {
                CmbMes.Text = "0" + dataac.Substring(3, 1);
            }
            if (conn == 8)
            {
                cmbAno.Text = dataac.Substring(4, 4);

            }
            else
            {
                cmbAno.Text = dataac.Substring(5, 4);
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

            cmbApt.Visible = false;
            cmbBlocos.Visible = false;
            cmbAno.Visible = false;
            cmbDia.Visible = false;
            CmbMes.Visible = false;
            cmbAno.Visible = false;

            comboBox3.Items.Add("APARTAMENTO");
            comboBox3.Items.Add("DATA");
            cmbAno.Text = "";
            CmbMes.Text = "";
            cmbDia.Text = "";
            cmbApt.Text = "";
            cmbBlocos.Text = "";
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
            if (comboBox3.Text == "APARTAMENTO")
            {
                login login = new login();
                login.selectcodbloco(cmbBlocos.Text);
                string apartamento = cmbApt.Text;
                string bloco = login.tem19.ToString();
                cmd.CommandText = "select * from ENCOMENDAS where APARTAMENTO = @apartamento and COD_BLOCO = @bloco";
                cmd.Parameters.AddWithValue("@apartamento", apartamento);
                cmd.Parameters.AddWithValue("@bloco", bloco);
            }
            if (comboBox3.Text == "DATA")
            {
                string data = cmbDia.Text + "/" + CmbMes.Text + "/" + cmbAno.Text;
                cmd.CommandText = "select * from ENCOMENDAS where DATA_PREVISAO = @data";
                cmd.Parameters.AddWithValue("@data", data);
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
                            if (a == 7)
                            {
                                login login = new login();
                                login.selectBlocos(dr.GetInt32(a));
                                linhaDados[a] = login.tem16;
                            }
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
                    cmbApt.Visible = false;
                    cmbBlocos.Visible = false;
                    cmbAno.Visible = false;
                    cmbDia.Visible = false;
                    CmbMes.Visible = false;
                    cmbAno.Visible = false;
                    comboBox3.Text = "";
                    cmbAno.Text = "";
                    CmbMes.Text = "";
                    cmbDia.Text = "";
                    cmbApt.Text = "";
                    cmbBlocos.Text = "";


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
            if (comboBox3.Text == "DATA")
            {
                cmbAno.Visible = true;
                CmbMes.Visible = true;
                cmbDia.Visible = true;
                cmbApt.Visible = false;
                cmbBlocos.Visible = false;
                
            }
            if (comboBox3.Text == "APARTAMENTO")
            {
                cmbAno.Visible = false;
                CmbMes.Visible = false;
                cmbDia.Visible = false;
                cmbApt.Visible = true;
                cmbBlocos.Visible = true;
                
            }
            if (cmbApt.Text == "" && cmbBlocos.Text == "" && cmbDia.Text == "" && CmbMes.Text=="" && cmbAno.Text == "")
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                Conexão conexão = new Conexão();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                cmd.CommandText = "select * from encomendas";

                try
                {
                    //Conectar ao Banco
                    cmd.Connection = conexão.conectar();
                    //Executar Comando
                    dr = cmd.ExecuteReader();

                    int nColunas = dr.FieldCount;

                    for (int p = 0; p < nColunas; p++)
                    {
                        dataGridView2.Columns.Add(dr.GetName(p).ToString(), dr.GetName(p).ToString());
                    }
                    string[] linhaDados = new string[nColunas];
                    while (dr.Read())
                    {
                        for (int a = 0; a < nColunas; a++)
                        {
                            if (dr.GetFieldType(a).ToString() == "System.Int32")
                            {
                                linhaDados[a] = dr.GetInt32(a).ToString();
                                if (a == 7)
                                {
                                    login login = new login();
                                    login.selectBlocos(dr.GetInt32(a));
                                    linhaDados[a] = login.tem16;
                                }
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
                    }

                    conexão.desconectar();

                }
                catch
                {

                    MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cmbApt.Visible = false;
            cmbBlocos.Visible = false;
            cmbAno.Visible = false;
            cmbDia.Visible = false;
            CmbMes.Visible = false;
            cmbAno.Visible = false;
            comboBox3.Text = "";
            cmbAno.Text = "";
            CmbMes.Text = "";
            cmbDia.Text = "";
            cmbApt.Text = "";
            cmbBlocos.Text = "";
        }
    }
    
}
