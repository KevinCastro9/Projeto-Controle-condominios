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

    public partial class ConfiguracaoBlocos : Form
    {
        int teste2 = 0;
        int teste3 = 0;
        int teste4 = 0;
        int x = 0;
        int a = 0;
        


        string[] NomesBlocos = new string[30];
        string[] testek;
        
        
        
        public ConfiguracaoBlocos()
        {
            InitializeComponent();
        }


       

        private void BntMaxmizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BntFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            
  
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TxtBl1.Text != "")
            {
                login login = new login();
                login.ConfigTelaDeBlocos();
                teste3 = login.tem4;




                if (x <= teste3 - 1)
                {
                    NomesBlocos[x] = TxtBl1.Text;
                    if (x == teste3 - 1)
                    {
                        int Num = x + 1;
                        int Num1 = 0;
                        for (int i = 0; i < Num; i++)
                        {
                            Num1 = i + 1;
                            string GravaBloco = "";
                            GravaBloco = NomesBlocos[i];
                            login.GravarNomeBloco(GravaBloco, Num1);
                        }
                        if (login.tem6 == "V")
                        {
                            MessageBox.Show("Blocos cadastrados com sucesso", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TelaPrincipal frmp = new TelaPrincipal();
                            frmp.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro por gentileza tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                    }
                }

                if (x < teste3 - 1)
                {
                    a = x + 2;
                }
                label3.Text = a.ToString();
                x++;
                TxtBl1.Text = "";
            }
            else
            {
                MessageBox.Show("Por gentileza preencha o campo Nome Bloco!!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_2(object sender, EventArgs e)
        {
            
        }
    }
}
