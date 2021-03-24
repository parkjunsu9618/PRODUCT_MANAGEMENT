namespace product_management
{
    partial class IpgoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ipgoGridView = new System.Windows.Forms.DataGridView();
            this.grid_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_ipgo_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_samt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_ipgo_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_ipgo_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_ipgo_comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_ipgo_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ipgo_comp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ipgo_code_serchBtn = new System.Windows.Forms.Button();
            this.item_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ipgo_code = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.ipgo_amt = new System.Windows.Forms.NumericUpDown();
            this.item_samt = new System.Windows.Forms.NumericUpDown();
            this.ipgo_cnt = new System.Windows.Forms.NumericUpDown();
            this.ipgo_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ipgo_date_serch = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.ipgo_date_serch2 = new System.Windows.Forms.DateTimePicker();
            this.ipgo_comp_serch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.item_name_serch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.ellipseControl1 = new product_management.EllipseControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipgoGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipgo_amt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_samt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipgo_cnt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.09145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.90855F));
            this.tableLayoutPanel1.Controls.Add(this.ipgoGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 600);
            this.tableLayoutPanel1.TabIndex = 164;
            // 
            // ipgoGridView
            // 
            this.ipgoGridView.AllowUserToAddRows = false;
            this.ipgoGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ipgoGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ipgoGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipgoGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ipgoGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ipgoGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ipgoGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipgoGridView.CausesValidation = false;
            this.ipgoGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ipgoGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ipgoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ipgoGridView.ColumnHeadersHeight = 40;
            this.ipgoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_index,
            this.grid_ipgo_code,
            this.grid_item_name,
            this.grid_item_samt,
            this.grid_ipgo_date,
            this.grid_ipgo_cnt,
            this.grid_ipgo_comp,
            this.grid_ipgo_amt});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ipgoGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.ipgoGridView.EnableHeadersVisualStyles = false;
            this.ipgoGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.ipgoGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ipgoGridView.Location = new System.Drawing.Point(3, 94);
            this.ipgoGridView.Name = "ipgoGridView";
            this.ipgoGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ipgoGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ipgoGridView.RowHeadersVisible = false;
            this.ipgoGridView.RowHeadersWidth = 51;
            this.ipgoGridView.RowTemplate.Height = 30;
            this.ipgoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ipgoGridView.Size = new System.Drawing.Size(717, 503);
            this.ipgoGridView.TabIndex = 9;
            this.ipgoGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ipgoGridView_CellDoubleClick);
            // 
            // grid_index
            // 
            this.grid_index.HeaderText = "순번";
            this.grid_index.Name = "grid_index";
            this.grid_index.ReadOnly = true;
            // 
            // grid_ipgo_code
            // 
            this.grid_ipgo_code.HeaderText = "품목코드";
            this.grid_ipgo_code.MinimumWidth = 6;
            this.grid_ipgo_code.Name = "grid_ipgo_code";
            this.grid_ipgo_code.ReadOnly = true;
            // 
            // grid_item_name
            // 
            this.grid_item_name.HeaderText = "품목명";
            this.grid_item_name.MinimumWidth = 6;
            this.grid_item_name.Name = "grid_item_name";
            this.grid_item_name.ReadOnly = true;
            // 
            // grid_item_samt
            // 
            this.grid_item_samt.HeaderText = "재고량";
            this.grid_item_samt.MinimumWidth = 6;
            this.grid_item_samt.Name = "grid_item_samt";
            this.grid_item_samt.ReadOnly = true;
            // 
            // grid_ipgo_date
            // 
            this.grid_ipgo_date.HeaderText = "입고일자";
            this.grid_ipgo_date.Name = "grid_ipgo_date";
            this.grid_ipgo_date.ReadOnly = true;
            // 
            // grid_ipgo_cnt
            // 
            this.grid_ipgo_cnt.HeaderText = "입고량";
            this.grid_ipgo_cnt.Name = "grid_ipgo_cnt";
            this.grid_ipgo_cnt.ReadOnly = true;
            // 
            // grid_ipgo_comp
            // 
            this.grid_ipgo_comp.HeaderText = "입고처";
            this.grid_ipgo_comp.Name = "grid_ipgo_comp";
            this.grid_ipgo_comp.ReadOnly = true;
            // 
            // grid_ipgo_amt
            // 
            this.grid_ipgo_amt.HeaderText = "입고금액";
            this.grid_ipgo_amt.Name = "grid_ipgo_amt";
            this.grid_ipgo_amt.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ipgo_comp);
            this.groupBox1.Controls.Add(this.ipgo_code_serchBtn);
            this.groupBox1.Controls.Add(this.item_name);
            this.groupBox1.Controls.Add(this.ipgo_code);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel13);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.ipgo_amt);
            this.groupBox1.Controls.Add(this.item_samt);
            this.groupBox1.Controls.Add(this.ipgo_cnt);
            this.groupBox1.Controls.Add(this.ipgo_date);
            this.groupBox1.Location = new System.Drawing.Point(726, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 503);
            this.groupBox1.TabIndex = 164;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입고정보";
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(25, 408);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(61, 19);
            this.materialLabel12.TabIndex = 145;
            this.materialLabel12.Text = "입고금액 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(105, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // ipgo_comp
            // 
            this.ipgo_comp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipgo_comp.Depth = 0;
            this.ipgo_comp.Hint = "";
            this.ipgo_comp.Location = new System.Drawing.Point(102, 314);
            this.ipgo_comp.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipgo_comp.Name = "ipgo_comp";
            this.ipgo_comp.PasswordChar = '\0';
            this.ipgo_comp.SelectedText = "";
            this.ipgo_comp.SelectionLength = 0;
            this.ipgo_comp.SelectionStart = 0;
            this.ipgo_comp.Size = new System.Drawing.Size(170, 23);
            this.ipgo_comp.TabIndex = 5;
            this.ipgo_comp.Tag = "ipgo_comp";
            this.ipgo_comp.UseSystemPasswordChar = false;
            this.ipgo_comp.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // ipgo_code_serchBtn
            // 
            this.ipgo_code_serchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipgo_code_serchBtn.Location = new System.Drawing.Point(21, 265);
            this.ipgo_code_serchBtn.Name = "ipgo_code_serchBtn";
            this.ipgo_code_serchBtn.Size = new System.Drawing.Size(258, 33);
            this.ipgo_code_serchBtn.TabIndex = 4;
            this.ipgo_code_serchBtn.Text = "물품검색";
            this.ipgo_code_serchBtn.UseVisualStyleBackColor = true;
            this.ipgo_code_serchBtn.Click += new System.EventHandler(this.ipgo_code_serchBtn_Click);
            // 
            // item_name
            // 
            this.item_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_name.Depth = 0;
            this.item_name.Hint = "";
            this.item_name.Location = new System.Drawing.Point(105, 195);
            this.item_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_name.Name = "item_name";
            this.item_name.PasswordChar = '\0';
            this.item_name.SelectedText = "";
            this.item_name.SelectionLength = 0;
            this.item_name.SelectionStart = 0;
            this.item_name.Size = new System.Drawing.Size(170, 23);
            this.item_name.TabIndex = 2;
            this.item_name.Tag = "item_name";
            this.item_name.UseSystemPasswordChar = false;
            this.item_name.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // ipgo_code
            // 
            this.ipgo_code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipgo_code.Depth = 0;
            this.ipgo_code.Hint = "";
            this.ipgo_code.Location = new System.Drawing.Point(105, 159);
            this.ipgo_code.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipgo_code.Name = "ipgo_code";
            this.ipgo_code.PasswordChar = '\0';
            this.ipgo_code.SelectedText = "";
            this.ipgo_code.SelectionLength = 0;
            this.ipgo_code.SelectionStart = 0;
            this.ipgo_code.Size = new System.Drawing.Size(170, 23);
            this.ipgo_code.TabIndex = 1;
            this.ipgo_code.Tag = "ipgo_code";
            this.ipgo_code.UseSystemPasswordChar = false;
            this.ipgo_code.TextChanged += new System.EventHandler(this.ipgo_code_TextChanged);
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(34, 321);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 19);
            this.materialLabel10.TabIndex = 145;
            this.materialLabel10.Text = "입고처 :";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(25, 350);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(61, 19);
            this.materialLabel7.TabIndex = 145;
            this.materialLabel7.Text = "입고일자 :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(24, 224);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(50, 19);
            this.materialLabel6.TabIndex = 145;
            this.materialLabel6.Text = "재고량 :";
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(13, 163);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(61, 19);
            this.materialLabel13.TabIndex = 145;
            this.materialLabel13.Text = "물품코드 :";
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(13, 26);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(61, 19);
            this.materialLabel11.TabIndex = 145;
            this.materialLabel11.Text = "물품사진 :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(36, 380);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(50, 19);
            this.materialLabel8.TabIndex = 145;
            this.materialLabel8.Text = "입고량 :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(24, 195);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 145;
            this.materialLabel5.Text = "물품명 :";
            // 
            // ipgo_amt
            // 
            this.ipgo_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipgo_amt.Location = new System.Drawing.Point(104, 407);
            this.ipgo_amt.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.ipgo_amt.Name = "ipgo_amt";
            this.ipgo_amt.Size = new System.Drawing.Size(170, 21);
            this.ipgo_amt.TabIndex = 8;
            this.ipgo_amt.Tag = "ipgo_amt";
            this.ipgo_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ipgo_amt.ValueChanged += new System.EventHandler(this.item_samt_ValueChanged);
            // 
            // item_samt
            // 
            this.item_samt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_samt.Location = new System.Drawing.Point(105, 227);
            this.item_samt.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.item_samt.Name = "item_samt";
            this.item_samt.Size = new System.Drawing.Size(170, 21);
            this.item_samt.TabIndex = 3;
            this.item_samt.Tag = "item_samt";
            this.item_samt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.item_samt.ValueChanged += new System.EventHandler(this.item_samt_ValueChanged);
            // 
            // ipgo_cnt
            // 
            this.ipgo_cnt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipgo_cnt.Location = new System.Drawing.Point(104, 377);
            this.ipgo_cnt.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ipgo_cnt.Name = "ipgo_cnt";
            this.ipgo_cnt.Size = new System.Drawing.Size(170, 21);
            this.ipgo_cnt.TabIndex = 7;
            this.ipgo_cnt.Tag = "ipgo_cnt";
            this.ipgo_cnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ipgo_cnt.ValueChanged += new System.EventHandler(this.item_samt_ValueChanged);
            // 
            // ipgo_date
            // 
            this.ipgo_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipgo_date.Location = new System.Drawing.Point(104, 346);
            this.ipgo_date.Name = "ipgo_date";
            this.ipgo_date.Size = new System.Drawing.Size(170, 21);
            this.ipgo_date.TabIndex = 6;
            this.ipgo_date.Tag = "ipgo_date";
            this.ipgo_date.ValueChanged += new System.EventHandler(this.item_date_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.ipgo_date_serch);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.ipgo_date_serch2);
            this.groupBox2.Controls.Add(this.ipgo_comp_serch);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.item_name_serch);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 85);
            this.groupBox2.TabIndex = 168;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "입고검색";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 149;
            this.materialLabel1.Text = "물품명 :";
            // 
            // ipgo_date_serch
            // 
            this.ipgo_date_serch.Location = new System.Drawing.Point(103, 49);
            this.ipgo_date_serch.Name = "ipgo_date_serch";
            this.ipgo_date_serch.Size = new System.Drawing.Size(169, 21);
            this.ipgo_date_serch.TabIndex = 12;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(301, 49);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(19, 19);
            this.materialLabel4.TabIndex = 150;
            this.materialLabel4.Text = "~";
            // 
            // ipgo_date_serch2
            // 
            this.ipgo_date_serch2.Location = new System.Drawing.Point(349, 49);
            this.ipgo_date_serch2.Name = "ipgo_date_serch2";
            this.ipgo_date_serch2.Size = new System.Drawing.Size(169, 21);
            this.ipgo_date_serch2.TabIndex = 13;
            // 
            // ipgo_comp_serch
            // 
            this.ipgo_comp_serch.Depth = 0;
            this.ipgo_comp_serch.Hint = "";
            this.ipgo_comp_serch.Location = new System.Drawing.Point(351, 17);
            this.ipgo_comp_serch.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipgo_comp_serch.Name = "ipgo_comp_serch";
            this.ipgo_comp_serch.PasswordChar = '\0';
            this.ipgo_comp_serch.SelectedText = "";
            this.ipgo_comp_serch.SelectionLength = 0;
            this.ipgo_comp_serch.SelectionStart = 0;
            this.ipgo_comp_serch.Size = new System.Drawing.Size(169, 23);
            this.ipgo_comp_serch.TabIndex = 11;
            this.ipgo_comp_serch.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(290, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 151;
            this.materialLabel2.Text = "입고처 :";
            // 
            // item_name_serch
            // 
            this.item_name_serch.Depth = 0;
            this.item_name_serch.Hint = "";
            this.item_name_serch.Location = new System.Drawing.Point(103, 17);
            this.item_name_serch.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_name_serch.Name = "item_name_serch";
            this.item_name_serch.PasswordChar = '\0';
            this.item_name_serch.SelectedText = "";
            this.item_name_serch.SelectionLength = 0;
            this.item_name_serch.SelectionStart = 0;
            this.item_name_serch.Size = new System.Drawing.Size(169, 23);
            this.item_name_serch.TabIndex = 10;
            this.item_name_serch.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(26, 49);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 152;
            this.materialLabel3.Text = "입고일자 :";
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 20;
            this.ellipseControl1.TargetControl = this.ipgoGridView;
            // 
            // IpgoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IpgoForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipgoGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipgo_amt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_samt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipgo_cnt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EllipseControl ellipseControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ipgo_code_serchBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        public System.Windows.Forms.NumericUpDown ipgo_amt;
        public System.Windows.Forms.NumericUpDown item_samt;
        public System.Windows.Forms.NumericUpDown ipgo_cnt;
        private System.Windows.Forms.DateTimePicker ipgo_date;
        public MaterialSkin.Controls.MaterialSingleLineTextField ipgo_comp;
        public MaterialSkin.Controls.MaterialSingleLineTextField item_name;
        public MaterialSkin.Controls.MaterialSingleLineTextField ipgo_code;
        public System.Windows.Forms.DataGridView ipgoGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker ipgo_date_serch;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker ipgo_date_serch2;
        private MaterialSkin.Controls.MaterialSingleLineTextField ipgo_comp_serch;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField item_name_serch;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_ipgo_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_samt;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_ipgo_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_ipgo_cnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_ipgo_comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_ipgo_amt;
    }
}