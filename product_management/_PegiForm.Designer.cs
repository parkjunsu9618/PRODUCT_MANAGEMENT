namespace product_management
{
    partial class _PegiForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pegi_date_serch2 = new System.Windows.Forms.DateTimePicker();
            this.pegi_date_serch = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pegi_cnt = new System.Windows.Forms.NumericUpDown();
            this.item_samt = new System.Windows.Forms.NumericUpDown();
            this.culgo_code_serchBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.TextBox();
            this.pegi_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pegi_sau = new System.Windows.Forms.TextBox();
            this.pegi_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pegiGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canselBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.item_name_serch = new System.Windows.Forms.TextBox();
            this.user_sysid = new System.Windows.Forms.TextBox();
            this.serchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegi_cnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_samt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 180;
            this.label5.Text = "폐기일";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 179;
            this.label2.Text = "물품명";
            // 
            // pegi_date_serch2
            // 
            this.pegi_date_serch2.Location = new System.Drawing.Point(322, 117);
            this.pegi_date_serch2.Name = "pegi_date_serch2";
            this.pegi_date_serch2.Size = new System.Drawing.Size(169, 21);
            this.pegi_date_serch2.TabIndex = 178;
            // 
            // pegi_date_serch
            // 
            this.pegi_date_serch.Location = new System.Drawing.Point(77, 117);
            this.pegi_date_serch.Name = "pegi_date_serch";
            this.pegi_date_serch.Size = new System.Drawing.Size(169, 21);
            this.pegi_date_serch.TabIndex = 177;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(637, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 176;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pegi_cnt);
            this.groupBox1.Controls.Add(this.item_samt);
            this.groupBox1.Controls.Add(this.culgo_code_serchBtn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.item_name);
            this.groupBox1.Controls.Add(this.pegi_date);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pegi_sau);
            this.groupBox1.Controls.Add(this.pegi_code);
            this.groupBox1.Location = new System.Drawing.Point(792, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 292);
            this.groupBox1.TabIndex = 175;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "폐기정보";
            // 
            // pegi_cnt
            // 
            this.pegi_cnt.Location = new System.Drawing.Point(73, 188);
            this.pegi_cnt.Name = "pegi_cnt";
            this.pegi_cnt.Size = new System.Drawing.Size(202, 21);
            this.pegi_cnt.TabIndex = 164;
            this.pegi_cnt.Leave += new System.EventHandler(this.pegi_cnt_Leave);
            // 
            // item_samt
            // 
            this.item_samt.Location = new System.Drawing.Point(75, 108);
            this.item_samt.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.item_samt.Name = "item_samt";
            this.item_samt.Size = new System.Drawing.Size(147, 21);
            this.item_samt.TabIndex = 146;
            // 
            // culgo_code_serchBtn
            // 
            this.culgo_code_serchBtn.Location = new System.Drawing.Point(232, 52);
            this.culgo_code_serchBtn.Name = "culgo_code_serchBtn";
            this.culgo_code_serchBtn.Size = new System.Drawing.Size(87, 52);
            this.culgo_code_serchBtn.TabIndex = 137;
            this.culgo_code_serchBtn.Text = "검색";
            this.culgo_code_serchBtn.UseVisualStyleBackColor = true;
            this.culgo_code_serchBtn.Click += new System.EventHandler(this.pegi_code_serchBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 136;
            this.label12.Text = "재고량";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 134;
            this.label11.Text = "물품명";
            // 
            // item_name
            // 
            this.item_name.Enabled = false;
            this.item_name.Location = new System.Drawing.Point(73, 70);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(148, 21);
            this.item_name.TabIndex = 133;
            // 
            // pegi_date
            // 
            this.pegi_date.Location = new System.Drawing.Point(75, 150);
            this.pegi_date.Name = "pegi_date";
            this.pegi_date.Size = new System.Drawing.Size(200, 21);
            this.pegi_date.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 128;
            this.label9.Text = "폐기사유";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 127;
            this.label8.Text = "폐기량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 129;
            this.label3.Text = "폐기일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 126;
            this.label4.Text = "품목코드";
            // 
            // pegi_sau
            // 
            this.pegi_sau.Location = new System.Drawing.Point(73, 217);
            this.pegi_sau.Multiline = true;
            this.pegi_sau.Name = "pegi_sau";
            this.pegi_sau.Size = new System.Drawing.Size(200, 69);
            this.pegi_sau.TabIndex = 125;
            // 
            // pegi_code
            // 
            this.pegi_code.Enabled = false;
            this.pegi_code.Location = new System.Drawing.Point(75, 34);
            this.pegi_code.Name = "pegi_code";
            this.pegi_code.Size = new System.Drawing.Size(146, 21);
            this.pegi_code.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 174;
            this.label6.Text = "~";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 12);
            this.label7.TabIndex = 173;
            this.label7.Text = "현재 접속중인 아이디는";
            // 
            // pegiGridView
            // 
            this.pegiGridView.AllowUserToAddRows = false;
            this.pegiGridView.AllowUserToDeleteRows = false;
            this.pegiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pegiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pegiGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.pegiGridView.Location = new System.Drawing.Point(12, 156);
            this.pegiGridView.Name = "pegiGridView";
            this.pegiGridView.ReadOnly = true;
            this.pegiGridView.RowHeadersVisible = false;
            this.pegiGridView.RowHeadersWidth = 51;
            this.pegiGridView.RowTemplate.Height = 23;
            this.pegiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pegiGridView.Size = new System.Drawing.Size(619, 406);
            this.pegiGridView.TabIndex = 171;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "물품코드";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "물품명";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "재고량";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "폐기일자";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "폐기량";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // canselBtn
            // 
            this.canselBtn.Location = new System.Drawing.Point(1044, 50);
            this.canselBtn.Name = "canselBtn";
            this.canselBtn.Size = new System.Drawing.Size(78, 32);
            this.canselBtn.TabIndex = 167;
            this.canselBtn.Text = "취소";
            this.canselBtn.UseVisualStyleBackColor = true;
            this.canselBtn.Click += new System.EventHandler(this.canselBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(960, 50);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(78, 32);
            this.confirmBtn.TabIndex = 168;
            this.confirmBtn.Text = "확인";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(876, 50);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(78, 32);
            this.deleteBtn.TabIndex = 169;
            this.deleteBtn.Text = "삭제";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.change_deleteBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(792, 50);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(78, 32);
            this.changeBtn.TabIndex = 170;
            this.changeBtn.Text = "수정";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.change_deleteBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(706, 50);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(80, 32);
            this.insertBtn.TabIndex = 166;
            this.insertBtn.Text = "입력";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // item_name_serch
            // 
            this.item_name_serch.Location = new System.Drawing.Point(77, 88);
            this.item_name_serch.Name = "item_name_serch";
            this.item_name_serch.Size = new System.Drawing.Size(169, 21);
            this.item_name_serch.TabIndex = 165;
            // 
            // user_sysid
            // 
            this.user_sysid.Location = new System.Drawing.Point(338, 38);
            this.user_sysid.Name = "user_sysid";
            this.user_sysid.Size = new System.Drawing.Size(191, 21);
            this.user_sysid.TabIndex = 172;
            // 
            // serchBtn
            // 
            this.serchBtn.Location = new System.Drawing.Point(519, 117);
            this.serchBtn.Name = "serchBtn";
            this.serchBtn.Size = new System.Drawing.Size(124, 21);
            this.serchBtn.TabIndex = 164;
            this.serchBtn.Text = "조회";
            this.serchBtn.UseVisualStyleBackColor = true;
            this.serchBtn.Click += new System.EventHandler(this.serchBtn_Click);
            // 
            // PegiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 674);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pegi_date_serch2);
            this.Controls.Add(this.pegi_date_serch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pegiGridView);
            this.Controls.Add(this.canselBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.item_name_serch);
            this.Controls.Add(this.user_sysid);
            this.Controls.Add(this.serchBtn);
            this.Name = "PegiForm";
            this.ShowInTaskbar = false;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pegi_cnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_samt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegiGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker pegi_date_serch2;
        private System.Windows.Forms.DateTimePicker pegi_date_serch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown pegi_cnt;
        public System.Windows.Forms.NumericUpDown item_samt;
        private System.Windows.Forms.Button culgo_code_serchBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.DateTimePicker pegi_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pegi_sau;
        public System.Windows.Forms.TextBox pegi_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView pegiGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button canselBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox item_name_serch;
        private System.Windows.Forms.TextBox user_sysid;
        private System.Windows.Forms.Button serchBtn;
    }
}