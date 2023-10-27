namespace appExenploexcel.formularios
{
    partial class FormCadastrar
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
            this.lbcadastro = new System.Windows.Forms.Label();
            this.tbCadastro = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPf = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbcadastro
            // 
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcadastro.Location = new System.Drawing.Point(311, 45);
            this.lbcadastro.Margin = new System.Windows.Forms.Padding(6);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(239, 26);
            this.lbcadastro.TabIndex = 0;
            this.lbcadastro.Text = "Cadastro de Pessoas";
            // 
            // tbCadastro
            // 
            this.tbCadastro.Location = new System.Drawing.Point(48, 131);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCadastro.Size = new System.Drawing.Size(331, 20);
            this.tbCadastro.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(45, 99);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(58, 18);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // lbCPf
            // 
            this.lbCPf.AutoSize = true;
            this.lbCPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPf.Location = new System.Drawing.Point(45, 218);
            this.lbCPf.Name = "lbCPf";
            this.lbCPf.Size = new System.Drawing.Size(46, 18);
            this.lbCPf.TabIndex = 4;
            this.lbCPf.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(48, 250);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCPF.Size = new System.Drawing.Size(331, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRG.Location = new System.Drawing.Point(391, 218);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(38, 18);
            this.lbRG.TabIndex = 6;
            this.lbRG.Text = "RG:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(394, 250);
            this.txtRG.Name = "txtRG";
            this.txtRG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRG.Size = new System.Drawing.Size(331, 20);
            this.txtRG.TabIndex = 5;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(156, 344);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(131, 36);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(428, 344);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(131, 36);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbRG);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.lbCPf);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbCadastro);
            this.Controls.Add(this.lbcadastro);
            this.Name = "FormCadastrar";
            this.Text = "FormListar";
            this.Load += new System.EventHandler(this.FormListar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcadastro;
        private System.Windows.Forms.TextBox tbCadastro;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCPf;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btCancelar;
    }
}