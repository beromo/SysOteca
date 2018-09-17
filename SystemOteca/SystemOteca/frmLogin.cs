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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = funcionarioTableAdapter.FillByFuncionarioLogin(bDSystemDataSet.Funcionario, textBox1.Text, textBox3.Text);
            if (result == 1)
            {
                frmPrincipal frmp = new frmPrincipal();
                frmp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos", "Ocorreu um Erro ao Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void funcionarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.bDSystemDataSet.Funcionario);

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int result = funcionarioTableAdapter.FillByFuncionarioLogin(bDSystemDataSet.Funcionario, textBox1.Text, textBox3.Text);
                if (result == 1)
                {
                    frmPrincipal frmp = new frmPrincipal();
                    frmp.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos", "Ocorreu um Erro ao Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
