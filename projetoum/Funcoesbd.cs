using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace projetoum
{
    class Funcoesbd

    {
        MySqlConnection Conexao = new MySqlConnection("server = localhost; port = 3306; database = cadastro; uid = root; pwd = ");

        public void inserir(string p1,string p2, string p3, string p4, string p5)
        {           
            MySqlCommand comando = new MySqlCommand("INSERT INTO CLIENTES (NOME,CPF,TELEFONE,ENDERECO,EMAIL) VALUES (@p1, @p2, @p3, @p4, @p5)", Conexao);

            comando.Parameters.AddWithValue("p1", p1);
            comando.Parameters.AddWithValue("p2", p2);
            comando.Parameters.AddWithValue("p3", p3);
            comando.Parameters.AddWithValue("p4", p4);
            comando.Parameters.AddWithValue("p5", p5);

            Conexao.Open();

            comando.ExecuteNonQuery();

            MessageBox.Show("Cliente Registrado(a)!");

            Conexao.Close();
        }

        public void excluir(string nome)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM CLIENTES WHERE NOME = @parametro", Conexao);

            comando.Parameters.AddWithValue("parametro", nome);

            Conexao.Open();

            comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public DataTable carregar_grade()
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM CLIENTES", Conexao);

            Conexao.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(comando);

            DataTable tabela_temporaria = new DataTable();

            da.Fill(tabela_temporaria);

            return tabela_temporaria;
        }
    }
}
