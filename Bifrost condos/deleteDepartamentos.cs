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
    public partial class deleteDepartamentos : Form
    {
        public string codd = "";
        public string codd2 = "";
        public string codd3 = "";
        public deleteDepartamentos(string codUpdate)
        {
            InitializeComponent();
            
            for (int o = 11; o <= 99; o++)
            {
                cmbEstadoTele.Items.Add(o);
            }

            string teste = codUpdate;
            codd3 = codUpdate;
            // Conexão conexão = new Conexão();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader dr2;
            codd = teste;



            cmd.CommandText = "select * from Departamento where Nome = @nomeDepartamento";
            cmd.Parameters.AddWithValue("@nomeDepartamento", codd);
           



            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();
                
                //Executar Comando
                dr = cmd.ExecuteReader();
                

                dr.Read();
               



                TxtNomeDepart.Text = dr.GetString(0);
                string tele = dr.GetString(2);
                cmbEstadoTele.Text = tele.Substring(0, 2);
                TxtTelefone.Text = tele.Substring(3);
                dr.Close();

                
                cmd2.Connection = conexão.conectar();
                cmd2.CommandText = "select * from CargosDepartamento where Departamento = @Departamento";
                cmd2.Parameters.AddWithValue("@Departamento", codd);
                dr2 = cmd2.ExecuteReader();
              //  dr2.Read();
                int nColunas = dr2.FieldCount;
                string[] linhaDados = new string[nColunas];
                while (dr2.Read())
                {
                    for (int a = 0; a < nColunas; a++)
                    {
                        if (dr2.GetFieldType(a).ToString() == "System.Int32")
                        {
                           
                        }
                        if (dr2.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = dr2.GetString(a).ToString();
                        }

                        if (dr2.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = dr2.GetDateTime(a).ToString();
                        }
                        
                    }

                    cmbCargos.Items.Add(linhaDados[0]);

                    
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                // this.mensagem = "Não foi possivel conectar ao Banco de Dados!!!";
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TxtNomeDepart.Text == "")
            {
                MessageBox.Show("Por gentileza preencha o nome do Departamento!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (TxtTelefone.Text == "" && TxtTelefone.Text.Length != 9)
            {
                MessageBox.Show("Por gentileza preencha o telefone corretamente!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (TxtTelefone.Text != "" && TxtTelefone.Text.Length == 9 && TxtNomeDepart.Text != "")
            {
                try
                {
                    login login = new login();
                    login.buscarCodCargos();
                    int codDepartamento2 = login.tem10;
                    string telefone = TxtTelefone.Text;
                    string ddd = cmbEstadoTele.Text;

                    string telefone2 = ddd + telefone;
                    //   login.cadastrarDepartamento(TxtNomeDepart.Text, codDepartamento2, telefone2);
                    login.updateDepart(TxtNomeDepart.Text, codDepartamento2, telefone2);
                    int codDepartamento3 = codDepartamento2 + 1;
                    login.updateCodCargos(codDepartamento3);

                    TxtNomeDepart.Text = "";
                    TxtTelefone.Text = "";
                    MessageBox.Show("Departamento Cadastrado com sucesso!!", "Departamento Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    ConsultarDepartamento frmp = new ConsultarDepartamento();
                    frmp.Show();
                }
                catch
                {
                    MessageBox.Show("Erro ao cadastrar o Departamento!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void DeleteDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(cmbCargos.Text != "")
            {

            
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            Conexão conexão = new Conexão();
            SqlCommand cmd3 = new SqlCommand();
            SqlDataReader dr3;

            string Cargo = cmbCargos.Text;

            
           
                cmd3.CommandText = "select * from CargosDepartamento where Cargos = @Cargo";
                cmd3.Parameters.AddWithValue("@Cargo", Cargo);
                
            

            try
            {
                //Conectar ao Banco
                cmd3.Connection = conexão.conectar();
                //Executar Comando
                dr3 = cmd3.ExecuteReader();

                int nColunas = dr3.FieldCount;

                for (int i = 0; i < nColunas; i++)
                {
                    dataGridView2.Columns.Add(dr3.GetName(i).ToString(), dr3.GetName(i).ToString());
                }
                string[] linhaDados = new string[nColunas];

                while (dr3.Read())
                {
                    for (int a = 0; a < nColunas; a++)
                    {
                        if (dr3.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = dr3.GetInt32(a).ToString();
                        }
                        if (dr3.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = dr3.GetString(a).ToString();
                        }

                        if (dr3.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = dr3.GetDateTime(a).ToString();
                        }
                    }

                    dataGridView2.Rows.Add(linhaDados);
                }
                
                conexão.desconectar();

            }
            catch
            {
                MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            }
            else
            {
                MessageBox.Show("Por gentileza selecione um Cargo!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja Editar ou Excluir o Cargo Selecionado!!", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                login login = new login();
                // login.GravarPRaupdate(codUpdate);
                string tek = cmbCargos.Text;
                deleteCargo frmp = new deleteCargo(tek, codd3);
                
                frmp.Show();
                dataGridView2.Rows.Clear();
                dataGridView2.Columns.Clear();
                cmbCargos.Text = "";
                this.Close();
               
               
            }
            else
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

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                login login = new login();
                login.excluirCargos(codd3);
                login.excluirDepartamento(codd3);
                MessageBox.Show("Departamento excluido com sucesso!!", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                ConsultarDepartamento frmp = new ConsultarDepartamento();
                frmp.Show();

            }
            catch
            {
                MessageBox.Show("Erro ao Excluir o Departamento!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            cadastrarMaisCargos frmp = new cadastrarMaisCargos(codd3);
            frmp.Show();
            this.Close();
        }
    }
}
