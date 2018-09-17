namespace SystemOteca
{
    partial class frmDevolucao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label dataSaidaLabel;
            System.Windows.Forms.Label dataEntregaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.itemLocacaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemLocacaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itemLocacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.itemLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSystemDataSet = new SystemOteca.BDSystemDataSet();
            this.itemLocacaoTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.ItemLocacaoTableAdapter();
            this.tableAdapterManager = new SystemOteca.BDSystemDataSetTableAdapters.TableAdapterManager();
            this.locatarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locatarioTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.LocatarioTableAdapter();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livroTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.LivroTableAdapter();
            this.Devolver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            horaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            dataEntregaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingNavigator)).BeginInit();
            this.itemLocacaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(6, 88);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(88, 13);
            horaLabel.TabIndex = 6;
            horaLabel.Text = "Data Devolução:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.Location = new System.Drawing.Point(6, 31);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(43, 13);
            dataSaidaLabel.TabIndex = 8;
            dataSaidaLabel.Text = "Codigo:";
            // 
            // dataEntregaLabel
            // 
            dataEntregaLabel.AutoSize = true;
            dataEntregaLabel.Location = new System.Drawing.Point(115, 32);
            dataEntregaLabel.Name = "dataEntregaLabel";
            dataEntregaLabel.Size = new System.Drawing.Size(38, 13);
            dataEntregaLabel.TabIndex = 10;
            dataEntregaLabel.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemOteca.Properties.Resources.BibliotecaUbN640;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(horaLabel);
            this.groupBox1.Controls.Add(dataSaidaLabel);
            this.groupBox1.Controls.Add(dataEntregaLabel);
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 156);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário e Dada Devolução";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // itemLocacaoBindingNavigator
            // 
            this.itemLocacaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemLocacaoBindingNavigator.BindingSource = this.itemLocacaoBindingSource;
            this.itemLocacaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemLocacaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemLocacaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.itemLocacaoBindingNavigatorSaveItem});
            this.itemLocacaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemLocacaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemLocacaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemLocacaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemLocacaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemLocacaoBindingNavigator.Name = "itemLocacaoBindingNavigator";
            this.itemLocacaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemLocacaoBindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.itemLocacaoBindingNavigator.TabIndex = 15;
            this.itemLocacaoBindingNavigator.Text = "bindingNavigator1";
            this.itemLocacaoBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // itemLocacaoBindingNavigatorSaveItem
            // 
            this.itemLocacaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemLocacaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemLocacaoBindingNavigatorSaveItem.Image")));
            this.itemLocacaoBindingNavigatorSaveItem.Name = "itemLocacaoBindingNavigatorSaveItem";
            this.itemLocacaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemLocacaoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.itemLocacaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemLocacaoBindingNavigatorSaveItem_Click);
            // 
            // itemLocacaoDataGridView
            // 
            this.itemLocacaoDataGridView.AutoGenerateColumns = false;
            this.itemLocacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemLocacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Devolver,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemLocacaoDataGridView.DataSource = this.itemLocacaoBindingSource;
            this.itemLocacaoDataGridView.Location = new System.Drawing.Point(125, 174);
            this.itemLocacaoDataGridView.Name = "itemLocacaoDataGridView";
            this.itemLocacaoDataGridView.Size = new System.Drawing.Size(405, 190);
            this.itemLocacaoDataGridView.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Devolver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemLocacaoBindingSource
            // 
            this.itemLocacaoBindingSource.DataMember = "ItemLocacao";
            this.itemLocacaoBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // bDSystemDataSet
            // 
            this.bDSystemDataSet.DataSetName = "BDSystemDataSet";
            this.bDSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemLocacaoTableAdapter
            // 
            this.itemLocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = this.itemLocacaoTableAdapter;
            this.tableAdapterManager.LivroTableAdapter = null;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.LocatarioTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SystemOteca.BDSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // locatarioBindingSource
            // 
            this.locatarioBindingSource.DataMember = "Locatario";
            this.locatarioBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // locatarioTableAdapter
            // 
            this.locatarioTableAdapter.ClearBeforeFill = true;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // Devolver
            // 
            this.Devolver.HeaderText = "Devolver";
            this.Devolver.Name = "Devolver";
            this.Devolver.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idItem";
            this.dataGridViewTextBoxColumn1.HeaderText = "idItem";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idLocacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "idLocacao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idLivro";
            this.dataGridViewTextBoxColumn3.DataSource = this.livroBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Título do Livro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idLivro";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // frmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemLocacaoDataGridView);
            this.Controls.Add(this.itemLocacaoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDevolucao";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.frmDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingNavigator)).EndInit();
            this.itemLocacaoBindingNavigator.ResumeLayout(false);
            this.itemLocacaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private BDSystemDataSet bDSystemDataSet;
        private System.Windows.Forms.BindingSource itemLocacaoBindingSource;
        private BDSystemDataSetTableAdapters.ItemLocacaoTableAdapter itemLocacaoTableAdapter;
        private BDSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemLocacaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton itemLocacaoBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView itemLocacaoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource locatarioBindingSource;
        private BDSystemDataSetTableAdapters.LocatarioTableAdapter locatarioTableAdapter;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private BDSystemDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Devolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}