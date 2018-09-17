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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }
                    System.IO.File.Copy(Application.StartupPath.ToString() + "\\BDSystem.accdb", saveFileDialog1.FileName);
                    MessageBox.Show("Backup Realizado com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operação Cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void locatárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadLocatario().ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadLivros frmcl = new frmCadLivros();
            frmcl.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadFuncionario().ShowDialog();
        }

        private void editoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadEditora().ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\BDSystem.accdb"))
                    {
                        System.IO.File.Delete(Application.StartupPath.ToString() + "\\BDSystem.accdb");
                    }
                    System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\BDSystem.accdb");
                    MessageBox.Show("Backup restaurado com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operação Cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }  
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            new frmCadLocacao().ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            new frmDevolucao().ShowDialog();
        }

        private void locatáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadLocacao().ShowDialog();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDevolucao().ShowDialog();
        }
    }
}
