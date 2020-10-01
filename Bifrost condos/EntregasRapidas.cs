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
    public partial class EntregasRapidas : Form
    {
        public EntregasRapidas()
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

            

        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CmbBlocos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            login login = new login();
            login.selectcodbloco(cmbBlocos.Text);
                string apartamento = cmbApt.Text;
                string bloco = login.tem19.ToString();
                cmd.CommandText = "select * from PEDIDOS_RAPIDOS where APARTAMENTO = @apartamento and COD_BLOCO = @bloco";
                cmd.Parameters.AddWithValue("@apartamento", apartamento);
                cmd.Parameters.AddWithValue("@bloco", bloco);

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
                            if (a == 5)
                            {
                                
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

        private void Button1_Click(object sender, EventArgs e)
        {
            cmbApt.Text = "";
            cmbBlocos.Text = "";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(cmbApt.Text == "" && cmbBlocos.Text == "")
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                Conexão conexão = new Conexão();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                cmd.CommandText = "select * from PEDIDOS_RAPIDOS";

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
                               if(a == 5)
                                {
                                    login login = new login();
                                    login.selectBlocos(dr.GetInt32(a));
                                    linhaDados[a]  = login.tem16;
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
    }
}
