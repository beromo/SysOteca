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
    public partial class frmCadLocacao : Form
    {
        public frmCadLocacao()
        {
            InitializeComponent();
        }

        private void AlterarData()
        {
            dataSaidaDateTimePicker.Text = DateTime.Now.ToShortDateString();
            horaDateTimePicker.Text = DateTime.Now.ToShortTimeString();
            dataEntregaDateTimePicker.Text = DateTime.Now.AddDays(8).ToShortTimeString();
        }

        private void locacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void frmCadLocacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.bDSystemDataSet.Livro);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.ItemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            this.itemLocacaoTableAdapter.Fill(this.bDSystemDataSet.ItemLocacao);
            this.locacaoBindingSource.AddNew();
            AlterarData();
            locacaoBindingNavigatorSaveItem_Click(sender, e);

            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bDSystemDataSet.Locatario);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Locacao'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableAdapter.Fill(this.bDSystemDataSet.Locacao);

            this.locacaoBindingSource.MoveLast();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AlterarData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmCadLocacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                comboBox1.SelectedValue = idLocatarioTextBox.Text;

                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Locatário Não Cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idLocatarioTextBox.Text = comboBox1.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((idLocacaoTextBox.Text != "") && (comboBox1.Text != ""))
            {
                if (itemLocacaoDataGridView.RowCount > 1)
                {
                    locacaoBindingNavigatorSaveItem_Click(sender, e);
                    MessageBox.Show("Locação realizada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Informe o Livros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe o Locatário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int idx;
            bool flag = false;
            try
            {
                if (e.KeyChar == 13)
                {
                    idx = this.livroTableAdapter.FillByIdLivro(bDSystemDataSet.Livro, Convert.ToInt32(textBox1.Text));

                    this.livroTableAdapter.Fill(bDSystemDataSet.Livro);

                    if (idx == 1)
                    {
                        String Titulo = this.bDSystemDataSet.Livro.FindByidLivro(Convert.ToInt32(textBox1.Text)).Titulo;
                        for (int i = 0; i < itemLocacaoDataGridView.RowCount; i++)
                        {
                            if (itemLocacaoDataGridView[2, i].EditedFormattedValue.ToString() == Titulo)
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag)
                        {
                            MessageBox.Show("Livro não foi encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.bDSystemDataSet.ItemLocacao.Rows.Add(null, Convert.ToInt32(idLocacaoTextBox.Text), Convert.ToInt32(textBox1.Text), null);
                        }
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Livro não foi encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.itemLocacaoBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
