namespace AccountBook
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一覧表示LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集計表示SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataSet = new AccountBook.MoneyDataSet();
            this.moneyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet = new AccountBook.CategoryDataSet();
            this.calendarView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.titleLabelCal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalCal = new System.Windows.Forms.Label();
            this.incomeCal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outCal = new System.Windows.Forms.Label();
            this.buttonEndCal = new System.Windows.Forms.Button();
            this.buttonDeleteCal = new System.Windows.Forms.Button();
            this.buttonChangeCal = new System.Windows.Forms.Button();
            this.buttonAddCal = new System.Windows.Forms.Button();
            this.dgvCal = new System.Windows.Forms.DataGridView();
            this.日付 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分類DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEndTable = new System.Windows.Forms.Button();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.buttonChangeTable = new System.Windows.Forms.Button();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataSet1 = new AccountBook.CategoryDataSet();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).BeginInit();
            this.calendarView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(478, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveSToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.loadToolStripMenuItem.Text = "読込(&O)";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveSToolStripMenuItem
            // 
            this.saveSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSaveToolStripMenuItem,
            this.renameSaveToolStripMenuItem});
            this.saveSToolStripMenuItem.Name = "saveSToolStripMenuItem";
            this.saveSToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.saveSToolStripMenuItem.Text = "保存(&S)";
            // 
            // updateSaveToolStripMenuItem
            // 
            this.updateSaveToolStripMenuItem.Name = "updateSaveToolStripMenuItem";
            this.updateSaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.updateSaveToolStripMenuItem.Text = "上書き保存";
            this.updateSaveToolStripMenuItem.Click += new System.EventHandler(this.updateSaveToolStripMenuItem_Click);
            // 
            // renameSaveToolStripMenuItem
            // 
            this.renameSaveToolStripMenuItem.Name = "renameSaveToolStripMenuItem";
            this.renameSaveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.renameSaveToolStripMenuItem.Text = "別名で保存";
            this.renameSaveToolStripMenuItem.Click += new System.EventHandler(this.renameSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.編集ToolStripMenuItem.Text = "編集(&E)";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.addToolStripMenuItem.Text = "追加(&A)";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addAToolStripMenuItem_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧表示LToolStripMenuItem,
            this.集計表示SToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(58, 19);
            this.表示VToolStripMenuItem.Text = "表示(&V)";
            // 
            // 一覧表示LToolStripMenuItem
            // 
            this.一覧表示LToolStripMenuItem.Name = "一覧表示LToolStripMenuItem";
            this.一覧表示LToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.一覧表示LToolStripMenuItem.Text = "一覧表示(&L)";
            // 
            // 集計表示SToolStripMenuItem
            // 
            this.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem";
            this.集計表示SToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.集計表示SToolStripMenuItem.Text = "集計表示(&S)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
            // 
            // moneyDataTableBindingSource
            // 
            this.moneyDataTableBindingSource.DataMember = "moneyDataTable";
            this.moneyDataTableBindingSource.DataSource = this.moneyDataSet;
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyDataSetBindingSource
            // 
            this.moneyDataSetBindingSource.DataSource = this.moneyDataSet;
            this.moneyDataSetBindingSource.Position = 0;
            // 
            // categoryDataSet
            // 
            this.categoryDataSet.DataSetName = "CategoryDataSet";
            this.categoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarView
            // 
            this.calendarView.Controls.Add(this.tabPage1);
            this.calendarView.Controls.Add(this.tabPage2);
            this.calendarView.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.calendarView.Location = new System.Drawing.Point(0, 29);
            this.calendarView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calendarView.Name = "calendarView";
            this.calendarView.SelectedIndex = 0;
            this.calendarView.ShowToolTips = true;
            this.calendarView.Size = new System.Drawing.Size(478, 418);
            this.calendarView.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.calendarView.TabIndex = 0;
            this.calendarView.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.titleLabelCal);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.buttonEndCal);
            this.tabPage1.Controls.Add(this.buttonDeleteCal);
            this.tabPage1.Controls.Add(this.buttonChangeCal);
            this.tabPage1.Controls.Add(this.buttonAddCal);
            this.tabPage1.Controls.Add(this.dgvCal);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(470, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "カレンダー";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // titleLabelCal
            // 
            this.titleLabelCal.AutoSize = true;
            this.titleLabelCal.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabelCal.Location = new System.Drawing.Point(298, 9);
            this.titleLabelCal.Name = "titleLabelCal";
            this.titleLabelCal.Size = new System.Drawing.Size(107, 28);
            this.titleLabelCal.TabIndex = 21;
            this.titleLabelCal.Text = "今月の収支";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel1.Controls.Add(this.totalCal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.incomeCal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outCal, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(253, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 131);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // totalCal
            // 
            this.totalCal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalCal.AutoSize = true;
            this.totalCal.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.totalCal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalCal.Location = new System.Drawing.Point(143, 90);
            this.totalCal.Name = "totalCal";
            this.totalCal.Size = new System.Drawing.Size(54, 36);
            this.totalCal.TabIndex = 5;
            this.totalCal.Text = "0円";
            this.totalCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incomeCal
            // 
            this.incomeCal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.incomeCal.AutoSize = true;
            this.incomeCal.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.incomeCal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.incomeCal.Location = new System.Drawing.Point(143, 3);
            this.incomeCal.Name = "incomeCal";
            this.incomeCal.Size = new System.Drawing.Size(54, 36);
            this.incomeCal.TabIndex = 3;
            this.incomeCal.Text = "0円";
            this.incomeCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "収入";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "支出";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "差引";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outCal
            // 
            this.outCal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.outCal.AutoSize = true;
            this.outCal.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outCal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.outCal.Location = new System.Drawing.Point(143, 46);
            this.outCal.Name = "outCal";
            this.outCal.Size = new System.Drawing.Size(54, 36);
            this.outCal.TabIndex = 4;
            this.outCal.Text = "0円";
            this.outCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEndCal
            // 
            this.buttonEndCal.Location = new System.Drawing.Point(366, 345);
            this.buttonEndCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEndCal.Name = "buttonEndCal";
            this.buttonEndCal.Size = new System.Drawing.Size(87, 34);
            this.buttonEndCal.TabIndex = 19;
            this.buttonEndCal.Text = "終了";
            this.buttonEndCal.UseVisualStyleBackColor = true;
            this.buttonEndCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteCal
            // 
            this.buttonDeleteCal.Location = new System.Drawing.Point(207, 345);
            this.buttonDeleteCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteCal.Name = "buttonDeleteCal";
            this.buttonDeleteCal.Size = new System.Drawing.Size(87, 34);
            this.buttonDeleteCal.TabIndex = 18;
            this.buttonDeleteCal.Text = "削除";
            this.buttonDeleteCal.UseVisualStyleBackColor = true;
            this.buttonDeleteCal.Click += new System.EventHandler(this.buttonDeleteCal_Click);
            // 
            // buttonChangeCal
            // 
            this.buttonChangeCal.Location = new System.Drawing.Point(113, 345);
            this.buttonChangeCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChangeCal.Name = "buttonChangeCal";
            this.buttonChangeCal.Size = new System.Drawing.Size(87, 34);
            this.buttonChangeCal.TabIndex = 17;
            this.buttonChangeCal.Text = "変更";
            this.buttonChangeCal.UseVisualStyleBackColor = true;
            this.buttonChangeCal.Click += new System.EventHandler(this.buttonChangeCal_Click);
            // 
            // buttonAddCal
            // 
            this.buttonAddCal.Location = new System.Drawing.Point(18, 345);
            this.buttonAddCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddCal.Name = "buttonAddCal";
            this.buttonAddCal.Size = new System.Drawing.Size(87, 34);
            this.buttonAddCal.TabIndex = 16;
            this.buttonAddCal.Text = "追加";
            this.buttonAddCal.UseVisualStyleBackColor = true;
            this.buttonAddCal.Click += new System.EventHandler(this.buttonAddCal_Click);
            // 
            // dgvCal
            // 
            this.dgvCal.AllowUserToAddRows = false;
            this.dgvCal.AllowUserToDeleteRows = false;
            this.dgvCal.AutoGenerateColumns = false;
            this.dgvCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付,
            this.分類DataGridViewTextBoxColumn1,
            this.品名DataGridViewTextBoxColumn1,
            this.金額DataGridViewTextBoxColumn1,
            this.備考DataGridViewTextBoxColumn1});
            this.dgvCal.DataSource = this.moneyDataTableBindingSource;
            this.dgvCal.Location = new System.Drawing.Point(13, 183);
            this.dgvCal.Name = "dgvCal";
            this.dgvCal.ReadOnly = true;
            this.dgvCal.RowTemplate.Height = 21;
            this.dgvCal.Size = new System.Drawing.Size(444, 150);
            this.dgvCal.TabIndex = 1;
            this.dgvCal.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCal_CellPainting);
            // 
            // 日付
            // 
            this.日付.DataPropertyName = "日付";
            this.日付.HeaderText = "日付";
            this.日付.Name = "日付";
            this.日付.ReadOnly = true;
            this.日付.Visible = false;
            // 
            // 分類DataGridViewTextBoxColumn1
            // 
            this.分類DataGridViewTextBoxColumn1.DataPropertyName = "分類";
            this.分類DataGridViewTextBoxColumn1.HeaderText = "分類";
            this.分類DataGridViewTextBoxColumn1.Name = "分類DataGridViewTextBoxColumn1";
            this.分類DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 品名DataGridViewTextBoxColumn1
            // 
            this.品名DataGridViewTextBoxColumn1.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn1.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn1.Name = "品名DataGridViewTextBoxColumn1";
            this.品名DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 金額DataGridViewTextBoxColumn1
            // 
            this.金額DataGridViewTextBoxColumn1.DataPropertyName = "金額";
            this.金額DataGridViewTextBoxColumn1.HeaderText = "金額";
            this.金額DataGridViewTextBoxColumn1.Name = "金額DataGridViewTextBoxColumn1";
            this.金額DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 備考DataGridViewTextBoxColumn1
            // 
            this.備考DataGridViewTextBoxColumn1.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn1.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn1.Name = "備考DataGridViewTextBoxColumn1";
            this.備考DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonEndTable);
            this.tabPage2.Controls.Add(this.buttonDeleteTable);
            this.tabPage2.Controls.Add(this.buttonChangeTable);
            this.tabPage2.Controls.Add(this.buttonAddTable);
            this.tabPage2.Controls.Add(this.dgvTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(470, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "テーブル";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonEndTable
            // 
            this.buttonEndTable.Location = new System.Drawing.Point(357, 334);
            this.buttonEndTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEndTable.Name = "buttonEndTable";
            this.buttonEndTable.Size = new System.Drawing.Size(87, 34);
            this.buttonEndTable.TabIndex = 15;
            this.buttonEndTable.Text = "終了";
            this.buttonEndTable.UseVisualStyleBackColor = true;
            this.buttonEndTable.Click += new System.EventHandler(this.buttonEndTable_Click);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Location = new System.Drawing.Point(198, 334);
            this.buttonDeleteTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(87, 34);
            this.buttonDeleteTable.TabIndex = 14;
            this.buttonDeleteTable.Text = "削除";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // buttonChangeTable
            // 
            this.buttonChangeTable.Location = new System.Drawing.Point(104, 334);
            this.buttonChangeTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChangeTable.Name = "buttonChangeTable";
            this.buttonChangeTable.Size = new System.Drawing.Size(87, 34);
            this.buttonChangeTable.TabIndex = 13;
            this.buttonChangeTable.Text = "変更";
            this.buttonChangeTable.UseVisualStyleBackColor = true;
            this.buttonChangeTable.Click += new System.EventHandler(this.buttonChangeTable_Click);
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Location = new System.Drawing.Point(9, 334);
            this.buttonAddTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(87, 34);
            this.buttonAddTable.TabIndex = 12;
            this.buttonAddTable.Text = "追加";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.分類DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.金額DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
            this.dgvTable.DataSource = this.moneyDataTableBindingSource;
            this.dgvTable.Location = new System.Drawing.Point(-5, 0);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowTemplate.Height = 21;
            this.dgvTable.Size = new System.Drawing.Size(475, 325);
            this.dgvTable.TabIndex = 11;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            this.日付DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 分類DataGridViewTextBoxColumn
            // 
            this.分類DataGridViewTextBoxColumn.DataPropertyName = "分類";
            this.分類DataGridViewTextBoxColumn.HeaderText = "分類";
            this.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn";
            this.分類DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            this.品名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 金額DataGridViewTextBoxColumn
            // 
            this.金額DataGridViewTextBoxColumn.DataPropertyName = "金額";
            this.金額DataGridViewTextBoxColumn.HeaderText = "金額";
            this.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn";
            this.金額DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            this.備考DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataSet1
            // 
            this.categoryDataSet1.DataSetName = "CategoryDataSet";
            this.categoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.calendarView);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "簡易家計簿";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet)).EndInit();
            this.calendarView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一覧表示LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集計表示SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.BindingSource moneyDataTableBindingSource;
        private MoneyDataSet moneyDataSet;
        private System.Windows.Forms.BindingSource moneyDataSetBindingSource;
        private CategoryDataSet categoryDataSet;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameSaveToolStripMenuItem;
        private System.Windows.Forms.TabControl calendarView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonEndTable;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.Button buttonChangeTable;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCal;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private CategoryDataSet categoryDataSet1;
        private System.Windows.Forms.Button buttonEndCal;
        private System.Windows.Forms.Button buttonDeleteCal;
        private System.Windows.Forms.Button buttonChangeCal;
        private System.Windows.Forms.Button buttonAddCal;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label titleLabelCal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label totalCal;
        private System.Windows.Forms.Label outCal;
        private System.Windows.Forms.Label incomeCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

