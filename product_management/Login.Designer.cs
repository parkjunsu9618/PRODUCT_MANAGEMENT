namespace product_management
{
    partial class Login
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
            this.id_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.admin_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.admin_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ellipseControl1 = new product_management.EllipseControl();
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_label.ForeColor = System.Drawing.Color.Red;
            this.id_label.Location = new System.Drawing.Point(83, 366);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(220, 16);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "아이디가 존재 하지 않습니다.";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass_label.ForeColor = System.Drawing.Color.Red;
            this.pass_label.Location = new System.Drawing.Point(83, 366);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(162, 16);
            this.pass_label.TabIndex = 3;
            this.pass_label.Text = "비밀번호가 틀립니다.";
            // 
            // admin_id
            // 
            this.admin_id.Depth = 0;
            this.admin_id.ForeColor = System.Drawing.Color.Maroon;
            this.admin_id.Hint = "";
            this.admin_id.Location = new System.Drawing.Point(104, 265);
            this.admin_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.admin_id.Name = "admin_id";
            this.admin_id.PasswordChar = '\0';
            this.admin_id.SelectedText = "";
            this.admin_id.SelectionLength = 0;
            this.admin_id.SelectionStart = 0;
            this.admin_id.Size = new System.Drawing.Size(187, 23);
            this.admin_id.TabIndex = 1;
            this.admin_id.UseSystemPasswordChar = false;
            // 
            // admin_pass
            // 
            this.admin_pass.Depth = 0;
            this.admin_pass.Hint = "";
            this.admin_pass.Location = new System.Drawing.Point(105, 301);
            this.admin_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.admin_pass.Name = "admin_pass";
            this.admin_pass.PasswordChar = '●';
            this.admin_pass.SelectedText = "";
            this.admin_pass.SelectionLength = 0;
            this.admin_pass.SelectionStart = 0;
            this.admin_pass.Size = new System.Drawing.Size(187, 23);
            this.admin_pass.TabIndex = 2;
            this.admin_pass.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 263);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 18);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "아이디 :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(16, 303);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 18);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "비밀번호 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::product_management.Properties.Resources.thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(124, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::product_management.Properties.Resources.thumbnail;
            this.pictureBox2.Location = new System.Drawing.Point(-195, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 50;
            this.ellipseControl1.TargetControl = this;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.loginBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.loginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginBtn.Location = new System.Drawing.Point(297, 263);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 74);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 594);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admin_pass);
            this.Controls.Add(this.admin_id);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.id_label);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label pass_label;
        private EllipseControl ellipseControl1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField admin_pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField admin_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton loginBtn;
    }
}