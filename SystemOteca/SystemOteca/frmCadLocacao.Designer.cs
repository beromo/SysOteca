namespace SystemOteca
{
    partial class frmCadLocacao
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
            System.Windows.Forms.Label idLocacaoLabel;
            System.Windows.Forms.Label idLocatarioLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label dataSaidaLabel;
            System.Windows.Forms.Label dataEntregaLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSystemDataSet = new SystemOteca.BDSystemDataSet();
            this.locatarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.idLocatarioTextBox = new System.Windows.Forms.TextBox();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataSaidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataEntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locacaoTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.LocacaoTableAdapter();
            this.tableAdapterManager = new SystemOteca.BDSystemDataSetTableAdapters.TableAdapterManager();
            this.itemLocacaoTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.ItemLocacaoTableAdapter();
            this.livroTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.LivroTableAdapter();
            this.locatarioTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.LocatarioTableAdapter();
            this.idLocacaoTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.itemLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemLocacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLocacaoLabel = new System.Windows.Forms.Label();
            idLocatarioLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            dataSaidaLabel = new System.Windows.Forms.Label();
            dataEntregaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLocacaoLabel
            // 
            idLocacaoLabel.AutoSize = true;
            idLocacaoLabel.Location = new System.Drawing.Point(22, 247);
            idLocacaoLabel.Name = "idLocacaoLabel";
            idLocacaoLabel.Size = new System.Drawing.Size(63, 13);
            idLocacaoLabel.TabIndex = 0;
            idLocacaoLabel.Text = "id Locacao:";
            // 
            // idLocatarioLabel
            // 
            idLocatarioLabel.AutoSize = true;
            idLocatarioLabel.Location = new System.Drawing.Point(6, 82);
            idLocatarioLabel.Name = "idLocatarioLabel";
            idLocatarioLabel.Size = new System.Drawing.Size(43, 13);
            idLocatarioLabel.TabIndex = 2;
            idLocatarioLabel.Text = "Código:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(125, 29);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(33, 13);
            horaLabel.TabIndex = 6;
            horaLabel.Text = "Hora:";
            // 
            // dataSaidaLabel
            // 
            dataSaidaLabel.AutoSize = true;
            dataSaidaLabel.Location = new System.Drawing.Point(6, 29);
            dataSaidaLabel.Name = "dataSaidaLabel";
            dataSaidaLabel.Size = new System.Drawing.Size(78, 13);
            dataSaidaLabel.TabIndex = 8;
            dataSaidaLabel.Text = "Data Locação:";
            // 
            // dataEntregaLabel
            // 
            dataEntregaLabel.AutoSize = true;
            dataEntregaLabel.Location = new System.Drawing.Point(245, 29);
            dataEntregaLabel.Name = "dataEntregaLabel";
            dataEntregaLabel.Size = new System.Drawing.Size(73, 13);
            dataEntregaLabel.TabIndex = 10;
            dataEntregaLabel.Text = "Data Entrega:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemOteca.Properties.Resources.BibliotecaUbN640;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(idLocatarioLabel);
            this.groupBox1.Controls.Add(this.idLocatarioTextBox);
            this.groupBox1.Controls.Add(horaLabel);
            this.groupBox1.Controls.Add(this.horaDateTimePicker);
            this.groupBox1.Controls.Add(dataSaidaLabel);
            this.groupBox1.Controls.Add(this.dataSaidaDateTimePicker);
            this.groupBox1.Controls.Add(dataEntregaLabel);
            this.groupBox1.Controls.Add(this.dataEntregaDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Locação";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locacaoBindingSource, "idLocatario", true));
            this.comboBox1.DataSource = this.locatarioBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "idLocatario";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "Locacao";
            this.locacaoBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // bDSystemDataSet
            // 
            this.bDSystemDataSet.DataSetName = "BDSystemDataSet";
            this.bDSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locatarioBindingSource
            // 
            this.locatarioBindingSource.DataMember = "Locatario";
            this.locatarioBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome do Locatário";
            // 
            // idLocatarioTextBox
            // 
            this.idLocatarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "idLocatario", true));
            this.idLocatarioTextBox.Location = new System.Drawing.Point(9, 98);
            this.idLocatarioTextBox.Name = "idLocatarioTextBox";
            this.idLocatarioTextBox.Size = new System.Drawing.Size(86, 20);
            this.idLocatarioTextBox.TabIndex = 3;
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "Hora", true));
            this.horaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaDateTimePicker.Location = new System.Drawing.Point(128, 45);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.horaDateTimePicker.TabIndex = 7;
            // 
            // dataSaidaDateTimePicker
            // 
            this.dataSaidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "DataSaida", true));
            this.dataSaidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataSaidaDateTimePicker.Location = new System.Drawing.Point(9, 45);
            this.dataSaidaDateTimePicker.Name = "dataSaidaDateTimePicker";
            this.dataSaidaDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.dataSaidaDateTimePicker.TabIndex = 9;
            // 
            // dataEntregaDateTimePicker
            // 
            this.dataEntregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoBindingSource, "DataEntrega", true));
            this.dataEntregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataEntregaDateTimePicker.Location = new System.Drawing.Point(248, 45);
            this.dataEntregaDateTimePicker.Name = "dataEntregaDateTimePicker";
            this.dataEntregaDateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.dataEntregaDateTimePicker.TabIndex = 11;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = this.itemLocacaoTableAdapter;
            this.tableAdapterManager.LivroTableAdapter = this.livroTableAdapter;
            this.tableAdapterManager.LocacaoTableAdapter = this.locacaoTableAdapter;
            this.tableAdapterManager.LocatarioTableAdapter = this.locatarioTableAdapter;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SystemOteca.BDSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemLocacaoTableAdapter
            // 
            this.itemLocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // locatarioTableAdapter
            // 
            this.locatarioTableAdapter.ClearBeforeFill = true;
            // 
            // idLocacaoTextBox
            // 
            this.idLocacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoBindingSource, "idLocacao", true));
            this.idLocacaoTextBox.Location = new System.Drawing.Point(24, 263);
            this.idLocacaoTextBox.Name = "idLocacaoTextBox";
            this.idLocacaoTextBox.Size = new System.Drawing.Size(72, 20);
            this.idLocacaoTextBox.TabIndex = 1;
            this.idLocacaoTextBox.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código do Livro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Retirar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // itemLocacaoBindingSource
            // 
            this.itemLocacaoBindingSource.DataMember = "ItemLocacao";
            this.itemLocacaoBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // itemLocacaoDataGridView
            // 
            this.itemLocacaoDataGridView.AutoGenerateColumns = false;
            this.itemLocacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemLocacaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itemLocacaoDataGridView.DataSource = this.itemLocacaoBindingSource;
            this.itemLocacaoDataGridView.Location = new System.Drawing.Point(125, 197);
            this.itemLocacaoDataGridView.Name = "itemLocacaoDataGridView";
            this.itemLocacaoDataGridView.Size = new System.Drawing.Size(414, 158);
            this.itemLocacaoDataGridView.TabIndex = 19;
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
            this.dataGridViewTextBoxColumn3.HeaderText = "idLivro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idLivro";
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataDevolucao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // frmCadLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 367);
            this.Controls.Add(this.itemLocacaoDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(idLocacaoLabel);
            this.Controls.Add(this.idLocacaoTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.frmCadLocacao_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCadLocacao_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locatarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLocacaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private BDSystemDataSet bDSystemDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private BDSystemDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter;
        private BDSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idLocatarioTextBox;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataSaidaDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataEntregaDateTimePicker;
        private System.Windows.Forms.TextBox idLocacaoTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private BDSystemDataSetTableAdapters.LocatarioTableAdapter locatarioTableAdapter;
        private System.Windows.Forms.BindingSource locatarioBindingSource;
        private System.Windows.Forms.Button button3;
        private BDSystemDataSetTableAdapters.ItemLocacaoTableAdapter itemLocacaoTableAdapter;
        private System.Windows.Forms.BindingSource itemLocacaoBindingSource;
        private BDSystemDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private System.Windows.Forms.DataGridView itemLocacaoDataGridView;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}