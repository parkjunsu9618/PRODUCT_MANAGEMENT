namespace product_management
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("관리자설정");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("관리자", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("물품등록");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("입고관리");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("출고관리");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("재고관리");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("폐기관리");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("물품관리", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PagePanel = new System.Windows.Forms.Panel();
            this.contentSeletor = new MaterialSkin.Controls.MaterialTabSelector();
            this.tapControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Statement = new System.Windows.Forms.TabPage();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.adminName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.serchBtn = new FontAwesome.Sharp.IconButton();
            this.insertBtn = new FontAwesome.Sharp.IconButton();
            this.canselBtn = new FontAwesome.Sharp.IconButton();
            this.changeBtn = new FontAwesome.Sharp.IconButton();
            this.confirmBtn = new FontAwesome.Sharp.IconButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MsgPanel = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MainTree = new System.Windows.Forms.TreeView();
            this.label_hint = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.PagePanel.SuspendLayout();
            this.tapControl.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.FunctionPanel.SuspendLayout();
            this.MsgPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.79714F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.20287F));
            this.tableLayoutPanel1.Controls.Add(this.PagePanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.InfoPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FunctionPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MsgPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MainTree, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.035176F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.05025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.849294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 737);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // PagePanel
            // 
            this.PagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagePanel.Controls.Add(this.contentSeletor);
            this.PagePanel.Controls.Add(this.tapControl);
            this.PagePanel.Location = new System.Drawing.Point(180, 54);
            this.PagePanel.Name = "PagePanel";
            this.PagePanel.Size = new System.Drawing.Size(1017, 621);
            this.PagePanel.TabIndex = 25;
            // 
            // contentSeletor
            // 
            this.contentSeletor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentSeletor.BaseTabControl = this.tapControl;
            this.contentSeletor.Depth = 0;
            this.contentSeletor.Location = new System.Drawing.Point(4, 0);
            this.contentSeletor.MouseState = MaterialSkin.MouseState.HOVER;
            this.contentSeletor.Name = "contentSeletor";
            this.contentSeletor.Size = new System.Drawing.Size(1016, 32);
            this.contentSeletor.TabIndex = 15;
            this.contentSeletor.Text = "materialTabSelector1";
            // 
            // tapControl
            // 
            this.tapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tapControl.Controls.Add(this.Statement);
            this.tapControl.Depth = 0;
            this.tapControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tapControl.HotTrack = true;
            this.tapControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tapControl.Location = new System.Drawing.Point(2, 38);
            this.tapControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tapControl.Name = "tapControl";
            this.tapControl.SelectedIndex = 0;
            this.tapControl.Size = new System.Drawing.Size(1017, 580);
            this.tapControl.TabIndex = 14;
            this.tapControl.Tag = "statement";
            this.tapControl.SelectedIndexChanged += new System.EventHandler(this.tapControl_SelectedIndexChanged);
            this.tapControl.Resize += new System.EventHandler(this.tapControl_Resize);
            // 
            // Statement
            // 
            this.Statement.Location = new System.Drawing.Point(4, 22);
            this.Statement.Name = "Statement";
            this.Statement.Padding = new System.Windows.Forms.Padding(3);
            this.Statement.Size = new System.Drawing.Size(1009, 554);
            this.Statement.TabIndex = 0;
            this.Statement.Tag = "Statement";
            this.Statement.Text = "메인";
            this.Statement.UseVisualStyleBackColor = true;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.adminName);
            this.InfoPanel.Controls.Add(this.materialLabel3);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(3, 681);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(171, 53);
            this.InfoPanel.TabIndex = 27;
            // 
            // adminName
            // 
            this.adminName.AutoSize = true;
            this.adminName.Depth = 0;
            this.adminName.Font = new System.Drawing.Font("Roboto", 11F);
            this.adminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.adminName.Location = new System.Drawing.Point(78, 13);
            this.adminName.MouseState = MaterialSkin.MouseState.HOVER;
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(42, 19);
            this.adminName.TabIndex = 22;
            this.adminName.Text = "박준수";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "관리자 : ";
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionPanel.Controls.Add(this.serchBtn);
            this.FunctionPanel.Controls.Add(this.insertBtn);
            this.FunctionPanel.Controls.Add(this.canselBtn);
            this.FunctionPanel.Controls.Add(this.changeBtn);
            this.FunctionPanel.Controls.Add(this.confirmBtn);
            this.FunctionPanel.Controls.Add(this.deleteBtn);
            this.FunctionPanel.Location = new System.Drawing.Point(180, 3);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(1017, 45);
            this.FunctionPanel.TabIndex = 28;
            // 
            // serchBtn
            // 
            this.serchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serchBtn.FlatAppearance.BorderSize = 0;
            this.serchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serchBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.serchBtn.IconColor = System.Drawing.Color.Black;
            this.serchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.serchBtn.IconSize = 25;
            this.serchBtn.Location = new System.Drawing.Point(626, 4);
            this.serchBtn.Name = "serchBtn";
            this.serchBtn.Size = new System.Drawing.Size(48, 39);
            this.serchBtn.TabIndex = 55;
            this.serchBtn.UseVisualStyleBackColor = true;
            this.serchBtn.Click += new System.EventHandler(this.serchBtn_Click);
            this.serchBtn.MouseEnter += new System.EventHandler(this.serchBtn_MouseEnter);
            this.serchBtn.MouseLeave += new System.EventHandler(this.serchBtn_MouseLeave);
            // 
            // insertBtn
            // 
            this.insertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertBtn.FlatAppearance.BorderSize = 0;
            this.insertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.insertBtn.IconColor = System.Drawing.Color.Black;
            this.insertBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.insertBtn.IconSize = 25;
            this.insertBtn.Location = new System.Drawing.Point(692, 3);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(48, 39);
            this.insertBtn.TabIndex = 21;
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click_1);
            this.insertBtn.MouseEnter += new System.EventHandler(this.serchBtn_MouseEnter);
            this.insertBtn.MouseLeave += new System.EventHandler(this.serchBtn_MouseLeave);
            // 
            // canselBtn
            // 
            this.canselBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canselBtn.FlatAppearance.BorderSize = 0;
            this.canselBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canselBtn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.canselBtn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.canselBtn.IconColor = System.Drawing.Color.Red;
            this.canselBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.canselBtn.IconSize = 25;
            this.canselBtn.Location = new System.Drawing.Point(956, 3);
            this.canselBtn.Name = "canselBtn";
            this.canselBtn.Size = new System.Drawing.Size(48, 39);
            this.canselBtn.TabIndex = 17;
            this.canselBtn.UseVisualStyleBackColor = true;
            this.canselBtn.Click += new System.EventHandler(this.canselBtn_Click);
            this.canselBtn.MouseEnter += new System.EventHandler(this.serchBtn_MouseEnter);
            this.canselBtn.MouseLeave += new System.EventHandler(this.serchBtn_MouseLeave);
            // 
            // changeBtn
            // 
            this.changeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeBtn.FlatAppearance.BorderSize = 0;
            this.changeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeBtn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changeBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.changeBtn.IconColor = System.Drawing.Color.Black;
            this.changeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeBtn.IconSize = 25;
            this.changeBtn.Location = new System.Drawing.Point(758, 3);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(48, 39);
            this.changeBtn.TabIndex = 20;
            this.changeBtn.Tag = "수정";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            this.changeBtn.MouseEnter += new System.EventHandler(this.serchBtn_MouseEnter);
            this.changeBtn.MouseLeave += new System.EventHandler(this.serchBtn_MouseLeave);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.confirmBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.confirmBtn.IconColor = System.Drawing.Color.Green;
            this.confirmBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmBtn.IconSize = 25;
            this.confirmBtn.Location = new System.Drawing.Point(890, 3);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(48, 39);
            this.confirmBtn.TabIndex = 18;
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            this.confirmBtn.MouseEnter += new System.EventHandler(this.serchBtn_MouseEnter);
            this.confirmBtn.MouseLeave += new System.EventHandler(this.serchBtn_MouseLeave);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.deleteBtn.IconColor = System.Drawing.Color.Black;
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 25;
            this.deleteBtn.Location = new System.Drawing.Point(824, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(48, 39);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.changeBtn_Click);
            this.deleteBtn.MouseEnter += new System.EventHandler(this.serchBtn_MouseEnter);
            this.deleteBtn.MouseLeave += new System.EventHandler(this.serchBtn_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 45);
            this.panel5.TabIndex = 29;
            // 
            // MsgPanel
            // 
            this.MsgPanel.Controls.Add(this.message);
            this.MsgPanel.Controls.Add(this.materialLabel1);
            this.MsgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsgPanel.Location = new System.Drawing.Point(180, 681);
            this.MsgPanel.Name = "MsgPanel";
            this.MsgPanel.Size = new System.Drawing.Size(1017, 53);
            this.MsgPanel.TabIndex = 24;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(191, 13);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(274, 25);
            this.message.TabIndex = 23;
            this.message.Text = "안녕하세요 로그인 되었습니다.";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(46, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Message : ";
            // 
            // MainTree
            // 
            this.MainTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTree.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTree.ForeColor = System.Drawing.Color.Black;
            this.MainTree.FullRowSelect = true;
            this.MainTree.LineColor = System.Drawing.Color.Gray;
            this.MainTree.Location = new System.Drawing.Point(3, 54);
            this.MainTree.Name = "MainTree";
            treeNode1.Name = "관리자설정";
            treeNode1.Tag = "AdminForm";
            treeNode1.Text = "관리자설정";
            treeNode2.Name = "노드0";
            treeNode2.Tag = "";
            treeNode2.Text = "관리자";
            treeNode3.Name = "물품등록";
            treeNode3.Tag = "ItemForm";
            treeNode3.Text = "물품등록";
            treeNode4.Name = "입고관리";
            treeNode4.Tag = "IpgoForm";
            treeNode4.Text = "입고관리";
            treeNode5.Name = "출고관리";
            treeNode5.Tag = "CulgoForm";
            treeNode5.Text = "출고관리";
            treeNode6.Name = "재고관리";
            treeNode6.Tag = "Stock";
            treeNode6.Text = "재고관리";
            treeNode7.Name = "폐기관리";
            treeNode7.Tag = "PegiForm";
            treeNode7.Text = "폐기관리";
            treeNode8.Name = "노드1";
            treeNode8.Tag = "";
            treeNode8.Text = "물품관리";
            this.MainTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode8});
            this.MainTree.Size = new System.Drawing.Size(171, 621);
            this.MainTree.TabIndex = 26;
            this.MainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTree_AfterSelect);
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label_hint.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label_hint.ForeColor = System.Drawing.Color.White;
            this.label_hint.Location = new System.Drawing.Point(803, 45);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(51, 14);
            this.label_hint.TabIndex = 1;
            this.label_hint.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.label_hint);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "물품관리";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PagePanel.ResumeLayout(false);
            this.tapControl.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.FunctionPanel.ResumeLayout(false);
            this.MsgPanel.ResumeLayout(false);
            this.MsgPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel MsgPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel PagePanel;
        private System.Windows.Forms.TreeView MainTree;
        private System.Windows.Forms.Panel InfoPanel;
        private MaterialSkin.Controls.MaterialLabel adminName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel FunctionPanel;
        private FontAwesome.Sharp.IconButton canselBtn;
        private FontAwesome.Sharp.IconButton changeBtn;
        private FontAwesome.Sharp.IconButton confirmBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private System.Windows.Forms.Panel panel5;
        public MaterialSkin.Controls.MaterialTabControl tapControl;
        private MaterialSkin.Controls.MaterialTabSelector contentSeletor;
        private System.Windows.Forms.TabPage Statement;
        private FontAwesome.Sharp.IconButton insertBtn;
        private FontAwesome.Sharp.IconButton serchBtn;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label_hint;
    }
}