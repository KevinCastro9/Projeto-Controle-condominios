using System;
using System.Windows.Forms;


namespace Bifrost_condos
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        public string sql, nomef = "";

        private void TelaLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void TelaLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Por gentileza preencha os campos Usuario e Senha para acessar o sistema!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(textBox1.Text == "")
                    {
                        MessageBox.Show("Por gentileza preencha o campo Usuario para acessar o sistema!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if(textBox2.Text == "")
                    {
                        MessageBox.Show("Por gentileza preecha o campo Senha para acessar o sistema!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if(textBox1.Text != "" && textBox2.Text != "")
                {
                    login login = new login();
                    login.logar(textBox1.Text, textBox2.Text);

                    if (login.tem)
                    {
                        
                        login.selectUsuarioAnterior();
                        int UsuarioAnterior = login.tem22;
                        login.selectUsuarioAnterior2(textBox1.Text, textBox2.Text);
                        int codUsuario = login.tem23;
                        login.selectUsuarioAnterior3(codUsuario);
                        int cod = login.tem24;
                        login.selectUsuarioAnterior4(codUsuario);
                        string NomeUsuario = login.tem30;
                        login.updateUsuarioLogado(textBox1.Text, NomeUsuario, codUsuario, cod, UsuarioAnterior);
                        TelaPrincipal frmp = new TelaPrincipal();
                        frmp.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        

                        MessageBox.Show("Usuario ou Senha incorreto, tente novamente!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                    textBox1.Text = "";
                    textBox2.Text = "";




                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não Conectou" + erro);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        string login = "Kevin";
            //        string senha = "123";

            //        if (textBox1.Text == login) 
            //        {
            //            if(textBox2.Text == senha)
            //            {
            //                MenuPrincipal frmp = new MenuPrincipal();
            //                frmp.Show();
            //                this.Visible = false;
            //            }

            //        }
            //        else 
            //        {
            //            MessageBox.Show("Usuario e senha Incorretos");
            //        }

            //        textBox1.Text = "";
            //        textBox2.Text = "";

            //    }
            //    catch (Exception erro)
            //    {
            //        MessageBox.Show("Não Conectou" + erro);
            //    }
            //}
        }
    }
}
