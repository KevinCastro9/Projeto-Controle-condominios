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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            login login = new login();
            login.selectNomeLogado();
            toolStripStatusLabel4.Text = "                     " + login.tem25;
        }

        private void TelaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas frmp = new Consultas();
            frmp.Show();
        }

        private void Sair_Click(object sender, EventArgs e)
        {

        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.codSindico();
            int codSindico = login.tem29;
            login.cargoLogado(codSindico);
            bool verif = login.tem27;
            if (verif == true)
            {
                CadastroMoradores frmp = new CadastroMoradores();
                frmp.Show();
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void ProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    CadastroFuncionarios frmp = new CadastroFuncionarios();
            //    frmp.Show();
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
                CadastroFuncionarios frmp = new CadastroFuncionarios();
                frmp.Show();
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void FuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVisitantes frmp = new CadastroVisitantes();
            frmp.Show();
            
        }

        private void VisitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    CadastroEmpresas frmp = new CadastroEmpresas();
            //    frmp.Show();
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
                EmpresasCadastros frmp = new EmpresasCadastros();
                 frmp.Show();
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void LoginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    CadastroUsuarios frmp = new CadastroUsuarios();
            //    frmp.Show();
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
                CadastroUsuarios frmp = new CadastroUsuarios();
                frmp.Show();
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    CadastroDepartamento frmp = new CadastroDepartamento();
            //    frmp.Show();
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
                CadastroDepartamento frmp = new CadastroDepartamento();
                frmp.Show();
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void EntregaRapidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntregasRapidas frmp = new EntregasRapidas();
            frmp.Show();
            
        }

        private void EncomendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encomendas frmp = new Encomendas();
            frmp.Show();
            
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WinWord");
        }

        private void ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaLogin frmp = new TelaLogin();
            frmp.Show();
            this.Visible = false;
        }

        private void AcompanhamentoDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    Configuracoes frmp = new Configuracoes();
            //    frmp.Show();
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
                Configuracoes frmp = new Configuracoes();
                frmp.Show();
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
            //toolStripStatusLabel4.Text = DateTime.Now.ToShortTimeString();


        }

        private void AgendarReuniõesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //login login = new login();
            //login.cargoLogado();
            //string verif = login.tem27;
            //if (verif == "Sindico")
            //{
            //    cadastrarReunião frmp = new cadastrarReunião();
            //    frmp.Show();
            //    //this.Visible = false;
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
                cadastrarReunião frmp = new cadastrarReunião();
                 frmp.Show();
            }
            else
            {
                MessageBox.Show("Essa tela não é autorizada para sua função!!", "RESTRITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ToolStripStatusLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void EmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
