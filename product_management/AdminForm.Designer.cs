namespace product_management
{
    partial class AdminForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.admin_name_serch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBtn = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.admin_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.admin_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.admin_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ellipseControl1 = new product_management.EllipseControl();
            this.grid_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_admin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_admin_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_admin_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.18636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.81364F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.adminGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.46154F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 520);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Controls.Add(this.admin_name_serch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자 검색";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "관리자명 : ";
            // 
            // admin_name_serch
            // 
            this.admin_name_serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.admin_name_serch.Depth = 0;
            this.admin_name_serch.Hint = "";
            this.admin_name_serch.Location = new System.Drawing.Point(116, 20);
            this.admin_name_serch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_name_serch.MouseState = MaterialSkin.MouseState.HOVER;
            this.admin_name_serch.Name = "admin_name_serch";
            this.admin_name_serch.PasswordChar = '\0';
            this.admin_name_serch.SelectedText = "";
            this.admin_name_serch.SelectionLength = 0;
            this.admin_name_serch.SelectionStart = 0;
            this.admin_name_serch.Size = new System.Drawing.Size(229, 23);
            this.admin_name_serch.TabIndex = 5;
            this.admin_name_serch.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.pictureBtn);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.admin_name);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.admin_pass);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.admin_id);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(605, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "관리자 정보";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Enabled = false;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(34, 117);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(80, 19);
            this.materialLabel5.TabIndex = 48;
            this.materialLabel5.Text = "관리자 사진 : ";
            // 
            // pictureBtn
            // 
            this.pictureBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pictureBtn.Location = new System.Drawing.Point(139, 212);
            this.pictureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBtn.Name = "pictureBtn";
            this.pictureBtn.Size = new System.Drawing.Size(149, 26);
            this.pictureBtn.TabIndex = 4;
            this.pictureBtn.Text = "사진등록";
            this.pictureBtn.UseVisualStyleBackColor = true;
            this.pictureBtn.Click += new System.EventHandler(this.pictureBtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(27, 273);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 19);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "관리자 아이디 : ";
            // 
            // admin_name
            // 
            this.admin_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_name.Depth = 0;
            this.admin_name.Hint = "";
            this.admin_name.Location = new System.Drawing.Point(148, 390);
            this.admin_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.admin_name.Name = "admin_name";
            this.admin_name.PasswordChar = '\0';
            this.admin_name.SelectedText = "";
            this.admin_name.SelectionLength = 0;
            this.admin_name.SelectionStart = 0;
            this.admin_name.Size = new System.Drawing.Size(130, 23);
            this.admin_name.TabIndex = 242;
            this.admin_name.Tag = "admin_name";
            this.admin_name.UseSystemPasswordChar = false;
            this.admin_name.TextChanged += new System.EventHandler(this.admin_id_TextChanged);
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
            this.materialLabel3.Location = new System.Drawing.Point(14, 335);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(102, 19);
            this.materialLabel3.TabIndex = 50;
            this.materialLabel3.Text = "관리자 비밀번호 : ";
            // 
            // admin_pass
            // 
            this.admin_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_pass.Depth = 0;
            this.admin_pass.Hint = "";
            this.admin_pass.Location = new System.Drawing.Point(148, 335);
            this.admin_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.PasswordChar = '\0';
            this.admin_pass.SelectedText = "";
            this.admin_pass.SelectionLength = 0;
            this.admin_pass.SelectionStart = 0;
            this.admin_pass.Size = new System.Drawing.Size(130, 23);
            this.admin_pass.TabIndex = 241;
            this.admin_pass.Tag = "admin_pass";
            this.admin_pass.UseSystemPasswordChar = false;
            this.admin_pass.TextChanged += new System.EventHandler(this.admin_id_TextChanged);
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
            this.materialLabel4.Location = new System.Drawing.Point(41, 392);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(80, 19);
            this.materialLabel4.TabIndex = 51;
            this.materialLabel4.Text = "관리자 이름 : ";
            // 
            // admin_id
            // 
            this.admin_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_id.Depth = 0;
            this.admin_id.Hint = "";
            this.admin_id.Location = new System.Drawing.Point(148, 271);
            this.admin_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.admin_id.Name = "admin_id";
            this.admin_id.PasswordChar = '\0';
            this.admin_id.SelectedText = "";
            this.admin_id.SelectionLength = 0;
            this.admin_id.SelectionStart = 0;
            this.admin_id.Size = new System.Drawing.Size(130, 23);
            this.admin_id.TabIndex = 240;
            this.admin_id.Tag = "admin_id";
            this.admin_id.UseSystemPasswordChar = false;
            this.admin_id.TextChanged += new System.EventHandler(this.admin_id_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(141, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // adminGridView
            // 
            this.adminGridView.AllowUserToAddRows = false;
            this.adminGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.adminGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adminGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.adminGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminGridView.CausesValidation = false;
            this.adminGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.adminGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adminGridView.ColumnHeadersHeight = 40;
            this.adminGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_index,
            this.grid_admin_id,
            this.grid_admin_pass,
            this.grid_admin_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.adminGridView.EnableHeadersVisualStyles = false;
            this.adminGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.adminGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.adminGridView.Location = new System.Drawing.Point(3, 73);
            this.adminGridView.Name = "adminGridView";
            this.adminGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.adminGridView.RowHeadersVisible = false;
            this.adminGridView.RowHeadersWidth = 51;
            this.adminGridView.RowTemplate.Height = 30;
            this.adminGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminGridView.Size = new System.Drawing.Size(596, 444);
            this.adminGridView.TabIndex = 6;
            this.adminGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminGridView_CellDoubleClick);
            this.adminGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminGridView_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(605, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 66);
            this.panel2.TabIndex = 0;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 20;
            this.ellipseControl1.TargetControl = this.adminGridView;
            // 
            // grid_index
            // 
            this.grid_index.HeaderText = "순번";
            this.grid_index.Name = "grid_index";
            this.grid_index.ReadOnly = true;
            // 
            // grid_admin_id
            // 
            this.grid_admin_id.HeaderText = "관리자ID";
            this.grid_admin_id.MinimumWidth = 6;
            this.grid_admin_id.Name = "grid_admin_id";
            this.grid_admin_id.ReadOnly = true;
            // 
            // grid_admin_pass
            // 
            this.grid_admin_pass.HeaderText = "비밀번호";
            this.grid_admin_pass.MinimumWidth = 6;
            this.grid_admin_pass.Name = "grid_admin_pass";
            this.grid_admin_pass.ReadOnly = true;
            // 
            // grid_admin_name
            // 
            this.grid_admin_name.HeaderText = "이름";
            this.grid_admin_name.MinimumWidth = 6;
            this.grid_admin_name.Name = "grid_admin_name";
            this.grid_admin_name.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 520);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(832, 493);
            this.Name = "AdminForm";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView adminGridView;
        private EllipseControl ellipseControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Button pictureBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MaterialSkin.Controls.MaterialSingleLineTextField admin_name;
        public MaterialSkin.Controls.MaterialSingleLineTextField admin_pass;
        public MaterialSkin.Controls.MaterialSingleLineTextField admin_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField admin_name_serch;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_admin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_admin_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_admin_name;
    }
}