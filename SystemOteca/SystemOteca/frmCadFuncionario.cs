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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }


        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDSystemDataSet.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDSystemDataSet.Funcionario);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDSystemDataSet.Funcionario);

        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void funcionarioBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            if (senhaTextBox.Text == textBox2.Text)
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
                MessageBox.Show("Registro Salvo", " Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.funcionarioTableAdapter.Fill(this.bDSystemDataSet.Funcionario);
                this.funcionarioBindingSource.MoveLast();
            }
            else
            {
                MessageBox.Show("Senhas não são iguais", " Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void idFuncionarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro", "Questionamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.funcionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
                MessageBox.Show("Registro excluido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação abortada", "Abortada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.funcionarioTableAdapter.Fill(this.bDSystemDataSet.Funcionario);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
            MessageBox.Show("Registro Salvo", " Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.funcionarioTableAdapter.Fill(this.bDSystemDataSet.Funcionario);
            this.funcionarioBindingSource.MoveLast();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.funcionarioTableAdapter.FillByNome(bDSystemDataSet.Funcionario, textBox1.Text);
        }
    }
}
