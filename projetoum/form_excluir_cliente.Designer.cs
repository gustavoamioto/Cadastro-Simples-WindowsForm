namespace projetoum
{
    partial class form_excluir_cliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botao_excluir = new System.Windows.Forms.Button();
            this.botao_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(540, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // botao_excluir
            // 
            this.botao_excluir.Location = new System.Drawing.Point(128, 347);
            this.botao_excluir.Name = "botao_excluir";
            this.botao_excluir.Size = new System.Drawing.Size(75, 23);
            this.botao_excluir.TabIndex = 17;
            this.botao_excluir.Text = "Excluir";
            this.botao_excluir.UseVisualStyleBackColor = true;
            this.botao_excluir.Click += new System.EventHandler(this.botao_excluir_Click);
            // 
            // botao_fechar
            // 
            this.botao_fechar.Location = new System.Drawing.Point(593, 347);
            this.botao_fechar.Name = "botao_fechar";
            this.botao_fechar.Size = new System.Drawing.Size(75, 23);
            this.botao_fechar.TabIndex = 18;
            this.botao_fechar.Text = "Fechar";
            this.botao_fechar.UseVisualStyleBackColor = true;
            // 
            // form_excluir_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botao_fechar);
            this.Controls.Add(this.botao_excluir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_excluir_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Cliente";
            this.Load += new System.EventHandler(this.form_excluir_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button botao_excluir;
        private Button botao_fechar;
    }
}