﻿namespace controle_de_estoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbxusuario = new System.Windows.Forms.TextBox();
            this.tbxsenha = new System.Windows.Forms.TextBox();
            this.lblinkesqs = new System.Windows.Forms.LinkLabel();
            this.lblinkCriarConta = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(156, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(174, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(296, 266);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(104, 32);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // tbxusuario
            // 
            this.tbxusuario.Location = new System.Drawing.Point(256, 183);
            this.tbxusuario.Name = "tbxusuario";
            this.tbxusuario.Size = new System.Drawing.Size(193, 26);
            this.tbxusuario.TabIndex = 3;
            // 
            // tbxsenha
            // 
            this.tbxsenha.Location = new System.Drawing.Point(256, 220);
            this.tbxsenha.Name = "tbxsenha";
            this.tbxsenha.Size = new System.Drawing.Size(193, 26);
            this.tbxsenha.TabIndex = 4;
            this.tbxsenha.UseSystemPasswordChar = true;
            // 
            // lblinkesqs
            // 
            this.lblinkesqs.AutoSize = true;
            this.lblinkesqs.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.lblinkesqs.Location = new System.Drawing.Point(364, 327);
            this.lblinkesqs.Name = "lblinkesqs";
            this.lblinkesqs.Size = new System.Drawing.Size(154, 20);
            this.lblinkesqs.TabIndex = 7;
            this.lblinkesqs.TabStop = true;
            this.lblinkesqs.Text = "Esqueceu a Senha?";
            this.lblinkesqs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblinkCriarConta
            // 
            this.lblinkCriarConta.AutoSize = true;
            this.lblinkCriarConta.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.lblinkCriarConta.Location = new System.Drawing.Point(210, 327);
            this.lblinkCriarConta.Name = "lblinkCriarConta";
            this.lblinkCriarConta.Size = new System.Drawing.Size(119, 20);
            this.lblinkCriarConta.TabIndex = 8;
            this.lblinkCriarConta.TabStop = true;
            this.lblinkCriarConta.Text = "Crie uma Conta";
            this.lblinkCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblinkCriarConta_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(338, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "|";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News701 BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(299, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 39);
            this.label5.TabIndex = 18;
            this.label5.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(691, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblinkCriarConta);
            this.Controls.Add(this.lblinkesqs);
            this.Controls.Add(this.tbxsenha);
            this.Controls.Add(this.tbxusuario);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbxusuario;
        private System.Windows.Forms.TextBox tbxsenha;
        private System.Windows.Forms.LinkLabel lblinkesqs;
        private System.Windows.Forms.LinkLabel lblinkCriarConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

