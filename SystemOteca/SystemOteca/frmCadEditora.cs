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
    public partial class frmCadEditora : Form
    {
        public frmCadEditora()
        {
            InitializeComponent();
        }


        private void frmCadEditora_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Editora'. Você pode movê-la ou removê-la conforme necessário.
            this.editoraTableAdapter.Fill(this.bDSystemDataSet.Editora);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Editora'. Você pode movê-la ou removê-la conforme necessário.
            this.editoraTableAdapter.Fill(this.bDSystemDataSet.Editora);


        }

        private void editoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.editoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void editoraBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.editoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void editoraBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.editoraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
                MessageBox.Show("Registro Salvo com Sucesso", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar o registro", "Informa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.editoraBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
            }
            else
            {
                this.editoraTableAdapter.Fill(this.bDSystemDataSet.Editora);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.editoraTableAdapter.FillByEditoraNome(bDSystemDataSet.Editora, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
