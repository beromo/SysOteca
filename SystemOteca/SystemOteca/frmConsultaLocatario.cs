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
    public partial class frmConsultaLocatario : Form
    {
        private frmDevolucao frmDev;

        public frmConsultaLocatario()
        {
            InitializeComponent();
        }
        public frmConsultaLocatario(frmDevolucao frm)
        {
            frmDev = frm;
            InitializeComponent();
        }
        private void locatarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locatarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDSystemDataSet);

        }

        private void frmConsultaLocatario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDSystemDataSet.Locatario'. Você pode movê-la ou removê-la conforme necessário.
            this.locatarioTableAdapter.Fill(this.bDSystemDataSet.Locatario);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.locatarioTableAdapter.FillByLikeNomeLocatario(this.bDSystemDataSet.Locatario, textBox1.Text);
        }

        private void locatarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDev.setCodigoAndNomeLocatario(Convert.ToInt32(locatarioDataGridView.CurrentRow.Cells[0].Value.ToString()), 
                locatarioDataGridView.CurrentRow.Cells[1].Value.ToString());
            this.Dispose();
        }
    }
}
