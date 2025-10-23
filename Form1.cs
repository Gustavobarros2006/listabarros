using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listabarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // Adiciona o texto da TextBox à ListBox
                listBox1.Items.Add(textBox1.Text);

                // Opcional: Limpa a TextBox após adicionar o item
                textBox1.Text = "";

                // Opcional: Coloca o foco de volta na TextBox para facilitar a adição de múltiplos itens
                textBox1.Focus();
            }
            else
            {
                // Opcional: Exibe uma mensagem se o usuário tentar adicionar um item vazio
                MessageBox.Show("Por favor, digite um texto para adicionar.");
            }
        }
    }
}
