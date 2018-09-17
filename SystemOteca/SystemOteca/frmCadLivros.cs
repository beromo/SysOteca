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
    public partial class frmCadLivros : Form
    {
        public frmCadLivros()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Editora'. Você pode movê-la ou removê-la conforme necessário.
            this.editoraTableAdapter.Fill(this.bDSystemDataSet.Editora);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.ItemLocacao'. Você pode movê-la ou removê-la conforme necessário.
            this.itemLocacaoTableAdapter.Fill(this.bDSystemDataSet.ItemLocacao);
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Livro'. Você pode movê-la ou removê-la conforme necessário.
            this.livroTableAdapter.Fill(this.bDSystemDataSet.Livro);

        }

        private void livroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void livroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.livroBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.livroTableAdapter.Fill(this.bDSystemDataSet.Livro);
                this.livroBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse livro", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.livroBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.livroTableAdapter.Fill(this.bDSystemDataSet.Livro);
            }
            else
            {
                this.livroTableAdapter.Fill(this.bDSystemDataSet.Livro);
                MessageBox.Show("Operação abortada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(idLivroTextBox.Text) > 0)
            {
                openFileDialog1.ShowDialog();
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pictureBox2.Size);
                pictureBox2.Image = bmp2;
                pictureBox2.Image.Save(Application.StartupPath.ToString() + "\\capasLivros\\" + idLivroTextBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                capaTextBox.Text = Application.StartupPath.ToString() + "\\capasLivros\\" + idLivroTextBox + ".png";
                this.Validate();
                this.livroBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
            }
            else
            {
                MessageBox.Show("Operação abortada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (capaTextBox.Text != "")
            {
                pictureBox2.ImageLocation = capaTextBox.Text;
            }
            else
            {
                pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\capasLivros\\" + "semCapa.jpg";


            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\capasLivros\\" + "semCapa.jpg";

            if (capaTextBox.Text != "")
            {
                if (System.IO.File.Exists(capaTextBox.Text))
                {
                    System.IO.File.Delete(capaTextBox.Text);
                }
                capaTextBox.Text = "";
                this.Validate();
                this.livroBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
