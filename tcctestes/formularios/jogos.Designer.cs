
namespace tcctestes.formularios
{
    partial class jogos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.painel = new System.Windows.Forms.Panel();
            this.descricao = new System.Windows.Forms.TextBox();
            this.cat = new System.Windows.Forms.ComboBox();
            this.aval = new System.Windows.Forms.ComboBox();
            this.painelop2 = new System.Windows.Forms.Panel();
            this.naoze = new System.Windows.Forms.RadioButton();
            this.jaze = new System.Windows.Forms.RadioButton();
            this.painelop = new System.Windows.Forms.Panel();
            this.jajog = new System.Windows.Forms.RadioButton();
            this.naojog = new System.Windows.Forms.RadioButton();
            this.btnalt = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.btnexc = new System.Windows.Forms.Button();
            this.btnabrir = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.painel.SuspendLayout();
            this.painelop2.SuspendLayout();
            this.painelop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarJogosToolStripMenuItem,
            this.paginaInicialToolStripMenuItem});
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.jogosToolStripMenuItem.Text = "jogos";
            // 
            // adicionarJogosToolStripMenuItem
            // 
            this.adicionarJogosToolStripMenuItem.Name = "adicionarJogosToolStripMenuItem";
            this.adicionarJogosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.adicionarJogosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.adicionarJogosToolStripMenuItem.Text = "adicionar jogos";
            this.adicionarJogosToolStripMenuItem.Click += new System.EventHandler(this.adicionarJogosToolStripMenuItem_Click);
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.paginaInicialToolStripMenuItem.Text = "pagina inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ajudaToolStripMenuItem.Text = "ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sobreToolStripMenuItem.Text = "sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(9, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 371);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.painel.Controls.Add(this.descricao);
            this.painel.Controls.Add(this.cat);
            this.painel.Controls.Add(this.aval);
            this.painel.Controls.Add(this.painelop2);
            this.painel.Controls.Add(this.painelop);
            this.painel.Controls.Add(this.btnalt);
            this.painel.Controls.Add(this.path);
            this.painel.Controls.Add(this.nome);
            this.painel.Controls.Add(this.btnexc);
            this.painel.Controls.Add(this.btnabrir);
            this.painel.Controls.Add(this.btnsalvar);
            this.painel.Controls.Add(this.pictureBox1);
            this.painel.Enabled = false;
            this.painel.Location = new System.Drawing.Point(559, 32);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(180, 371);
            this.painel.TabIndex = 2;
            this.painel.EnabledChanged += new System.EventHandler(this.painel_EnabledChanged);
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(6, 186);
            this.descricao.Multiline = true;
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(167, 42);
            this.descricao.TabIndex = 12;
            this.descricao.TextChanged += new System.EventHandler(this.descricao_TextChanged);
            // 
            // cat
            // 
            this.cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cat.FormattingEnabled = true;
            this.cat.Items.AddRange(new object[] {
            "Categoria",
            "Aventura",
            "Ação",
            "FPS",
            "Sandbox",
            "Terror",
            "MOBA",
            "Estratégia",
            "Ritmo"});
            this.cat.Location = new System.Drawing.Point(93, 275);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(80, 21);
            this.cat.TabIndex = 11;
            this.cat.SelectedIndexChanged += new System.EventHandler(this.cat_SelectedIndexChanged);
            // 
            // aval
            // 
            this.aval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aval.FormattingEnabled = true;
            this.aval.Items.AddRange(new object[] {
            "Não gostei",
            "Gostei",
            "Amei"});
            this.aval.Location = new System.Drawing.Point(6, 275);
            this.aval.Name = "aval";
            this.aval.Size = new System.Drawing.Size(84, 21);
            this.aval.TabIndex = 10;
            this.aval.TextChanged += new System.EventHandler(this.aval_TextChanged);
            // 
            // painelop2
            // 
            this.painelop2.Controls.Add(this.naoze);
            this.painelop2.Controls.Add(this.jaze);
            this.painelop2.Location = new System.Drawing.Point(93, 231);
            this.painelop2.Name = "painelop2";
            this.painelop2.Size = new System.Drawing.Size(80, 41);
            this.painelop2.TabIndex = 9;
            // 
            // naoze
            // 
            this.naoze.AutoSize = true;
            this.naoze.Location = new System.Drawing.Point(3, 20);
            this.naoze.Name = "naoze";
            this.naoze.Size = new System.Drawing.Size(70, 17);
            this.naoze.TabIndex = 1;
            this.naoze.TabStop = true;
            this.naoze.Text = "Não zerei";
            this.naoze.UseVisualStyleBackColor = true;
            // 
            // jaze
            // 
            this.jaze.AutoSize = true;
            this.jaze.Location = new System.Drawing.Point(3, 3);
            this.jaze.Name = "jaze";
            this.jaze.Size = new System.Drawing.Size(61, 17);
            this.jaze.TabIndex = 0;
            this.jaze.TabStop = true;
            this.jaze.Text = "Já zerei";
            this.jaze.UseVisualStyleBackColor = true;
            // 
            // painelop
            // 
            this.painelop.Controls.Add(this.jajog);
            this.painelop.Controls.Add(this.naojog);
            this.painelop.Location = new System.Drawing.Point(6, 231);
            this.painelop.Name = "painelop";
            this.painelop.Size = new System.Drawing.Size(167, 41);
            this.painelop.TabIndex = 8;
            // 
            // jajog
            // 
            this.jajog.AutoSize = true;
            this.jajog.Location = new System.Drawing.Point(3, 3);
            this.jajog.Name = "jajog";
            this.jajog.Size = new System.Drawing.Size(67, 17);
            this.jajog.TabIndex = 0;
            this.jajog.TabStop = true;
            this.jajog.Text = "Já joguei";
            this.jajog.UseVisualStyleBackColor = true;
            this.jajog.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // naojog
            // 
            this.naojog.AutoSize = true;
            this.naojog.Location = new System.Drawing.Point(3, 20);
            this.naojog.Name = "naojog";
            this.naojog.Size = new System.Drawing.Size(76, 17);
            this.naojog.TabIndex = 1;
            this.naojog.TabStop = true;
            this.naojog.Text = "Não joguei";
            this.naojog.UseVisualStyleBackColor = true;
            // 
            // btnalt
            // 
            this.btnalt.Location = new System.Drawing.Point(107, 162);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(66, 22);
            this.btnalt.TabIndex = 7;
            this.btnalt.Text = "Alterar";
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(6, 163);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(100, 20);
            this.path.TabIndex = 6;
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(6, 139);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(167, 20);
            this.nome.TabIndex = 5;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // btnexc
            // 
            this.btnexc.Location = new System.Drawing.Point(6, 346);
            this.btnexc.Name = "btnexc";
            this.btnexc.Size = new System.Drawing.Size(167, 23);
            this.btnexc.TabIndex = 4;
            this.btnexc.Text = "Excluir";
            this.btnexc.UseVisualStyleBackColor = true;
            this.btnexc.Click += new System.EventHandler(this.btnexc_Click);
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(6, 322);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(167, 23);
            this.btnabrir.TabIndex = 3;
            this.btnabrir.Text = "Abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(6, 298);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(167, 23);
            this.btnsalvar.TabIndex = 2;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(744, 411);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "jogos";
            this.Text = "jogos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.jogos_FormClosing);
            this.Load += new System.EventHandler(this.jogos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.painelop2.ResumeLayout(false);
            this.painelop2.PerformLayout();
            this.painelop.ResumeLayout(false);
            this.painelop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel painelop2;
        private System.Windows.Forms.Panel painelop;
        private System.Windows.Forms.RadioButton jajog;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button btnexc;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.RadioButton naoze;
        private System.Windows.Forms.RadioButton jaze;
        private System.Windows.Forms.RadioButton naojog;
        private System.Windows.Forms.ComboBox cat;
        private System.Windows.Forms.ComboBox aval;
        private System.Windows.Forms.TextBox descricao;
    }
}