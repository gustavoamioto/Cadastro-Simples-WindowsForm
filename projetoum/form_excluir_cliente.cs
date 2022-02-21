using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoum
{
    public partial class form_excluir_cliente : Form
    {
        public form_excluir_cliente()
        {
            InitializeComponent();
        }

        private void form_excluir_cliente_Load(object sender, EventArgs e)
        {
            Funcoesbd funcao = new Funcoesbd();
            dataGridView1.DataSource = funcao.carregar_grade();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Remover o Cliente?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if(resultado == DialogResult.Yes)
            {
                int id = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
                Funcoesbd funcao_excluir = new Funcoesbd();
                funcao_excluir.excluir(id);

                MessageBox.Show("Excluido com Sucesso!");
            }
            else if(resultado == DialogResult.No)
            {
                MessageBox.Show("Solicitação de Exclusão Cancelada!");
            }
            
            Funcoesbd funcao = new Funcoesbd();
            dataGridView1.DataSource = funcao.carregar_grade();
        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
