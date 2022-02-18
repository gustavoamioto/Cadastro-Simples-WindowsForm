using MySql.Data.MySqlClient;
namespace projetoum
{
    public partial class form_cadastro : Form
    {
        public form_cadastro()
        {
            InitializeComponent();
        }

        private void botao_cadastrar_Click(object sender, EventArgs e)
        {
            Funcoesbd funcao = new Funcoesbd();
            funcao.inserir(txt_nome.Text,txt_cpf.Text,txt_telefone.Text,txt_endereco.Text,txt_email.Text);
        }

        private void botao_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            form_excluir_cliente excluir_cliente = new form_excluir_cliente();
            excluir_cliente.Show();        
        }
    }
}