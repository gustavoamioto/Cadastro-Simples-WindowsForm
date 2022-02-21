namespace projetoum
{
    partial class form_cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.botao_pesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.botao_cadastrar = new System.Windows.Forms.Button();
            this.botao_fechar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.botao_alterar = new System.Windows.Forms.Button();
            this.botao_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(178, 58);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(439, 23);
            this.txt_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(178, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(178, 125);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(164, 23);
            this.txt_cpf.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(178, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(178, 212);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(439, 23);
            this.txt_endereco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(453, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(453, 125);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(164, 23);
            this.txt_telefone.TabIndex = 6;
            // 
            // botao_pesquisar
            // 
            this.botao_pesquisar.BackgroundImage = global::projetocadastros.Properties.Resources.search_icon;
            this.botao_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_pesquisar.Image = global::projetocadastros.Properties.Resources.search_icon;
            this.botao_pesquisar.Location = new System.Drawing.Point(348, 124);
            this.botao_pesquisar.Name = "botao_pesquisar";
            this.botao_pesquisar.Size = new System.Drawing.Size(24, 24);
            this.botao_pesquisar.TabIndex = 8;
            this.botao_pesquisar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(178, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-Mail";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(178, 298);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(439, 23);
            this.txt_email.TabIndex = 9;
            // 
            // botao_cadastrar
            // 
            this.botao_cadastrar.Location = new System.Drawing.Point(178, 360);
            this.botao_cadastrar.Name = "botao_cadastrar";
            this.botao_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.botao_cadastrar.TabIndex = 11;
            this.botao_cadastrar.Text = "Cadastrar";
            this.botao_cadastrar.UseVisualStyleBackColor = true;
            this.botao_cadastrar.Click += new System.EventHandler(this.botao_cadastrar_Click);
            // 
            // botao_fechar
            // 
            this.botao_fechar.Location = new System.Drawing.Point(542, 360);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(75, 23);
            this.botao_fechar.TabIndex = 14;
            this.botao_fechar.Text = "Fechar";
            this.botao_fechar.UseVisualStyleBackColor = true;
            this.botao_fechar.Click += new System.EventHandler(this.botao_fechar_Click);
            // 
            // botao_alterar
            // 
            this.botao_alterar.Location = new System.Drawing.Point(267, 360);
            this.botao_alterar.Name = "botao_alterar";
            this.botao_alterar.Size = new System.Drawing.Size(75, 23);
            this.botao_alterar.TabIndex = 15;
            this.botao_alterar.Text = "Alterar";
            this.botao_alterar.UseVisualStyleBackColor = true;
            // 
            // botao_excluir
            // 
            this.botao_excluir.Location = new System.Drawing.Point(363, 360);
            this.botao_excluir.Name = "botao_excluir";
            this.botao_excluir.Size = new System.Drawing.Size(75, 23);
            this.botao_excluir.TabIndex = 16;
            this.botao_excluir.Text = "Excluir";
            this.botao_excluir.UseVisualStyleBackColor = true;
            this.botao_excluir.Click += new System.EventHandler(this.botao_excluir_Click);
            // 
            // form_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botao_excluir);
            this.Controls.Add(this.botao_alterar);
            this.Controls.Add(this.botao_fechar);
            this.Controls.Add(this.botao_cadastrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.botao_pesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Name = "form_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_nome;
        private Label label1;
        private Label label2;
        private TextBox txt_cpf;
        private Label label3;
        private TextBox txt_endereco;
        private Label label4;
        private TextBox txt_telefone;
        private Button botao_pesquisar;
        private Label label5;
        private TextBox txt_email;
        private Button botao_cadastrar;
        private Button botao_fechar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button botao_alterar;
        private Button botao_excluir;
    }
}