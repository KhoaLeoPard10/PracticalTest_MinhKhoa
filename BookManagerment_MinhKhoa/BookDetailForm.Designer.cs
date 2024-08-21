namespace BookManagerment_MinhKhoa
{
    partial class BookDetailForm
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
            lblHeader = new Label();
            lblBookName = new Label();
            lblBookID = new Label();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            grbBookInfo = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            lblPrice = new Label();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            lblPublicationDate = new Label();
            lblQuantity = new Label();
            lblAuthor = new Label();
            lblCategory = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(18, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(454, 60);
            lblHeader.TabIndex = 6;
            lblHeader.Text = "Add | Update a Book";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(32, 111);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 12;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookID.ForeColor = Color.Yellow;
            lblBookID.Location = new Point(32, 49);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(100, 31);
            lblBookID.TabIndex = 4;
            lblBookID.Text = "Book ID";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(238, 49);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(700, 38);
            txtBookId.TabIndex = 0;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(238, 111);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(700, 38);
            txtBookName.TabIndex = 1;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(23, 93);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(1009, 670);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(238, 607);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(220, 39);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(238, 391);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(216, 38);
            dtpPublicationDate.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(613, 456);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 31);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(238, 530);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(690, 38);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(698, 456);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(230, 38);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(238, 456);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(241, 38);
            txtQuantity.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(238, 178);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(700, 191);
            txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(32, 170);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 31);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(32, 392);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(193, 31);
            lblPublicationDate.TabIndex = 10;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(32, 456);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 31);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(32, 530);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 31);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(32, 607);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(1067, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(286, 52);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(1067, 219);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(286, 52);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1381, 795);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Name = "BookDetailForm";
            Text = "Add | Updata a Book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblBookName;
        private Label lblBookID;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private GroupBox grbBookInfo;
        private TextBox txtDescription;
        private Label lblDescription;
        private Label lblPublicationDate;
        private Label lblQuantity;
        private Label lblAuthor;
        private Label lblCategory;
        private Button btnSave;
        private Label lblPrice;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnCancel;
        private DateTimePicker dtpPublicationDate;
        private ComboBox cboBookCategoryId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}