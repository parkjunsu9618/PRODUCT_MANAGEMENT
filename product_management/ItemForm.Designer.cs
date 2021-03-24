namespace product_management
{
    partial class ItemForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ItemGridView = new System.Windows.Forms.DataGridView();
            this.grid_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_stand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_comp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_samt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_posi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_item_etc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.item_amt = new System.Windows.Forms.NumericUpDown();
            this.item_samt = new System.Windows.Forms.NumericUpDown();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.item_etc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.item_stand = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.item_posi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.item_comp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.item_code = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.item_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.item_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.item_name_serch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.item_code_serch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.item_date_serch2 = new System.Windows.Forms.DateTimePicker();
            this.item_date_serch = new System.Windows.Forms.DateTimePicker();
            this.ellipseControl1 = new product_management.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_amt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_samt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemGridView
            // 
            this.ItemGridView.AllowUserToAddRows = false;
            this.ItemGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ItemGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ItemGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemGridView.CausesValidation = false;
            this.ItemGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ItemGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemGridView.ColumnHeadersHeight = 40;
            this.ItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_index,
            this.grid_item_code,
            this.grid_item_name,
            this.grid_item_stand,
            this.grid_item_date,
            this.grid_item_amt,
            this.grid_item_comp,
            this.grid_item_samt,
            this.grid_item_posi,
            this.grid_item_etc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemGridView.EnableHeadersVisualStyles = false;
            this.ItemGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.ItemGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ItemGridView.Location = new System.Drawing.Point(3, 97);
            this.ItemGridView.Name = "ItemGridView";
            this.ItemGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ItemGridView.RowHeadersVisible = false;
            this.ItemGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ItemGridView.RowTemplate.Height = 30;
            this.ItemGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemGridView.Size = new System.Drawing.Size(710, 500);
            this.ItemGridView.TabIndex = 155;
            this.ItemGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemGridView_CellDoubleClick);
            // 
            // grid_index
            // 
            this.grid_index.HeaderText = "순번";
            this.grid_index.Name = "grid_index";
            this.grid_index.ReadOnly = true;
            // 
            // grid_item_code
            // 
            this.grid_item_code.HeaderText = "품목코드";
            this.grid_item_code.MinimumWidth = 6;
            this.grid_item_code.Name = "grid_item_code";
            this.grid_item_code.ReadOnly = true;
            // 
            // grid_item_name
            // 
            this.grid_item_name.HeaderText = "품목명";
            this.grid_item_name.MinimumWidth = 6;
            this.grid_item_name.Name = "grid_item_name";
            this.grid_item_name.ReadOnly = true;
            // 
            // grid_item_stand
            // 
            this.grid_item_stand.HeaderText = "규격";
            this.grid_item_stand.MinimumWidth = 6;
            this.grid_item_stand.Name = "grid_item_stand";
            this.grid_item_stand.ReadOnly = true;
            // 
            // grid_item_date
            // 
            this.grid_item_date.HeaderText = "구입일자";
            this.grid_item_date.Name = "grid_item_date";
            this.grid_item_date.ReadOnly = true;
            // 
            // grid_item_amt
            // 
            this.grid_item_amt.HeaderText = "취득가액";
            this.grid_item_amt.Name = "grid_item_amt";
            this.grid_item_amt.ReadOnly = true;
            // 
            // grid_item_comp
            // 
            this.grid_item_comp.HeaderText = "구입처";
            this.grid_item_comp.Name = "grid_item_comp";
            this.grid_item_comp.ReadOnly = true;
            // 
            // grid_item_samt
            // 
            this.grid_item_samt.HeaderText = "재고량";
            this.grid_item_samt.Name = "grid_item_samt";
            this.grid_item_samt.ReadOnly = true;
            // 
            // grid_item_posi
            // 
            this.grid_item_posi.HeaderText = "물품위치";
            this.grid_item_posi.Name = "grid_item_posi";
            this.grid_item_posi.ReadOnly = true;
            // 
            // grid_item_etc
            // 
            this.grid_item_etc.HeaderText = "비고";
            this.grid_item_etc.Name = "grid_item_etc";
            this.grid_item_etc.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.42957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.57043F));
            this.tableLayoutPanel1.Controls.Add(this.ItemGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.68627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.31373F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 600);
            this.tableLayoutPanel1.TabIndex = 154;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.item_amt);
            this.groupBox1.Controls.Add(this.item_samt);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.item_etc);
            this.groupBox1.Controls.Add(this.item_stand);
            this.groupBox1.Controls.Add(this.item_posi);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.item_comp);
            this.groupBox1.Controls.Add(this.item_code);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.item_name);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.pictureBtn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.item_date);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(719, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 500);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "물품정보";
            // 
            // item_amt
            // 
            this.item_amt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_amt.Location = new System.Drawing.Point(97, 305);
            this.item_amt.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.item_amt.Name = "item_amt";
            this.item_amt.Size = new System.Drawing.Size(177, 21);
            this.item_amt.TabIndex = 10;
            this.item_amt.Tag = "item_amt";
            this.item_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.item_amt.ValueChanged += new System.EventHandler(this.item_samt_ValueChanged);
            // 
            // item_samt
            // 
            this.item_samt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_samt.Location = new System.Drawing.Point(97, 231);
            this.item_samt.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.item_samt.Name = "item_samt";
            this.item_samt.Size = new System.Drawing.Size(177, 21);
            this.item_samt.TabIndex = 8;
            this.item_samt.Tag = "item_samt";
            this.item_samt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.item_samt.ValueChanged += new System.EventHandler(this.item_samt_ValueChanged);
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
            this.materialLabel6.Location = new System.Drawing.Point(20, 272);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(61, 19);
            this.materialLabel6.TabIndex = 171;
            this.materialLabel6.Text = "구입일자 :";
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
            this.materialLabel5.Location = new System.Drawing.Point(31, 195);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 169;
            this.materialLabel5.Text = "물품명 :";
            // 
            // item_etc
            // 
            this.item_etc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_etc.Depth = 0;
            this.item_etc.Hint = "";
            this.item_etc.Location = new System.Drawing.Point(97, 420);
            this.item_etc.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_etc.Name = "item_etc";
            this.item_etc.PasswordChar = '\0';
            this.item_etc.SelectedText = "";
            this.item_etc.SelectionLength = 0;
            this.item_etc.SelectionStart = 0;
            this.item_etc.Size = new System.Drawing.Size(177, 23);
            this.item_etc.TabIndex = 14;
            this.item_etc.Tag = "item_etc";
            this.item_etc.UseSystemPasswordChar = false;
            this.item_etc.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // item_stand
            // 
            this.item_stand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_stand.Depth = 0;
            this.item_stand.Hint = "";
            this.item_stand.Location = new System.Drawing.Point(97, 332);
            this.item_stand.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_stand.Name = "item_stand";
            this.item_stand.PasswordChar = '\0';
            this.item_stand.SelectedText = "";
            this.item_stand.SelectionLength = 0;
            this.item_stand.SelectionStart = 0;
            this.item_stand.Size = new System.Drawing.Size(177, 23);
            this.item_stand.TabIndex = 11;
            this.item_stand.Tag = "item_stand";
            this.item_stand.UseSystemPasswordChar = false;
            this.item_stand.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // item_posi
            // 
            this.item_posi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_posi.Depth = 0;
            this.item_posi.Hint = "";
            this.item_posi.Location = new System.Drawing.Point(97, 391);
            this.item_posi.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_posi.Name = "item_posi";
            this.item_posi.PasswordChar = '\0';
            this.item_posi.SelectedText = "";
            this.item_posi.SelectionLength = 0;
            this.item_posi.SelectionStart = 0;
            this.item_posi.Size = new System.Drawing.Size(177, 23);
            this.item_posi.TabIndex = 13;
            this.item_posi.Tag = "item_posi";
            this.item_posi.UseSystemPasswordChar = false;
            this.item_posi.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(20, 160);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 19);
            this.materialLabel4.TabIndex = 168;
            this.materialLabel4.Text = "물품코드 :";
            // 
            // item_comp
            // 
            this.item_comp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_comp.Depth = 0;
            this.item_comp.Hint = "";
            this.item_comp.Location = new System.Drawing.Point(97, 362);
            this.item_comp.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_comp.Name = "item_comp";
            this.item_comp.PasswordChar = '\0';
            this.item_comp.SelectedText = "";
            this.item_comp.SelectionLength = 0;
            this.item_comp.SelectionStart = 0;
            this.item_comp.Size = new System.Drawing.Size(177, 23);
            this.item_comp.TabIndex = 12;
            this.item_comp.Tag = "item_comp";
            this.item_comp.UseSystemPasswordChar = false;
            this.item_comp.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // item_code
            // 
            this.item_code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_code.Depth = 0;
            this.item_code.Hint = "";
            this.item_code.Location = new System.Drawing.Point(97, 155);
            this.item_code.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_code.Name = "item_code";
            this.item_code.PasswordChar = '\0';
            this.item_code.SelectedText = "";
            this.item_code.SelectionLength = 0;
            this.item_code.SelectionStart = 0;
            this.item_code.Size = new System.Drawing.Size(177, 23);
            this.item_code.TabIndex = 6;
            this.item_code.Tag = "item_code";
            this.item_code.UseSystemPasswordChar = false;
            this.item_code.TextChanged += new System.EventHandler(this.TextChanged);
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
            this.materialLabel12.Location = new System.Drawing.Point(42, 425);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(39, 19);
            this.materialLabel12.TabIndex = 165;
            this.materialLabel12.Text = "비고 :";
            // 
            // item_name
            // 
            this.item_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_name.Depth = 0;
            this.item_name.Hint = "";
            this.item_name.Location = new System.Drawing.Point(97, 190);
            this.item_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_name.Name = "item_name";
            this.item_name.PasswordChar = '\0';
            this.item_name.SelectedText = "";
            this.item_name.SelectionLength = 0;
            this.item_name.SelectionStart = 0;
            this.item_name.Size = new System.Drawing.Size(177, 23);
            this.item_name.TabIndex = 7;
            this.item_name.Tag = "item_name";
            this.item_name.UseSystemPasswordChar = false;
            this.item_name.TextChanged += new System.EventHandler(this.TextChanged);
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
            this.materialLabel11.Location = new System.Drawing.Point(20, 396);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(61, 19);
            this.materialLabel11.TabIndex = 167;
            this.materialLabel11.Text = "물품위치 :";
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
            this.materialLabel10.Location = new System.Drawing.Point(31, 367);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 19);
            this.materialLabel10.TabIndex = 166;
            this.materialLabel10.Text = "구입처 :";
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(42, 337);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(39, 19);
            this.materialLabel9.TabIndex = 170;
            this.materialLabel9.Text = "규격 :";
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
            this.materialLabel8.Location = new System.Drawing.Point(31, 231);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(50, 19);
            this.materialLabel8.TabIndex = 164;
            this.materialLabel8.Text = "재고량 :";
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
            this.materialLabel7.Location = new System.Drawing.Point(20, 302);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(61, 19);
            this.materialLabel7.TabIndex = 163;
            this.materialLabel7.Text = "취득가액 :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 17);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 162;
            this.materialLabel3.Text = "사진등록 :";
            // 
            // pictureBtn
            // 
            this.pictureBtn.Location = new System.Drawing.Point(97, 124);
            this.pictureBtn.Name = "pictureBtn";
            this.pictureBtn.Size = new System.Drawing.Size(172, 24);
            this.pictureBtn.TabIndex = 5;
            this.pictureBtn.Text = "사진등록";
            this.pictureBtn.UseVisualStyleBackColor = true;
            this.pictureBtn.Click += new System.EventHandler(this.pictureBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(97, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // item_date
            // 
            this.item_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_date.Location = new System.Drawing.Point(97, 269);
            this.item_date.Name = "item_date";
            this.item_date.Size = new System.Drawing.Size(177, 21);
            this.item_date.TabIndex = 9;
            this.item_date.Tag = "item_date";
            this.item_date.ValueChanged += new System.EventHandler(this.item_date_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel13);
            this.groupBox2.Controls.Add(this.item_name_serch);
            this.groupBox2.Controls.Add(this.item_code_serch);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel14);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.item_date_serch2);
            this.groupBox2.Controls.Add(this.item_date_serch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 88);
            this.groupBox2.TabIndex = 158;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "물품검색";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(21, 57);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(65, 19);
            this.materialLabel13.TabIndex = 167;
            this.materialLabel13.Text = "구입일자 : ";
            // 
            // item_name_serch
            // 
            this.item_name_serch.Depth = 0;
            this.item_name_serch.Hint = "";
            this.item_name_serch.Location = new System.Drawing.Point(342, 14);
            this.item_name_serch.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_name_serch.Name = "item_name_serch";
            this.item_name_serch.PasswordChar = '\0';
            this.item_name_serch.SelectedText = "";
            this.item_name_serch.SelectionLength = 0;
            this.item_name_serch.SelectionStart = 0;
            this.item_name_serch.Size = new System.Drawing.Size(170, 23);
            this.item_name_serch.TabIndex = 2;
            this.item_name_serch.UseSystemPasswordChar = false;
            // 
            // item_code_serch
            // 
            this.item_code_serch.Depth = 0;
            this.item_code_serch.Hint = "";
            this.item_code_serch.Location = new System.Drawing.Point(95, 13);
            this.item_code_serch.MouseState = MaterialSkin.MouseState.HOVER;
            this.item_code_serch.Name = "item_code_serch";
            this.item_code_serch.PasswordChar = '\0';
            this.item_code_serch.SelectedText = "";
            this.item_code_serch.SelectionLength = 0;
            this.item_code_serch.SelectionStart = 0;
            this.item_code_serch.Size = new System.Drawing.Size(178, 23);
            this.item_code_serch.TabIndex = 1;
            this.item_code_serch.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(284, 19);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 162;
            this.materialLabel2.Text = "물품명 :";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(294, 54);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(19, 19);
            this.materialLabel14.TabIndex = 163;
            this.materialLabel14.Text = "~";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 164;
            this.materialLabel1.Text = "물품코드 :";
            // 
            // item_date_serch2
            // 
            this.item_date_serch2.Location = new System.Drawing.Point(342, 54);
            this.item_date_serch2.Name = "item_date_serch2";
            this.item_date_serch2.Size = new System.Drawing.Size(170, 21);
            this.item_date_serch2.TabIndex = 4;
            // 
            // item_date_serch
            // 
            this.item_date_serch.Location = new System.Drawing.Point(95, 54);
            this.item_date_serch.Name = "item_date_serch";
            this.item_date_serch.Size = new System.Drawing.Size(178, 21);
            this.item_date_serch.TabIndex = 3;
            this.item_date_serch.ValueChanged += new System.EventHandler(this.item_date_serch_ValueChanged);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 20;
            this.ellipseControl1.TargetControl = this.ItemGridView;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_amt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_samt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private EllipseControl ellipseControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView ItemGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField item_etc;
        private MaterialSkin.Controls.MaterialSingleLineTextField item_stand;
        private MaterialSkin.Controls.MaterialSingleLineTextField item_posi;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField item_comp;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button pictureBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker item_date;
        public System.Windows.Forms.NumericUpDown item_amt;
        public System.Windows.Forms.NumericUpDown item_samt;
        public MaterialSkin.Controls.MaterialSingleLineTextField item_code;
        public MaterialSkin.Controls.MaterialSingleLineTextField item_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField item_name_serch;
        private MaterialSkin.Controls.MaterialSingleLineTextField item_code_serch;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker item_date_serch2;
        private System.Windows.Forms.DateTimePicker item_date_serch;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_stand;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_samt;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_posi;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_item_etc;
    }
}