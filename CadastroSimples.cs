using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string sql = "insert into aluno(nome) values('Karol')";

            MySqlConnection conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database='uninove'");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql,conexao);

            comando.ExecuteNonQuery();

            conexao.Close();
            conexao.Dispose();
            comando.Dispose();

            MessageBox.Show("Dados salvos com sucesso!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            string sql = "update aluno set nome='Aline'";

            MySqlConnection conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database='uninove'");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.ExecuteNonQuery();

            conexao.Close();
            conexao.Dispose();
            comando.Dispose();

            MessageBox.Show("Dados Alterados com sucesso!");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from aluno";

            MySqlConnection conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database='uninove'");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.ExecuteNonQuery();

            conexao.Close();
            conexao.Dispose();
            comando.Dispose();

            MessageBox.Show("Dados Excluídos com sucesso!");
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string sql = "select * from aluno";

            MySqlConnection conexao = new MySqlConnection("server=localhost; uid=root; pwd=''; database='uninove'");
            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            MySqlDataReader dr = comando.ExecuteReader();
            listBoxAluno.Items.Clear();
            while (dr.Read())
            {
                listBoxAluno.Items.Add(dr["nome"]);
            }

            conexao.Close();
            conexao.Dispose();
            comando.Dispose();

            MessageBox.Show("Dados Encontrados com sucesso!");
        }
    }
}
