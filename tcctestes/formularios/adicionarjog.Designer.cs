
namespace tcctestes.formularios
{
    partial class adicionarjog
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.adicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.naoze = new System.Windows.Forms.RadioButton();
            this.jaze = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.naojog = new System.Windows.Forms.RadioButton();
            this.jajog = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Categoria",
            "Aventura",
            "Ação",
            "FPS",
            "Sandbox",
            "Terror",
            "MOBA",
            "Estratégia",
            "Ritmo"});
            this.comboBox2.Location = new System.Drawing.Point(408, 68);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 28);
            this.comboBox2.TabIndex = 19;
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(18, 506);
            this.adicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(525, 35);
            this.adicionar.TabIndex = 18;
            this.adicionar.Text = "adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Linkar atalho";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 309);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(300, 26);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "caminho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.naoze);
            this.groupBox2.Controls.Add(this.jaze);
            this.groupBox2.Location = new System.Drawing.Point(288, 211);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(250, 88);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // naoze
            // 
            this.naoze.AutoSize = true;
            this.naoze.Location = new System.Drawing.Point(120, 31);
            this.naoze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naoze.Name = "naoze";
            this.naoze.Size = new System.Drawing.Size(101, 24);
            this.naoze.TabIndex = 1;
            this.naoze.TabStop = true;
            this.naoze.Text = "Não zerei";
            this.naoze.UseVisualStyleBackColor = true;
            // 
            // jaze
            // 
            this.jaze.AutoSize = true;
            this.jaze.Location = new System.Drawing.Point(10, 31);
            this.jaze.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jaze.Name = "jaze";
            this.jaze.Size = new System.Drawing.Size(89, 24);
            this.jaze.TabIndex = 0;
            this.jaze.TabStop = true;
            this.jaze.Text = "Já zerei";
            this.jaze.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.naojog);
            this.groupBox1.Controls.Add(this.jajog);
            this.groupBox1.Location = new System.Drawing.Point(288, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(250, 88);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // naojog
            // 
            this.naojog.AutoSize = true;
            this.naojog.Location = new System.Drawing.Point(120, 31);
            this.naojog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naojog.Name = "naojog";
            this.naojog.Size = new System.Drawing.Size(114, 24);
            this.naojog.TabIndex = 1;
            this.naojog.TabStop = true;
            this.naojog.Text = "Não Joguei";
            this.naojog.UseVisualStyleBackColor = true;
            // 
            // jajog
            // 
            this.jajog.AutoSize = true;
            this.jajog.Location = new System.Drawing.Point(10, 31);
            this.jajog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jajog.Name = "jajog";
            this.jajog.Size = new System.Drawing.Size(97, 24);
            this.jajog.TabIndex = 0;
            this.jajog.TabStop = true;
            this.jajog.Text = "Já joguei";
            this.jajog.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Não gostei",
            "Gostei",
            "Amei"});
            this.comboBox1.Location = new System.Drawing.Point(288, 68);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(18, 349);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(518, 146);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Descrição";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(288, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 26);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Nome";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::tcctestes.Properties.Resources.addimage;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // adicionarjog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 548);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "adicionarjog";
            this.Text = "adicionarjog";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton naoze;
        private System.Windows.Forms.RadioButton jaze;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton naojog;
        private System.Windows.Forms.RadioButton jajog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}