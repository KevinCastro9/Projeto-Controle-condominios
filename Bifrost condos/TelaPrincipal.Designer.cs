using System;
using System.Windows.Forms;

namespace Bifrost_condos
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntMaxmizar = new System.Windows.Forms.Button();
            this.bntFechar = new System.Windows.Forms.Button();
            this.okToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ok1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ok2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ok3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarReuniõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanhamentoDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregaRapidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encomendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bifrost Condominium";
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.White;
            this.panelCabecalho.Controls.Add(this.button1);
            this.panelCabecalho.Controls.Add(this.pictureBox1);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.bntMaxmizar);
            this.panelCabecalho.Controls.Add(this.bntFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 71);
            this.panelCabecalho.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Bifrost_condos.Properties.Resources.imagem_chave;
            this.button1.Location = new System.Drawing.Point(655, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 48);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bntMaxmizar
            // 
            this.bntMaxmizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMaxmizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntMaxmizar.FlatAppearance.BorderSize = 0;
            this.bntMaxmizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntMaxmizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bntMaxmizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMaxmizar.ForeColor = System.Drawing.Color.White;
            this.bntMaxmizar.Image = ((System.Drawing.Image)(resources.GetObject("bntMaxmizar.Image")));
            this.bntMaxmizar.Location = new System.Drawing.Point(713, 3);
            this.bntMaxmizar.Name = "bntMaxmizar";
            this.bntMaxmizar.Size = new System.Drawing.Size(40, 47);
            this.bntMaxmizar.TabIndex = 3;
            this.bntMaxmizar.UseVisualStyleBackColor = true;
            this.bntMaxmizar.Click += new System.EventHandler(this.BntMaxmizar_Click);
            // 
            // bntFechar
            // 
            this.bntFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntFechar.FlatAppearance.BorderSize = 0;
            this.bntFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bntFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bntFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntFechar.ForeColor = System.Drawing.Color.White;
            this.bntFechar.Image = ((System.Drawing.Image)(resources.GetObject("bntFechar.Image")));
            this.bntFechar.Location = new System.Drawing.Point(757, 3);
            this.bntFechar.Name = "bntFechar";
            this.bntFechar.Size = new System.Drawing.Size(40, 47);
            this.bntFechar.TabIndex = 1;
            this.bntFechar.UseVisualStyleBackColor = true;
            this.bntFechar.Click += new System.EventHandler(this.BntFechar_Click);
            // 
            // okToolStripMenuItem
            // 
            this.okToolStripMenuItem.AutoSize = false;
            this.okToolStripMenuItem.Name = "okToolStripMenuItem";
            this.okToolStripMenuItem.Size = new System.Drawing.Size(194, 4);
            this.okToolStripMenuItem.Text = "ok";
            // 
            // ok1ToolStripMenuItem
            // 
            this.ok1ToolStripMenuItem.AutoSize = false;
            this.ok1ToolStripMenuItem.Name = "ok1ToolStripMenuItem";
            this.ok1ToolStripMenuItem.Size = new System.Drawing.Size(194, 4);
            this.ok1ToolStripMenuItem.Text = "ok1";
            // 
            // ok2ToolStripMenuItem
            // 
            this.ok2ToolStripMenuItem.AutoSize = false;
            this.ok2ToolStripMenuItem.Name = "ok2ToolStripMenuItem";
            this.ok2ToolStripMenuItem.Size = new System.Drawing.Size(194, 4);
            this.ok2ToolStripMenuItem.Text = "ok2";
            // 
            // ok3ToolStripMenuItem
            // 
            this.ok3ToolStripMenuItem.AutoSize = false;
            this.ok3ToolStripMenuItem.Name = "ok3ToolStripMenuItem";
            this.ok3ToolStripMenuItem.Size = new System.Drawing.Size(194, 4);
            this.ok3ToolStripMenuItem.Text = "ok3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.okToolStripMenuItem,
            this.acompanhamentoDeAcessoToolStripMenuItem,
            this.ok1ToolStripMenuItem,
            this.telaPrincipalToolStripMenuItem,
            this.ok2ToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.ok3ToolStripMenuItem,
            this.Sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 71);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 20, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(201, 379);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.AutoSize = false;
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.visitanteToolStripMenuItem,
            this.loginsToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.agendarReuniõesToolStripMenuItem,
            this.empresasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripMenuItem.Image = global::Bifrost_condos.Properties.Resources.imagem_amigos3;
            this.cadastroToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cadastroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(194, 65);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.alunoToolStripMenuItem.Text = "Moradores";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.AlunoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.professorToolStripMenuItem.Text = "Funcionarios";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.ProfessorToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.funcionarioToolStripMenuItem.Text = "Visitantes";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.FuncionarioToolStripMenuItem_Click);
            // 
            // visitanteToolStripMenuItem
            // 
            this.visitanteToolStripMenuItem.Name = "visitanteToolStripMenuItem";
            this.visitanteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.visitanteToolStripMenuItem.Text = "Empresas";
            this.visitanteToolStripMenuItem.Click += new System.EventHandler(this.VisitanteToolStripMenuItem_Click);
            // 
            // loginsToolStripMenuItem
            // 
            this.loginsToolStripMenuItem.Name = "loginsToolStripMenuItem";
            this.loginsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.loginsToolStripMenuItem.Text = "Logins";
            this.loginsToolStripMenuItem.Click += new System.EventHandler(this.LoginsToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.DepartamentosToolStripMenuItem_Click);
            // 
            // agendarReuniõesToolStripMenuItem
            // 
            this.agendarReuniõesToolStripMenuItem.Name = "agendarReuniõesToolStripMenuItem";
            this.agendarReuniõesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.agendarReuniõesToolStripMenuItem.Text = "Agendar Reuniões";
            this.agendarReuniõesToolStripMenuItem.Click += new System.EventHandler(this.AgendarReuniõesToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Visible = false;
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.EmpresasToolStripMenuItem_Click);
            // 
            // acompanhamentoDeAcessoToolStripMenuItem
            // 
            this.acompanhamentoDeAcessoToolStripMenuItem.AutoSize = false;
            this.acompanhamentoDeAcessoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.acompanhamentoDeAcessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entregaRapidaToolStripMenuItem,
            this.encomendasToolStripMenuItem});
            this.acompanhamentoDeAcessoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.acompanhamentoDeAcessoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.acompanhamentoDeAcessoToolStripMenuItem.Image = global::Bifrost_condos.Properties.Resources.imagem_formulario;
            this.acompanhamentoDeAcessoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acompanhamentoDeAcessoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.acompanhamentoDeAcessoToolStripMenuItem.Name = "acompanhamentoDeAcessoToolStripMenuItem";
            this.acompanhamentoDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(194, 65);
            this.acompanhamentoDeAcessoToolStripMenuItem.Text = "Pedidos";
            this.acompanhamentoDeAcessoToolStripMenuItem.Click += new System.EventHandler(this.AcompanhamentoDeAcessoToolStripMenuItem_Click);
            // 
            // entregaRapidaToolStripMenuItem
            // 
            this.entregaRapidaToolStripMenuItem.Name = "entregaRapidaToolStripMenuItem";
            this.entregaRapidaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.entregaRapidaToolStripMenuItem.Text = "Entregas Rapidas";
            this.entregaRapidaToolStripMenuItem.Click += new System.EventHandler(this.EntregaRapidaToolStripMenuItem_Click);
            // 
            // encomendasToolStripMenuItem
            // 
            this.encomendasToolStripMenuItem.Name = "encomendasToolStripMenuItem";
            this.encomendasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.encomendasToolStripMenuItem.Text = "Encomendas";
            this.encomendasToolStripMenuItem.Click += new System.EventHandler(this.EncomendasToolStripMenuItem_Click);
            // 
            // telaPrincipalToolStripMenuItem
            // 
            this.telaPrincipalToolStripMenuItem.AutoSize = false;
            this.telaPrincipalToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.telaPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.telaPrincipalToolStripMenuItem.Image = global::Bifrost_condos.Properties.Resources.imagem_Pastas;
            this.telaPrincipalToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.telaPrincipalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.telaPrincipalToolStripMenuItem.Name = "telaPrincipalToolStripMenuItem";
            this.telaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(194, 65);
            this.telaPrincipalToolStripMenuItem.Text = "Consultar";
            this.telaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.TelaPrincipalToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.AutoSize = false;
            this.configuraçõesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.configuraçõesToolStripMenuItem.Image = global::Bifrost_condos.Properties.Resources.imagem_configuraçao;
            this.configuraçõesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.configuraçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(194, 65);
            this.configuraçõesToolStripMenuItem.Text = "Avisos";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.ConfiguraçõesToolStripMenuItem_Click);
            // 
            // Sair
            // 
            this.Sair.AutoSize = false;
            this.Sair.BackColor = System.Drawing.Color.White;
            this.Sair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.Sair.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Sair.Image = global::Bifrost_condos.Properties.Resources.imagens_ferramentas;
            this.Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sair.ImageTransparentColor = System.Drawing.Color.White;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(194, 65);
            this.Sair.Text = "Ferramentas";
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sobreToolStripMenuItem.Text = "Word";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.ExcelToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(241, 17);
            this.toolStripStatusLabel1.Text = "Bem vindo ao sistema Bifrost Condominium";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.ToolStripStatusLabel3_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(201, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 15);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(195, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 367);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Timer timer1;
        private Button bntFechar;
        private Button bntMaxmizar;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panelCabecalho;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem professorToolStripMenuItem;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem visitanteToolStripMenuItem;
        private ToolStripMenuItem loginsToolStripMenuItem;
        private ToolStripMenuItem departamentosToolStripMenuItem;
        private ToolStripMenuItem okToolStripMenuItem;
        private ToolStripMenuItem acompanhamentoDeAcessoToolStripMenuItem;
        private ToolStripMenuItem entregaRapidaToolStripMenuItem;
        private ToolStripMenuItem encomendasToolStripMenuItem;
        private ToolStripMenuItem ok1ToolStripMenuItem;
        private ToolStripMenuItem telaPrincipalToolStripMenuItem;
        private ToolStripMenuItem ok2ToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem ok3ToolStripMenuItem;
        private ToolStripMenuItem Sair;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripMenuItem agendarReuniõesToolStripMenuItem;
        private ToolStripMenuItem empresasToolStripMenuItem;
    }
}