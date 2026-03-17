
namespace tcctestes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.jogrecent = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoAdicionarJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosOsJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usrstats = new System.Windows.Forms.ToolStripStatusLabel();
            this.dhstats = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.jogrecent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usrstats,
            this.dhstats});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // jogrecent
            // 
            this.jogrecent.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.jogrecent.BackColor = System.Drawing.Color.Cornsilk;
            this.jogrecent.Controls.Add(this.pictureBox3);
            this.jogrecent.Controls.Add(this.pictureBox2);
            this.jogrecent.Controls.Add(this.pictureBox1);
            this.jogrecent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.jogrecent.Location = new System.Drawing.Point(12, 38);
            this.jogrecent.Name = "jogrecent";
            this.jogrecent.Size = new System.Drawing.Size(722, 394);
            this.jogrecent.TabIndex = 0;
            this.jogrecent.TabStop = false;
            this.jogrecent.Text = "jogos recentes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogosToolStripMenuItem
            // 
            this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.verTodosOsJogosToolStripMenuItem,
            this.removerJogosToolStripMenuItem});
            this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
            this.jogosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.jogosToolStripMenuItem.Text = "Jogos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoAdicionarJogosToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ajudaToolStripMenuItem.Text = "ajuda";
            // 
            // comoAdicionarJogosToolStripMenuItem
            // 
            this.comoAdicionarJogosToolStripMenuItem.Name = "comoAdicionarJogosToolStripMenuItem";
            this.comoAdicionarJogosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.comoAdicionarJogosToolStripMenuItem.Text = "como adicionar jogos";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.sobreToolStripMenuItem.Text = "sobre";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarToolStripMenuItem.Text = "adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // verTodosOsJogosToolStripMenuItem
            // 
            this.verTodosOsJogosToolStripMenuItem.Name = "verTodosOsJogosToolStripMenuItem";
            this.verTodosOsJogosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verTodosOsJogosToolStripMenuItem.Text = "ver todos os jogos";
            this.verTodosOsJogosToolStripMenuItem.Click += new System.EventHandler(this.verTodosOsJogosToolStripMenuItem_Click);
            // 
            // removerJogosToolStripMenuItem
            // 
            this.removerJogosToolStripMenuItem.Name = "removerJogosToolStripMenuItem";
            this.removerJogosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerJogosToolStripMenuItem.Text = "remover jogos";
            this.removerJogosToolStripMenuItem.Click += new System.EventHandler(this.removerJogosToolStripMenuItem_Click);
            // 
            // usrstats
            // 
            this.usrstats.Name = "usrstats";
            this.usrstats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usrstats.Size = new System.Drawing.Size(52, 17);
            this.usrstats.Text = "usuario: ";
            // 
            // dhstats
            // 
            this.dhstats.Name = "dhstats";
            this.dhstats.Size = new System.Drawing.Size(59, 17);
            this.dhstats.Text = "data/hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 356);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(254, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 356);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(488, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(228, 356);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(746, 463);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.jogrecent);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TEstes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.jogrecent.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox jogrecent;
        private System.Windows.Forms.ToolStripStatusLabel usrstats;
        private System.Windows.Forms.ToolStripStatusLabel dhstats;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosOsJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoAdicionarJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

