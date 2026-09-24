
namespace tcctestes.formularios
{
    partial class adicionarjogo
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
            this.combobox2 = new System.Windows.Forms.ComboBox();
            this.adicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.naoze = new System.Windows.Forms.RadioButton();
            this.jaze = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.naojog = new System.Windows.Forms.RadioButton();
            this.jajog = new System.Windows.Forms.RadioButton();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // combobox2
            // 
            this.combobox2.AccessibleDescription = "Categoria do jogo";
            this.combobox2.AccessibleName = "Categoria";
            this.combobox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combobox2.FormattingEnabled = true;
            this.combobox2.Items.AddRange(new object[] {
            "Aventura",
            "Ação",
            "FPS",
            "Sandbox",
            "Terror",
            "MOBA",
            "Estratégia",
            "Ritmo",
            "Corrida",
            "E-sport",
            "RPG",
            "MMORPG",
            "Visual Novel",
            "Puzzle",
            "Simulação",
            "Competitivo"});
            this.combobox2.Location = new System.Drawing.Point(74, 26);
            this.combobox2.Name = "combobox2";
            this.combobox2.Size = new System.Drawing.Size(77, 21);
            this.combobox2.TabIndex = 2;
            // 
            // adicionar
            // 
            this.adicionar.AccessibleDescription = "Adiciona o jogo à biblioteca";
            this.adicionar.AccessibleName = "Adicionar";
            this.adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionar.BackColor = System.Drawing.SystemColors.Window;
            this.adicionar.Location = new System.Drawing.Point(6, 283);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(287, 23);
            this.adicionar.TabIndex = 8;
            this.adicionar.Text = "adicionar";
            this.adicionar.UseVisualStyleBackColor = false;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Adiciona o caminho para iniciar o jogo";
            this.button1.AccessibleName = "Atalho";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(135, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar atalho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(0, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "caminho";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.naoze);
            this.groupBox2.Controls.Add(this.jaze);
            this.groupBox2.Location = new System.Drawing.Point(1, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 42);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // naoze
            // 
            this.naoze.AccessibleDescription = "Seleção caso não tenha terminado o jogo";
            this.naoze.AccessibleName = "Não zerei";
            this.naoze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.naoze.AutoSize = true;
            this.naoze.Location = new System.Drawing.Point(74, 14);
            this.naoze.Name = "naoze";
            this.naoze.Size = new System.Drawing.Size(70, 17);
            this.naoze.TabIndex = 1;
            this.naoze.TabStop = true;
            this.naoze.Text = "Não zerei";
            this.naoze.UseVisualStyleBackColor = true;
            // 
            // jaze
            // 
            this.jaze.AccessibleDescription = "Seleção caso tenha terminado o jogo";
            this.jaze.AccessibleName = "Já zerei";
            this.jaze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.jaze.AutoSize = true;
            this.jaze.Location = new System.Drawing.Point(6, 14);
            this.jaze.Name = "jaze";
            this.jaze.Size = new System.Drawing.Size(61, 17);
            this.jaze.TabIndex = 0;
            this.jaze.TabStop = true;
            this.jaze.Text = "Já zerei";
            this.jaze.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.naojog);
            this.groupBox1.Controls.Add(this.jajog);
            this.groupBox1.Location = new System.Drawing.Point(1, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // naojog
            // 
            this.naojog.AccessibleDescription = "Seleção caso não tenha jogado o jogo";
            this.naojog.AccessibleName = "Não joguei";
            this.naojog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.naojog.AutoSize = true;
            this.naojog.Location = new System.Drawing.Point(74, 14);
            this.naojog.Name = "naojog";
            this.naojog.Size = new System.Drawing.Size(76, 17);
            this.naojog.TabIndex = 1;
            this.naojog.TabStop = true;
            this.naojog.Text = "Não joguei";
            this.naojog.UseVisualStyleBackColor = true;
            this.naojog.CheckedChanged += new System.EventHandler(this.naojog_CheckedChanged);
            // 
            // jajog
            // 
            this.jajog.AccessibleDescription = "Seleção caso tenha jogado o jogo";
            this.jajog.AccessibleName = "Já Joguei";
            this.jajog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.jajog.AutoSize = true;
            this.jajog.Location = new System.Drawing.Point(7, 14);
            this.jajog.Name = "jajog";
            this.jajog.Size = new System.Drawing.Size(67, 17);
            this.jajog.TabIndex = 0;
            this.jajog.TabStop = true;
            this.jajog.Text = "Já joguei";
            this.jajog.UseVisualStyleBackColor = true;
            this.jajog.CheckedChanged += new System.EventHandler(this.jajog_CheckedChanged);
            // 
            // combobox1
            // 
            this.combobox1.AccessibleDescription = "Avaliação do jogo";
            this.combobox1.AccessibleName = "Avaliação";
            this.combobox1.BackColor = System.Drawing.SystemColors.Window;
            this.combobox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Items.AddRange(new object[] {
            "Não gostei",
            "Gostei",
            "Amei"});
            this.combobox1.Location = new System.Drawing.Point(1, 26);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(68, 21);
            this.combobox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "Descrição do jogo";
            this.textBox2.AccessibleName = "Descrição";
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(6, 181);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(287, 96);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Descrição";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Nome do jogo";
            this.textBox1.AccessibleName = "Nome";
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Nome";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = "Adiciona a capa do jogo";
            this.button2.AccessibleName = "Capa";
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(0, 121);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Adicionar capa do jogo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImage = global::tcctestes.Properties.Resources.addimage;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::tcctestes.Properties.Resources.quadro8;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.combobox2);
            this.panel1.Controls.Add(this.combobox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(142, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 143);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.MaximumSize = new System.Drawing.Size(520, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 143);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(7, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 22);
            this.panel3.TabIndex = 19;
            // 
            // adicionarjogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(299, 311);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 640);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(315, 350);
            this.Name = "adicionarjogo";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.adicionarjog_FormClosing);
            this.Load += new System.EventHandler(this.adicionarjog_Load_1);
            this.Resize += new System.EventHandler(this.adicionarjog_Resize);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox2;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton naoze;
        private System.Windows.Forms.RadioButton jaze;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton naojog;
        private System.Windows.Forms.RadioButton jajog;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}