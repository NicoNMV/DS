namespace cadast_leoduda
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
            this.btncadprof = new System.Windows.Forms.Button();
            this.btncadaluno = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncadprof
            // 
            this.btncadprof.Location = new System.Drawing.Point(35, 95);
            this.btncadprof.Name = "btncadprof";
            this.btncadprof.Size = new System.Drawing.Size(118, 34);
            this.btncadprof.TabIndex = 0;
            this.btncadprof.Text = "Cadastrar Professor";
            this.btncadprof.UseVisualStyleBackColor = true;
            this.btncadprof.Click += new System.EventHandler(this.btncadprof_Click);
            // 
            // btncadaluno
            // 
            this.btncadaluno.Location = new System.Drawing.Point(162, 95);
            this.btncadaluno.Name = "btncadaluno";
            this.btncadaluno.Size = new System.Drawing.Size(118, 34);
            this.btncadaluno.TabIndex = 1;
            this.btncadaluno.Text = "Cadastrar Aluno";
            this.btncadaluno.UseVisualStyleBackColor = true;
            this.btncadaluno.Click += new System.EventHandler(this.btncadaluno_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(290, 95);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(118, 34);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 234);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncadaluno);
            this.Controls.Add(this.btncadprof);
            this.Name = "Form1";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncadprof;
        private System.Windows.Forms.Button btncadaluno;
        private System.Windows.Forms.Button btnsair;
    }
}

