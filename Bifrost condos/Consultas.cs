using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bifrost_condos
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();

            //Label2.Parent = Me;
            //Label2.BackColor = Color.Transparent
            //label2.Parent = pictureBox1;
            //label2.BackColor = Color.Transparent;
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ConsultarMoradores frmp = new ConsultarMoradores();
            frmp.Show();
            this.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios frmp = new ConsultarUsuarios();
            frmp.Show();
            this.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           ConsultarDepartamento frmp = new ConsultarDepartamento();
            frmp.Show();
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    ConsultarFuncionario frmp = new ConsultarFuncionario();
            //    frmp.Show();
            //    this.Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            login login = new login();
            login.codSindico();
            int codSindico = login.tem29;
            login.cargoLogado(codSindico);
            bool verif = login.tem27;
            if (verif == true)
            {
                ConsultarFuncionario frmp = new ConsultarFuncionario();
                frmp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ConsultarVisitantes frmp = new ConsultarVisitantes();
            frmp.Show();
            this.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
           ConsultarEmpresa frmp = new ConsultarEmpresa();
            frmp.Show();
            this.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    ConsultarUsuarios frmp = new ConsultarUsuarios();
            //    frmp.Show();
            //    this.Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            login login = new login();
            login.codSindico();
            int codSindico = login.tem29;
            login.cargoLogado(codSindico);
            bool verif = login.tem27;
            if (verif == true)
            {
                ConsultarUsuarios frmp = new ConsultarUsuarios();
                frmp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
