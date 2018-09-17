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
    public partial class frmCadLocatario : Form
    {
        public frmCadLocatario()
        {
            InitializeComponent();
        }

        private void locatarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locatarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void frmCadLocatario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bDSystemDataSet.Locatario);

        }

        private void locatarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.locatarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.locatarioTableAdapter.Fill(this.bDSystemDataSet.Locatario);
                this.locatarioBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.locatarioTableAdapter.FillByLikeNomeLocatario(bDSystemDataSet.Locatario, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(idLocatarioTextBox.Text) > 0)
            {
                openFileDialog1.ShowDialog();
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                Bitmap bmp2 = new Bitmap(bmp, pictureBox2.Size);
                pictureBox2.Image = bmp2;
                pictureBox2.Image.Save(Application.StartupPath.ToString() + "\\fotosLocatario\\" + idLocatarioTextBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                fotoTextBox.Text = Application.StartupPath.ToString() + "\\fotosLocatario\\" + idLocatarioTextBox + ".png";
                this.Validate();
                this.locatarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
            }
            else
            {
                MessageBox.Show("Operação abortada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = Application.StartupPath.ToString() + "\\capasLivros\\" + "semCapa.jpg";

            if (fotoTextBox.Text != "")
            {
                if (System.IO.File.Exists(fotoTextBox.Text))
                {
                    System.IO.File.Delete(fotoTextBox.Text);
                }
                fotoTextBox.Text = "";
                this.Validate();
                this.locatarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse Locatario?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.locatarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);
                MessageBox.Show("Registro salvo com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.locatarioTableAdapter.Fill(this.bDSystemDataSet.Locatario);
            }
            else
            {
                this.locatarioTableAdapter.Fill(this.bDSystemDataSet.Locatario);
                MessageBox.Show("Operação abortada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
