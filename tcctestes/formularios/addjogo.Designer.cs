
namespace tcctestes.formularios
{
    partial class addjogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addjogo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jajog = new System.Windows.Forms.RadioButton();
            this.naojog = new System.Windows.Forms.RadioButton();
            this.jaze = new System.Windows.Forms.RadioButton();
            this.naoze = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(186, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "nome";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 231);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 96);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "descrição";
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
            this.comboBox1.Location = new System.Drawing.Point(186, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.naojog);
            this.groupBox1.Controls.Add(this.jajog);
            this.groupBox1.Location = new System.Drawing.Point(186, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.naoze);
            this.groupBox2.Controls.Add(this.jaze);
            this.groupBox2.Location = new System.Drawing.Point(186, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 57);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // jajog
            // 
            this.jajog.AutoSize = true;
            this.jajog.Location = new System.Drawing.Point(7, 20);
            this.jajog.Name = "jajog";
            this.jajog.Size = new System.Drawing.Size(67, 17);
            this.jajog.TabIndex = 0;
            this.jajog.TabStop = true;
            this.jajog.Text = "Já joguei";
            this.jajog.UseVisualStyleBackColor = true;
            // 
            // naojog
            // 
            this.naojog.AutoSize = true;
            this.naojog.Location = new System.Drawing.Point(80, 20);
            this.naojog.Name = "naojog";
            this.naojog.Size = new System.Drawing.Size(79, 17);
            this.naojog.TabIndex = 1;
            this.naojog.TabStop = true;
            this.naojog.Text = "Não Joguei";
            this.naojog.UseVisualStyleBackColor = true;
            // 
            // jaze
            // 
            this.jaze.AutoSize = true;
            this.jaze.Location = new System.Drawing.Point(7, 20);
            this.jaze.Name = "jaze";
            this.jaze.Size = new System.Drawing.Size(61, 17);
            this.jaze.TabIndex = 0;
            this.jaze.TabStop = true;
            this.jaze.Text = "Já zerei";
            this.jaze.UseVisualStyleBackColor = true;
            // 
            // naoze
            // 
            this.naoze.AutoSize = true;
            this.naoze.Location = new System.Drawing.Point(80, 20);
            this.naoze.Name = "naoze";
            this.naoze.Size = new System.Drawing.Size(70, 17);
            this.naoze.TabIndex = 1;
            this.naoze.TabStop = true;
            this.naoze.Text = "Não zerei";
            this.naoze.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(201, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "caminho";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Linkar atalho";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "adicionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addjogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "addjogo";
            this.Text = "addjogo";
            this.Load += new System.EventHandler(this.addjogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton naojog;
        private System.Windows.Forms.RadioButton jajog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton naoze;
        private System.Windows.Forms.RadioButton jaze;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}