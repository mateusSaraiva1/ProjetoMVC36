﻿namespace ProjetoMVC2020
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
            this.txt_nomemaeb32 = new System.Windows.Forms.TextBox();
            this.txt_nomeb32 = new System.Windows.Forms.TextBox();
            this.txt_cpfb32 = new System.Windows.Forms.TextBox();
            this.lbl_mae = new System.Windows.Forms.Label();
            this.lbl_nomecom = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nomemaeb32
            // 
            this.txt_nomemaeb32.Location = new System.Drawing.Point(99, 234);
            this.txt_nomemaeb32.Name = "txt_nomemaeb32";
            this.txt_nomemaeb32.Size = new System.Drawing.Size(248, 20);
            this.txt_nomemaeb32.TabIndex = 13;
            // 
            // txt_nomeb32
            // 
            this.txt_nomeb32.Location = new System.Drawing.Point(99, 165);
            this.txt_nomeb32.Name = "txt_nomeb32";
            this.txt_nomeb32.Size = new System.Drawing.Size(248, 20);
            this.txt_nomeb32.TabIndex = 12;
            // 
            // txt_cpfb32
            // 
            this.txt_cpfb32.Location = new System.Drawing.Point(99, 93);
            this.txt_cpfb32.Name = "txt_cpfb32";
            this.txt_cpfb32.Size = new System.Drawing.Size(248, 20);
            this.txt_cpfb32.TabIndex = 11;
            // 
            // lbl_mae
            // 
            this.lbl_mae.AutoSize = true;
            this.lbl_mae.Location = new System.Drawing.Point(104, 203);
            this.lbl_mae.Name = "lbl_mae";
            this.lbl_mae.Size = new System.Drawing.Size(77, 13);
            this.lbl_mae.TabIndex = 10;
            this.lbl_mae.Text = "Nome da Mãe:";
            // 
            // lbl_nomecom
            // 
            this.lbl_nomecom.AutoSize = true;
            this.lbl_nomecom.Location = new System.Drawing.Point(104, 137);
            this.lbl_nomecom.Name = "lbl_nomecom";
            this.lbl_nomecom.Size = new System.Drawing.Size(85, 13);
            this.lbl_nomecom.TabIndex = 9;
            this.lbl_nomecom.Text = "Nome Completo:";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(104, 68);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(30, 13);
            this.lbl_cpf.TabIndex = 8;
            this.lbl_cpf.Text = "CPF:";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Lime;
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_enviar.Location = new System.Drawing.Point(226, 271);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(121, 41);
            this.btn_enviar.TabIndex = 15;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_sair.Location = new System.Drawing.Point(99, 271);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(121, 41);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(467, 397);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_nomemaeb32);
            this.Controls.Add(this.txt_nomeb32);
            this.Controls.Add(this.txt_cpfb32);
            this.Controls.Add(this.lbl_mae);
            this.Controls.Add(this.lbl_nomecom);
            this.Controls.Add(this.lbl_cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomemaeb32;
        private System.Windows.Forms.TextBox txt_nomeb32;
        private System.Windows.Forms.TextBox txt_cpfb32;
        private System.Windows.Forms.Label lbl_mae;
        private System.Windows.Forms.Label lbl_nomecom;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_sair;
    }
}

