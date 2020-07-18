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
    public partial class TelaCarregamento : Form
    {
        public TelaCarregamento()
        {
            InitializeComponent();
        }

        private void TelaCarregamento_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            login login = new login();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {

                login.PrimeiraAcesso();

                if (login.tem2 == false)
                {
                    timer1.Enabled = false;
                    TelaLogin fr1 = new TelaLogin();
                    fr1.Show();
                    this.Visible = false;
                }
                else
                {
                    timer1.Enabled = false;
                    Tela_ConfiguracaoInicial fr1 = new Tela_ConfiguracaoInicial();
                    fr1.Show();
                    this.Visible = false;
                }
            }
        }
    }
}
