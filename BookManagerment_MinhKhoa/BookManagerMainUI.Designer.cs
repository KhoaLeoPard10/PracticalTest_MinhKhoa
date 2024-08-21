namespace BookManagerment_MinhKhoa
{
    partial class BookManagerMainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            grbSearchCriteria = new GroupBox();
            btnSearch = new Button();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookName = new Label();
            lblBookDescription = new Label();
            lblBookList = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvBookList = new DataGridView();
            lblCopyRight = new Label();
            grbSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(448, 81);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // grbSearchCriteria
            // 
            grbSearchCriteria.Controls.Add(btnSearch);
            grbSearchCriteria.Controls.Add(txtDescription);
            grbSearchCriteria.Controls.Add(txtBookName);
            grbSearchCriteria.Controls.Add(lblBookName);
            grbSearchCriteria.Controls.Add(lblBookDescription);
            grbSearchCriteria.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbSearchCriteria.ForeColor = Color.Yellow;
            grbSearchCriteria.Location = new Point(21, 97);
            grbSearchCriteria.Name = "grbSearchCriteria";
            grbSearchCriteria.Size = new Size(1254, 121);
            grbSearchCriteria.TabIndex = 0;
            grbSearchCriteria.TabStop = false;
            grbSearchCriteria.Text = " Search Criteria ";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Yellow;
            btnSearch.Location = new Point(931, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(286, 68);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(665, 49);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(206, 38);
            txtDescription.TabIndex = 1;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(177, 49);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(206, 38);
            txtBookName.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(32, 49);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookDescription.ForeColor = Color.Yellow;
            lblBookDescription.Location = new Point(459, 49);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(200, 31);
            lblBookDescription.TabIndex = 1;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(22, 235);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(112, 31);
            lblBookList.TabIndex = 2;
            lblBookList.Text = "Book List";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(952, 255);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(286, 68);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create a book";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(952, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(286, 68);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update a book";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(952, 453);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(286, 68);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete a book";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Yellow;
            btnExit.Location = new Point(952, 546);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(286, 68);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(22, 288);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(870, 304);
            dgvBookList.TabIndex = 4;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCopyRight.ForeColor = Color.Yellow;
            lblCopyRight.Location = new Point(22, 612);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(141, 23);
            lblCopyRight.TabIndex = 13;
            lblCopyRight.Text = "© 2024 Leopard";
            // 
            // BookManagerMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1291, 652);
            Controls.Add(lblCopyRight);
            Controls.Add(dgvBookList);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblBookList);
            Controls.Add(grbSearchCriteria);
            Controls.Add(lblHeader);
            ForeColor = Color.Black;
            Name = "BookManagerMainUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Manager";
            Load += BookManagerMainUI_Load;
            grbSearchCriteria.ResumeLayout(false);
            grbSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox grbSearchCriteria;
        private Label lblBookName;
        private Label lblBookDescription;
        private Label lblBookList;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvBookList;
        private Label lblCopyRight;
    }
}
