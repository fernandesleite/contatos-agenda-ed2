namespace AULA05_09_2019
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddFone = new System.Windows.Forms.Button();
            this.BtnRemFone = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnPesq = new System.Windows.Forms.Button();
            this.emailText = new System.Windows.Forms.TextBox();
            this.nomeText = new System.Windows.Forms.TextBox();
            this.numeroText = new System.Windows.Forms.TextBox();
            this.listNumero = new System.Windows.Forms.ListBox();
            this.listTipo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoText2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fones";
            // 
            // BtnAddFone
            // 
            this.BtnAddFone.Location = new System.Drawing.Point(147, 226);
            this.BtnAddFone.Name = "BtnAddFone";
            this.BtnAddFone.Size = new System.Drawing.Size(75, 23);
            this.BtnAddFone.TabIndex = 3;
            this.BtnAddFone.Text = "Add";
            this.BtnAddFone.UseVisualStyleBackColor = true;
            this.BtnAddFone.Click += new System.EventHandler(this.BtnAddFone_Click);
            // 
            // BtnRemFone
            // 
            this.BtnRemFone.Location = new System.Drawing.Point(282, 226);
            this.BtnRemFone.Name = "BtnRemFone";
            this.BtnRemFone.Size = new System.Drawing.Size(75, 23);
            this.BtnRemFone.TabIndex = 4;
            this.BtnRemFone.Text = "Remover Fone";
            this.BtnRemFone.UseVisualStyleBackColor = true;
            this.BtnRemFone.Click += new System.EventHandler(this.BtnRemFone_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 25);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(12, 86);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 6;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(12, 145);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnPesq
            // 
            this.BtnPesq.Location = new System.Drawing.Point(12, 204);
            this.BtnPesq.Name = "BtnPesq";
            this.BtnPesq.Size = new System.Drawing.Size(75, 23);
            this.BtnPesq.TabIndex = 8;
            this.BtnPesq.Text = "Pesquisar";
            this.BtnPesq.UseVisualStyleBackColor = true;
            this.BtnPesq.Click += new System.EventHandler(this.BtnPesq_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(135, 6);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 9;
            // 
            // nomeText
            // 
            this.nomeText.Location = new System.Drawing.Point(282, 6);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(100, 20);
            this.nomeText.TabIndex = 10;
            // 
            // numeroText
            // 
            this.numeroText.Location = new System.Drawing.Point(135, 183);
            this.numeroText.Name = "numeroText";
            this.numeroText.Size = new System.Drawing.Size(100, 20);
            this.numeroText.TabIndex = 11;
            // 
            // listNumero
            // 
            this.listNumero.FormattingEnabled = true;
            this.listNumero.Location = new System.Drawing.Point(135, 53);
            this.listNumero.Name = "listNumero";
            this.listNumero.Size = new System.Drawing.Size(120, 95);
            this.listNumero.TabIndex = 13;
            // 
            // listTipo
            // 
            this.listTipo.FormattingEnabled = true;
            this.listTipo.Location = new System.Drawing.Point(254, 53);
            this.listTipo.Name = "listTipo";
            this.listTipo.Size = new System.Drawing.Size(120, 95);
            this.listTipo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nº";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo";
            // 
            // tipoText2
            // 
            this.tipoText2.FormattingEnabled = true;
            this.tipoText2.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Celular"});
            this.tipoText2.Location = new System.Drawing.Point(257, 182);
            this.tipoText2.Name = "tipoText2";
            this.tipoText2.Size = new System.Drawing.Size(121, 21);
            this.tipoText2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 273);
            this.Controls.Add(this.tipoText2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listTipo);
            this.Controls.Add(this.listNumero);
            this.Controls.Add(this.numeroText);
            this.Controls.Add(this.nomeText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.BtnPesq);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.BtnRemFone);
            this.Controls.Add(this.BtnAddFone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddFone;
        private System.Windows.Forms.Button BtnRemFone;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnPesq;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox nomeText;
        private System.Windows.Forms.TextBox numeroText;
        private System.Windows.Forms.ListBox listNumero;
        private System.Windows.Forms.ListBox listTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoText2;
    }
}

