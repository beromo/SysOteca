using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOteca
{
    public partial class frmDevolucao : Form
    {
        public frmDevolucao()
        {
            InitializeComponent();
        }

        private void itemLocacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemLocacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void frmDevolucao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.bDSystemDataSet.Livro);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bDSystemDataSet.Locatario);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.ItemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            //this.itemLocacaoTableAdapter.Fill(this.bDSystemDataSet.ItemLocacao);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == 13)
            {
                consultaLocatario();
            }
        }
        private void consultaLocatario()
        {
            int contUsuario = this.locatarioTableAdapter.FillByIdLocatario(this.bDSystemDataSet.Locatario, Convert.ToInt32(textBox1.Text));

            if (contUsuario == 1)
            {
                textBox2.Text = this.bDSystemDataSet.Locatario.FindByidLocatario(Convert.ToInt32(textBox1.Text)).Nome;

                int contLocacoes = itemLocacaoTableAdapter.FillByIdLocatario(this.bDSystemDataSet.ItemLocacao, Convert.ToInt32(textBox1.Text));
                   
                if (contLocacoes == 0)
                {
                    MessageBox.Show("O Locatário não possui locações pendentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                textBox2.Clear();
                bDSystemDataSet.Locacao.Clear();
                MessageBox.Show("Usuario não existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmConsultaLocatario(this).ShowDialog();
        }

        public void setCodigoAndNomeLocatario(int codigo, String nome)
        {
            textBox1.Text = Convert.ToString(codigo);
            textBox2.Text = nome;
            consultaLocatario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < itemLocacaoDataGridView.Rows.Count; i++)
            {
                if (bool.Parse(itemLocacaoDataGridView[0,1].EditedFormattedValue.ToString()))
                {
                    itemLocacaoDataGridView[4, 1].Value = dateTimePicker1.Value;
                }
            }
            itemLocacaoDataGridView.EndEdit();
            tableAdapterManager.UpdateAll(this.bDSystemDataSet);

            MessageBox.Show("Devolução Efetuada com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
        }
    }
}
