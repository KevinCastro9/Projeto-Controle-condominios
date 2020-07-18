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
    public partial class cadastrarMaisCargos : Form
    {
        public string nomeD = "";
        public cadastrarMaisCargos(string nomeDepa)
        {
            InitializeComponent();
            nomeD = nomeDepa;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtCargo.Text != "")
            {
                login login = new login();
                login.buscarCodCargos();
                int codDepartamento = login.tem10;
            //    login.cadastrarCargo(txtCargo.Text, codDepartamento, nomeD);
                txtCargo.Text = "";
                MessageBox.Show("Cargo Cadastrado com sucesso!!", "Cargo Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            deleteDepartamentos frmp = new deleteDepartamentos(nomeD);
            frmp.Show();
        }

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            deleteDepartamentos frmp = new deleteDepartamentos(nomeD);
            frmp.Show();
            this.Close();
        }
    }
}
