using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using MySql;

using MySql.Data.MySqlClient;





namespace CadastroAluno

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }



        private void buttonSalvar_Click(object sender, EventArgs e)

        {

            MySqlConnection con = null;

            MySqlCommand cmd = null;

            try

            {

                string ra = textBoxRa.Text;

                string nome = textBoxNome.Text;

                string curso = textBoxCurso.Text;

                string senha = textBoxSenha.Text;



                string sql = "";

                if (ra == "")
                {

                    sql = $"insert into aluno(nome, curso, senha) values('{nome}','{curso}','{senha}')";

                }
                else
                {

                    sql = $"update aluno set nome='{nome}', curso='{curso}', senha='{senha}' where ra={ra}";

                }



                con = new MySqlConnection("server=localhost;uid=root;pwd='';database=uninove;UseAffectedRows=true");

                cmd = new MySqlCommand(sql, con);



                con.Open();

                int qtdlinha = cmd.ExecuteNonQuery();



                if (qtdlinha > 0)

                {

                    MessageBox.Show("Dados salvos com sucesso!");

                }

                else

                {

                    throw new Exception();

                }

            }
            catch (Exception ex)

            {

                MessageBox.Show("Não foi possível salvar!");

            }

            finally

            {

                con.Close();

                con.Dispose();

                cmd.Dispose();

            }

        }



        private void buttonExcluir_Click(object sender, EventArgs e)

        {

            MySqlConnection con = null;

            MySqlCommand cmd = null;

            try

            {

                string ra = textBoxRa.Text;

                string sql = $"delete from aluno where ra={ra}";



                con = new MySqlConnection("server=localhost;uid=root;pwd='';database=uninove;UseAffectedRows=true");

                cmd = new MySqlCommand(sql, con);



                con.Open();

                int qtdlinha = cmd.ExecuteNonQuery();



                if (qtdlinha > 0)

                {

                    MessageBox.Show("Dados excluídos com sucesso!");

                }

                else

                {

                    throw new Exception();

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Não foi possível excluir!");

            }

            finally

            {

                con.Close();

                con.Dispose();

                cmd.Dispose();

            }

        }

    }

}