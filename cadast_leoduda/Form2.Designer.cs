namespace cadast_leoduda
{
    partial class Form2
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
            this.btncad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomeprof = new System.Windows.Forms.TextBox();
            this.txttitprof = new System.Windows.Forms.TextBox();
            this.txtidadeprof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncad
            // 
            this.btncad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btncad.Location = new System.Drawing.Point(51, 285);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(111, 35);
            this.btncad.TabIndex = 0;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnomeprof
            // 
            this.txtnomeprof.Location = new System.Drawing.Point(221, 82);
            this.txtnomeprof.Multiline = true;
            this.txtnomeprof.Name = "txtnomeprof";
            this.txtnomeprof.Size = new System.Drawing.Size(122, 28);
            this.txtnomeprof.TabIndex = 2;
            this.txtnomeprof.TextChanged += new System.EventHandler(this.txtnomeprof_TextChanged);
            // 
            // txttitprof
            // 
            this.txttitprof.Location = new System.Drawing.Point(221, 184);
            this.txttitprof.Multiline = true;
            this.txttitprof.Name = "txttitprof";
            this.txttitprof.Size = new System.Drawing.Size(122, 28);
            this.txttitprof.TabIndex = 3;
            // 
            // txtidadeprof
            // 
            this.txtidadeprof.Location = new System.Drawing.Point(221, 132);
            this.txtidadeprof.Multiline = true;
            this.txtidadeprof.Name = "txtidadeprof";
            this.txtidadeprof.Size = new System.Drawing.Size(122, 28);
            this.txtidadeprof.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Idade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnvoltar.Location = new System.Drawing.Point(311, 285);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(111, 35);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnexibir.Location = new System.Drawing.Point(181, 285);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(111, 35);
            this.btnexibir.TabIndex = 8;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 359);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidadeprof);
            this.Controls.Add(this.txttitprof);
            this.Controls.Add(this.txtnomeprof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncad);
            this.Name = "Form2";
            this.Text = "Cadastro Professor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomeprof;
        private System.Windows.Forms.TextBox txttitprof;
        private System.Windows.Forms.TextBox txtidadeprof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexibir;
    }
}