namespace SystemOteca
{
    partial class frmCadLivros
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
            System.Windows.Forms.Label idLivroLabel;
            System.Windows.Forms.Label idEditoraLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label edicaoLabel;
            System.Windows.Forms.Label anoLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label localizaçãoLabel;
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label classificacaoLabel;
            System.Windows.Forms.Label colecaoLabel;
            System.Windows.Forms.Label tomboLabel;
            System.Windows.Forms.Label resenhaLabel;
            System.Windows.Forms.Label autoresLabel;
            System.Windows.Forms.Label comentariosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLivros));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDSystemDataSet = new SystemOteca.BDSystemDataSet();
            this.livroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.livroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLivroTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.edicaoTextBox = new System.Windows.Forms.TextBox();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.localizaçãoTextBox = new System.Windows.Forms.TextBox();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.classificacaoTextBox = new System.Windows.Forms.TextBox();
            this.colecaoTextBox = new System.Windows.Forms.TextBox();
            this.tomboCheckBox = new System.Windows.Forms.CheckBox();
            this.resenhaTextBox = new System.Windows.Forms.TextBox();
            this.autoresTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comentariosTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.capaTextBox = new System.Windows.Forms.TextBox();
            this.livroTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.LivroTableAdapter();
            this.tableAdapterManager = new SystemOteca.BDSystemDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.livroItemLocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemLocacaoTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.ItemLocacaoTableAdapter();
            this.editoraTableAdapter = new SystemOteca.BDSystemDataSetTableAdapters.EditoraTableAdapter();
            idLivroLabel = new System.Windows.Forms.Label();
            idEditoraLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            edicaoLabel = new System.Windows.Forms.Label();
            anoLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            localizaçãoLabel = new System.Windows.Forms.Label();
            assuntoLabel = new System.Windows.Forms.Label();
            classificacaoLabel = new System.Windows.Forms.Label();
            colecaoLabel = new System.Windows.Forms.Label();
            tomboLabel = new System.Windows.Forms.Label();
            resenhaLabel = new System.Windows.Forms.Label();
            autoresLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingNavigator)).BeginInit();
            this.livroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroItemLocacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLivroLabel
            // 
            idLivroLabel.AutoSize = true;
            idLivroLabel.Location = new System.Drawing.Point(10, 53);
            idLivroLabel.Name = "idLivroLabel";
            idLivroLabel.Size = new System.Drawing.Size(66, 13);
            idLivroLabel.TabIndex = 0;
            idLivroLabel.Text = "Código Livro";
            // 
            // idEditoraLabel
            // 
            idEditoraLabel.AutoSize = true;
            idEditoraLabel.Location = new System.Drawing.Point(10, 79);
            idEditoraLabel.Name = "idEditoraLabel";
            idEditoraLabel.Size = new System.Drawing.Size(40, 13);
            idEditoraLabel.TabIndex = 2;
            idEditoraLabel.Text = "Editora";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(10, 105);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 4;
            tituloLabel.Text = "Titulo:";
            // 
            // edicaoLabel
            // 
            edicaoLabel.AutoSize = true;
            edicaoLabel.Location = new System.Drawing.Point(10, 131);
            edicaoLabel.Name = "edicaoLabel";
            edicaoLabel.Size = new System.Drawing.Size(43, 13);
            edicaoLabel.TabIndex = 6;
            edicaoLabel.Text = "Edicao:";
            // 
            // anoLabel
            // 
            anoLabel.AutoSize = true;
            anoLabel.Location = new System.Drawing.Point(10, 157);
            anoLabel.Name = "anoLabel";
            anoLabel.Size = new System.Drawing.Size(29, 13);
            anoLabel.TabIndex = 8;
            anoLabel.Text = "Ano:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(10, 183);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(35, 13);
            iSBNLabel.TabIndex = 10;
            iSBNLabel.Text = "ISBN:";
            // 
            // localizaçãoLabel
            // 
            localizaçãoLabel.AutoSize = true;
            localizaçãoLabel.Location = new System.Drawing.Point(10, 209);
            localizaçãoLabel.Name = "localizaçãoLabel";
            localizaçãoLabel.Size = new System.Drawing.Size(67, 13);
            localizaçãoLabel.TabIndex = 12;
            localizaçãoLabel.Text = "Localização:";
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(10, 235);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(48, 13);
            assuntoLabel.TabIndex = 14;
            assuntoLabel.Text = "Assunto:";
            // 
            // classificacaoLabel
            // 
            classificacaoLabel.AutoSize = true;
            classificacaoLabel.Location = new System.Drawing.Point(10, 261);
            classificacaoLabel.Name = "classificacaoLabel";
            classificacaoLabel.Size = new System.Drawing.Size(72, 13);
            classificacaoLabel.TabIndex = 16;
            classificacaoLabel.Text = "Classificacao:";
            // 
            // colecaoLabel
            // 
            colecaoLabel.AutoSize = true;
            colecaoLabel.Location = new System.Drawing.Point(10, 287);
            colecaoLabel.Name = "colecaoLabel";
            colecaoLabel.Size = new System.Drawing.Size(49, 13);
            colecaoLabel.TabIndex = 18;
            colecaoLabel.Text = "Colecao:";
            // 
            // tomboLabel
            // 
            tomboLabel.AutoSize = true;
            tomboLabel.Location = new System.Drawing.Point(10, 315);
            tomboLabel.Name = "tomboLabel";
            tomboLabel.Size = new System.Drawing.Size(43, 13);
            tomboLabel.TabIndex = 20;
            tomboLabel.Text = "Tombo:";
            // 
            // resenhaLabel
            // 
            resenhaLabel.AutoSize = true;
            resenhaLabel.Location = new System.Drawing.Point(10, 368);
            resenhaLabel.Name = "resenhaLabel";
            resenhaLabel.Size = new System.Drawing.Size(53, 13);
            resenhaLabel.TabIndex = 24;
            resenhaLabel.Text = "Resenha:";
            // 
            // autoresLabel
            // 
            autoresLabel.AutoSize = true;
            autoresLabel.Location = new System.Drawing.Point(10, 340);
            autoresLabel.Name = "autoresLabel";
            autoresLabel.Size = new System.Drawing.Size(46, 13);
            autoresLabel.TabIndex = 26;
            autoresLabel.Text = "Autores:";
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Location = new System.Drawing.Point(3, 35);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(68, 13);
            comentariosLabel.TabIndex = 30;
            comentariosLabel.Text = "Comentarios:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.livroBindingNavigatorSaveItem_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(156, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 419);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.livroBindingNavigator);
            this.tabPage1.Controls.Add(idLivroLabel);
            this.tabPage1.Controls.Add(this.idLivroTextBox);
            this.tabPage1.Controls.Add(idEditoraLabel);
            this.tabPage1.Controls.Add(tituloLabel);
            this.tabPage1.Controls.Add(this.tituloTextBox);
            this.tabPage1.Controls.Add(edicaoLabel);
            this.tabPage1.Controls.Add(this.edicaoTextBox);
            this.tabPage1.Controls.Add(anoLabel);
            this.tabPage1.Controls.Add(this.anoTextBox);
            this.tabPage1.Controls.Add(iSBNLabel);
            this.tabPage1.Controls.Add(this.iSBNTextBox);
            this.tabPage1.Controls.Add(localizaçãoLabel);
            this.tabPage1.Controls.Add(this.localizaçãoTextBox);
            this.tabPage1.Controls.Add(assuntoLabel);
            this.tabPage1.Controls.Add(this.assuntoTextBox);
            this.tabPage1.Controls.Add(classificacaoLabel);
            this.tabPage1.Controls.Add(this.classificacaoTextBox);
            this.tabPage1.Controls.Add(colecaoLabel);
            this.tabPage1.Controls.Add(this.colecaoTextBox);
            this.tabPage1.Controls.Add(tomboLabel);
            this.tabPage1.Controls.Add(this.tomboCheckBox);
            this.tabPage1.Controls.Add(resenhaLabel);
            this.tabPage1.Controls.Add(this.resenhaTextBox);
            this.tabPage1.Controls.Add(autoresLabel);
            this.tabPage1.Controls.Add(this.autoresTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(515, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Gerais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.editoraBindingSource;
            this.comboBox1.DisplayMember = "idEditora";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 21);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.ValueMember = "idEditora";
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "Editora";
            this.editoraBindingSource.DataSource = this.bDSystemDataSet;
            // 
            // bDSystemDataSet
            // 
            this.bDSystemDataSet.DataSetName = "BDSystemDataSet";
            this.bDSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroBindingNavigator
            // 
            this.livroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.livroBindingNavigator.BindingSource = this.livroBindingSource;
            this.livroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.livroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.livroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.livroBindingNavigatorSaveItem});
            this.livroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.livroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.livroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.livroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.livroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.livroBindingNavigator.Name = "livroBindingNavigator";
            this.livroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.livroBindingNavigator.Size = new System.Drawing.Size(498, 25);
            this.livroBindingNavigator.TabIndex = 30;
            this.livroBindingNavigator.Text = "bindingNavigator1";
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
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.bDSystemDataSet;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // livroBindingNavigatorSaveItem
            // 
            this.livroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.livroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("livroBindingNavigatorSaveItem.Image")));
            this.livroBindingNavigatorSaveItem.Name = "livroBindingNavigatorSaveItem";
            this.livroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.livroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.livroBindingNavigatorSaveItem.Click += new System.EventHandler(this.livroBindingNavigatorSaveItem_Click_1);
            // 
            // idLivroTextBox
            // 
            this.idLivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "idLivro", true));
            this.idLivroTextBox.Location = new System.Drawing.Point(88, 50);
            this.idLivroTextBox.Name = "idLivroTextBox";
            this.idLivroTextBox.Size = new System.Drawing.Size(382, 20);
            this.idLivroTextBox.TabIndex = 1;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(88, 102);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(382, 20);
            this.tituloTextBox.TabIndex = 5;
            // 
            // edicaoTextBox
            // 
            this.edicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Edicao", true));
            this.edicaoTextBox.Location = new System.Drawing.Point(88, 128);
            this.edicaoTextBox.Name = "edicaoTextBox";
            this.edicaoTextBox.Size = new System.Drawing.Size(382, 20);
            this.edicaoTextBox.TabIndex = 7;
            // 
            // anoTextBox
            // 
            this.anoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Ano", true));
            this.anoTextBox.Location = new System.Drawing.Point(88, 154);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(382, 20);
            this.anoTextBox.TabIndex = 9;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(88, 180);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(382, 20);
            this.iSBNTextBox.TabIndex = 11;
            // 
            // localizaçãoTextBox
            // 
            this.localizaçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Localização", true));
            this.localizaçãoTextBox.Location = new System.Drawing.Point(88, 206);
            this.localizaçãoTextBox.Name = "localizaçãoTextBox";
            this.localizaçãoTextBox.Size = new System.Drawing.Size(382, 20);
            this.localizaçãoTextBox.TabIndex = 13;
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Assunto", true));
            this.assuntoTextBox.Location = new System.Drawing.Point(88, 232);
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(382, 20);
            this.assuntoTextBox.TabIndex = 15;
            // 
            // classificacaoTextBox
            // 
            this.classificacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Classificacao", true));
            this.classificacaoTextBox.Location = new System.Drawing.Point(88, 258);
            this.classificacaoTextBox.Name = "classificacaoTextBox";
            this.classificacaoTextBox.Size = new System.Drawing.Size(382, 20);
            this.classificacaoTextBox.TabIndex = 17;
            // 
            // colecaoTextBox
            // 
            this.colecaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Colecao", true));
            this.colecaoTextBox.Location = new System.Drawing.Point(88, 284);
            this.colecaoTextBox.Name = "colecaoTextBox";
            this.colecaoTextBox.Size = new System.Drawing.Size(382, 20);
            this.colecaoTextBox.TabIndex = 19;
            // 
            // tomboCheckBox
            // 
            this.tomboCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.livroBindingSource, "Tombo", true));
            this.tomboCheckBox.Location = new System.Drawing.Point(88, 310);
            this.tomboCheckBox.Name = "tomboCheckBox";
            this.tomboCheckBox.Size = new System.Drawing.Size(382, 24);
            this.tomboCheckBox.TabIndex = 21;
            this.tomboCheckBox.Text = "SIM/NÃO";
            this.tomboCheckBox.UseVisualStyleBackColor = true;
            // 
            // resenhaTextBox
            // 
            this.resenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Resenha", true));
            this.resenhaTextBox.Location = new System.Drawing.Point(88, 365);
            this.resenhaTextBox.Multiline = true;
            this.resenhaTextBox.Name = "resenhaTextBox";
            this.resenhaTextBox.Size = new System.Drawing.Size(382, 86);
            this.resenhaTextBox.TabIndex = 25;
            // 
            // autoresTextBox
            // 
            this.autoresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Autores", true));
            this.autoresTextBox.Location = new System.Drawing.Point(88, 337);
            this.autoresTextBox.Name = "autoresTextBox";
            this.autoresTextBox.Size = new System.Drawing.Size(382, 20);
            this.autoresTextBox.TabIndex = 27;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(comentariosLabel);
            this.tabPage2.Controls.Add(this.comentariosTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(515, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comentários";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comentariosTextBox
            // 
            this.comentariosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Comentarios", true));
            this.comentariosTextBox.Location = new System.Drawing.Point(6, 51);
            this.comentariosTextBox.Multiline = true;
            this.comentariosTextBox.Name = "comentariosTextBox";
            this.comentariosTextBox.Size = new System.Drawing.Size(463, 313);
            this.comentariosTextBox.TabIndex = 31;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.toolStrip1);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.capaTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(515, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Imagem da Capa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(515, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::SystemOteca.Properties.Resources.create_with_plus_mail_layer_512;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::SystemOteca.Properties.Resources.subtract_circle_red_512;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(17, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(477, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // capaTextBox
            // 
            this.capaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livroBindingSource, "Capa", true));
            this.capaTextBox.Location = new System.Drawing.Point(0, 373);
            this.capaTextBox.Name = "capaTextBox";
            this.capaTextBox.Size = new System.Drawing.Size(515, 20);
            this.capaTextBox.TabIndex = 24;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EditoraTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.ItemLocacaoTableAdapter = null;
            this.tableAdapterManager.LivroTableAdapter = this.livroTableAdapter;
            this.tableAdapterManager.LocacaoTableAdapter = null;
            this.tableAdapterManager.LocatarioTableAdapter = null;
            this.tableAdapterManager.PerfilTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SystemOteca.BDSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemOteca.Properties.Resources.BibliotecaUbN640;
            this.pictureBox1.Location = new System.Drawing.Point(9, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // livroItemLocacaoBindingSource
            // 
            this.livroItemLocacaoBindingSource.DataMember = "LivroItemLocacao";
            this.livroItemLocacaoBindingSource.DataSource = this.livroBindingSource;
            // 
            // itemLocacaoTableAdapter
            // 
            this.itemLocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCadLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.frmCadLivros_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingNavigator)).EndInit();
            this.livroBindingNavigator.ResumeLayout(false);
            this.livroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroItemLocacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private BDSystemDataSet bDSystemDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private BDSystemDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private BDSystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator livroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton livroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idLivroTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox edicaoTextBox;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox localizaçãoTextBox;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.TextBox classificacaoTextBox;
        private System.Windows.Forms.TextBox colecaoTextBox;
        private System.Windows.Forms.CheckBox tomboCheckBox;
        private System.Windows.Forms.TextBox resenhaTextBox;
        private System.Windows.Forms.TextBox autoresTextBox;
        private System.Windows.Forms.TextBox comentariosTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox capaTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource livroItemLocacaoBindingSource;
        private BDSystemDataSetTableAdapters.ItemLocacaoTableAdapter itemLocacaoTableAdapter;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private BDSystemDataSetTableAdapters.EditoraTableAdapter editoraTableAdapter;
    }
}