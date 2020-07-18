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
    public partial class deleteCargo : Form
    {
        public string codd = "";
        public string cod2 = "";
        public string de = "";
        public deleteCargo(string cargo, string depa)
        {
            InitializeComponent();
            login login = new login();
            de = depa;
            login.envio = "teste";
            login.envio2 = "teste";
            
            string salvarDepartamentos = "";
            int l = 1;

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
                    CmbDepartamento.Items.Add(Departamentos[a]);

                }

            }
            string teste = cargo;
            cod2 = cargo;

            // Conexão conexão = new Conexão();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader dr2;
            codd = teste;



            cmd.CommandText = "select * from CargosDepartamento where Cargos = @Cargo";
            cmd.Parameters.AddWithValue("@Cargo", codd);




            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();

                //Executar Comando
                dr = cmd.ExecuteReader();


                dr.Read();




                txtCargo.Text = dr.GetString(0);
                CmbDepartamento.Text = dr.GetString(2);
            }
            catch
            {
                MessageBox.Show("A Consulta não foi localizada, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Conexão conexão = new Conexão();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader dr2;
            codd = txtCargo.Text;
            string cargoss = txtCargo.Text;
            string dep = CmbDepartamento.Text;



            cmd.CommandText = "update CargosDepartamento set Cargos = @cargoss, Departamento = @dep where Cargos = @Cargo ";
            cmd.Parameters.AddWithValue("@Cargo", cod2);
            cmd.Parameters.AddWithValue("@cargoss", cargoss);
            cmd.Parameters.AddWithValue("@dep", dep);




            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();

                //Executar Comando
                dr = cmd.ExecuteReader();


                dr.Read();


                txtCargo.Text = "";
                CmbDepartamento.Text = "";
                MessageBox.Show("Cadastro realizado com Secesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                
                
                this.Close();
                deleteDepartamentos frmp = new deleteDepartamentos(de);
                frmp.Show();
        
            }
            catch
            {
                MessageBox.Show("Erro ao tentar realizar o cadastro!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            deleteDepartamentos frmp = new deleteDepartamentos(de);
            frmp.Show();
            
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Conexão conexão = new Conexão();
            Conexão conexão = new Conexão();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            SqlCommand cmd2 = new SqlCommand();
            SqlDataReader dr2;
            codd = txtCargo.Text;



            cmd.CommandText = "delete from CargosDepartamento where Cargos = @Cargo";
            cmd.Parameters.AddWithValue("@Cargo", codd);




            try
            {
                //Conectar ao Banco
                cmd.Connection = conexão.conectar();

                //Executar Comando
                dr = cmd.ExecuteReader();

                txtCargo.Text = "";
                CmbDepartamento.Text = "";
                
                MessageBox.Show("Exclusão realizada com sucesso!!", "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                deleteDepartamentos frmp = new deleteDepartamentos(de);
                frmp.Show();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar excluir!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
