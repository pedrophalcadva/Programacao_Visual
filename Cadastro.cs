using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar(object sender, EventArgs e)
        {
            openFileDialogFoto.ShowDialog();
        }

        private void selecionar(object sender, CancelEventArgs e)
        {
            OpenFileDialog open = (OpenFileDialog)sender;
            textBoxFoto.Text = open.FileName;
            pictureBoxFoto.Image = Image.FromFile(open.FileName);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salvar(object sender, EventArgs e)
        {
            string foto = textBoxFoto.Text;
            string nome = textBoxNome.Text;
            string curso = comboBoxCurso.Text;
            string sexo = radioButtonMasculino.Checked?"Masc":"Fem";
            string dtNasc = dateTimePickerNasc.Text;
            string bolsista = checkBoxBolsista.Checked?"Sim":"Não";

            DataTable dt = (DataTable)dataGridView1.DataSource;
                if (dt == null)
                {
                dt = new DataTable();
                dt.Columns.Add("foto");
                dt.Columns.Add("nome");
                dt.Columns.Add("curso");
                dt.Columns.Add("sexo");
                dt.Columns.Add("dtNasc");
                dt.Columns.Add("bolsista");
            }
            DataRow dr = dt.NewRow();
            dr["foto"] = foto;
            dr["nome"] = nome;
            dr["curso"] = curso;
            dr["sexo"] = sexo;
            dr["dtNasc"] = dtNasc;
            dr["bosista"] = "bolsista";

            dt.Rows.Add(dr);

            dataGridView1.DataSource = dt;
        }
    }
}
