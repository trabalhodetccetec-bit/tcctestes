
namespace tcctestes.formularios
{
    partial class FeedBack
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recursos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dificuldades = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comentario = new System.Windows.Forms.TextBox();
            this.enviarFeedback = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.txtExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(149, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.Location = new System.Drawing.Point(27, 69);
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(261, 45);
            this.txtExperiencia.TabIndex = 2;
            this.txtExperiencia.Value = 5;
            this.txtExperiencia.Scroll += new System.EventHandler(this.txtExperiencia_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numa escala de 0 a 10, como foi sua experiência usando esse app?\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Você recomendaria esse app para outra pessoa?";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sim",
            "Nâo"});
            this.comboBox1.Location = new System.Drawing.Point(27, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Existe algum recurso que você gostaria de ver no app e que ainda \r\nnão é oferecid" +
    "o?";
            // 
            // recursos
            // 
            this.recursos.Location = new System.Drawing.Point(27, 192);
            this.recursos.Multiline = true;
            this.recursos.Name = "recursos";
            this.recursos.Size = new System.Drawing.Size(327, 52);
            this.recursos.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Você teve dificuldades ao utilizar o app, se sim, quais?";
            // 
            // dificuldades
            // 
            this.dificuldades.Location = new System.Drawing.Point(27, 268);
            this.dificuldades.Multiline = true;
            this.dificuldades.Name = "dificuldades";
            this.dificuldades.Size = new System.Drawing.Size(327, 52);
            this.dificuldades.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(298, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Por fim, deixe um comentário sobre sua experiência utilizando \r\nnosso app";
            // 
            // comentario
            // 
            this.comentario.Location = new System.Drawing.Point(27, 357);
            this.comentario.Multiline = true;
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(327, 72);
            this.comentario.TabIndex = 13;
            // 
            // enviarFeedback
            // 
            this.enviarFeedback.Location = new System.Drawing.Point(27, 436);
            this.enviarFeedback.Name = "enviarFeedback";
            this.enviarFeedback.Size = new System.Drawing.Size(327, 26);
            this.enviarFeedback.TabIndex = 14;
            this.enviarFeedback.Text = "Enviar Feedback";
            this.enviarFeedback.UseVisualStyleBackColor = true;
            this.enviarFeedback.Click += new System.EventHandler(this.enviarFeedback_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 468);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(327, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(372, 495);
            this.Controls.Add(this.comentario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dificuldades);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recursos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExperiencia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.enviarFeedback);
            this.MaximizeBox = false;
            this.Name = "FeedBack";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FeedBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TrackBar txtExperiencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recursos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dificuldades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox comentario;
        private System.Windows.Forms.Button enviarFeedback;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}