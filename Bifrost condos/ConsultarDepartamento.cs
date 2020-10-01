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
using System.Data.OleDb;

namespace Bifrost_condos
{
    public partial class ConsultarDepartamento : Form
    {
        public string tt = "teste";
        public string codUpdate = "";
        public ConsultarDepartamento()
        {
            InitializeComponent();
            login login = new login();
            CmbDepartamento.Items.Clear();
            CmbDepartamento.Text = "";
            login.envio = "teste";
            login.envio2 = "teste";
            CmbDepartamento.Items.Add("*");
            string salvarDepartamentos = "";
            int l = 1;
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            

            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                cmd.CommandText = "select * from DEPARTAMENTOS";
                //Executar Comando
                dr = cmd.ExecuteReader();

                int nColunas = dr.FieldCount;


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
                    CmbDepartamento.Items.Add(linhaDados[1]);

                }

                conexão.desconectar();






                //while (login.envio2 != "")
                //{
                //    login.envio2 = "";
                //    login.selectDepartamento(l);
                //    salvarDepartamentos += "|" + login.envio2;
                //    l++;
                //}
                //string[] Departamentos = salvarDepartamentos.Split((char)'|');
                //int testee2 = Departamentos.Count();
                //for (int a = 0; a <= testee2 - 1; a++)
                //{
                //    if (Departamentos[a] != "")
                //    {
                //        CmbDepartamento.Items.Add(Departamentos[a]);

                //    }

                //}
            }
            catch
            {

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
            if (CmbDepartamento.Text != "")
            {
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                Conexão conexão = new Conexão();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                string Departamento = CmbDepartamento.Text;

                if (Departamento == "*")
                {
                    cmd.CommandText = "select * from DEPARTAMENTOS";
                    tt = "teste";
                }
                else
                {
                    login login = new login();
                    login.selectCodDepar(Departamento);
                    int codDepartamento = login.tem47;
                    cmd.CommandText = "select * from CARGOS where COD_DEPARTAMENTO = @Departamento";
                    cmd.Parameters.AddWithValue("@Departamento", codDepartamento);
                    tt = "";
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
                    codUpdate = Departamento;
                    conexão.desconectar();

                }
                catch
                {
                    MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
            }
            else
            {
                MessageBox.Show("Por gentileza escolha um Departamento!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tt = "teste";
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            CmbDepartamento.Text = "";
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView2_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
           
        }

        private void ConsultarDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void DataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (CmbDepartamento.Text != "*" && CmbDepartamento.Text != "")
            {
                if (MessageBox.Show("Deseja Editar ou Excluir o Departamento selecionado!!", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    login login = new login();
                    // login.GravarPRaupdate(codUpdate);
                    string tek = codUpdate;
                    deleteDepartamentos frmp = new deleteDepartamentos(codUpdate);

                    frmp.Show();
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    this.Close();
                    
                }
                
                else
                {
                   
                }
            }
            else
            {
               // MessageBox.Show("Por gentileza pesquise o Departamento selecionado!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void DataGridView2_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void DataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
