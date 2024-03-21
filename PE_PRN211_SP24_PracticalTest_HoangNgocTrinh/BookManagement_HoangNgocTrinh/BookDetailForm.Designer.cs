namespace BookManagement_HoangNgocTrinh
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
            btnSave = new Button();
            grbBookInfo = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            lblPrice = new Label();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblCategory = new Label();
            lblAuthor = new Label();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblDescription = new Label();
            txtQuantity = new TextBox();
            txtBookId = new TextBox();
            lblBookName = new Label();
            lblBookID = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            grbBookInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(1098, 128);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 51);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grbBookInfo
            // 
            grbBookInfo.Controls.Add(cboBookCategoryId);
            grbBookInfo.Controls.Add(dtpPublicationDate);
            grbBookInfo.Controls.Add(lblPrice);
            grbBookInfo.Controls.Add(txtAuthor);
            grbBookInfo.Controls.Add(txtPrice);
            grbBookInfo.Controls.Add(txtDescription);
            grbBookInfo.Controls.Add(txtBookName);
            grbBookInfo.Controls.Add(lblCategory);
            grbBookInfo.Controls.Add(lblAuthor);
            grbBookInfo.Controls.Add(lblQuantity);
            grbBookInfo.Controls.Add(lblPublicationDate);
            grbBookInfo.Controls.Add(lblDescription);
            grbBookInfo.Controls.Add(txtQuantity);
            grbBookInfo.Controls.Add(txtBookId);
            grbBookInfo.Controls.Add(lblBookName);
            grbBookInfo.Controls.Add(lblBookID);
            grbBookInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            grbBookInfo.ForeColor = Color.Yellow;
            grbBookInfo.Location = new Point(50, 113);
            grbBookInfo.Name = "grbBookInfo";
            grbBookInfo.Size = new Size(1022, 575);
            grbBookInfo.TabIndex = 0;
            grbBookInfo.TabStop = false;
            grbBookInfo.Text = " Book Info ";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(293, 511);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(219, 39);
            cboBookCategoryId.TabIndex = 7;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(293, 326);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(242, 38);
            dtpPublicationDate.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(706, 388);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 31);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(293, 449);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(696, 38);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(791, 385);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(198, 38);
            txtPrice.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(293, 180);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(696, 117);
            txtDescription.TabIndex = 2;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(293, 116);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(696, 38);
            txtBookName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(35, 514);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(35, 452);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 31);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Author";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(35, 388);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 31);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(35, 332);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(193, 31);
            lblPublicationDate.TabIndex = 6;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(35, 183);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 31);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(293, 385);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(198, 38);
            txtQuantity.TabIndex = 4;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(293, 57);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(696, 38);
            txtBookId.TabIndex = 0;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(35, 119);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 4;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookID.ForeColor = Color.Yellow;
            lblBookID.Location = new Point(35, 60);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(100, 31);
            lblBookID.TabIndex = 3;
            lblBookID.Text = "Book ID";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(32, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(454, 60);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(1098, 216);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 51);
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
            ClientSize = new Size(1314, 716);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grbBookInfo);
            Controls.Add(lblHeader);
            Name = "BookDetailForm";
            Text = "Add | Update a Book";
            Load += BookDetailForm_Load;
            grbBookInfo.ResumeLayout(false);
            grbBookInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox grbBookInfo;
        private TextBox txtQuantity;
        private TextBox txtBookId;
        private Label lblBookName;
        private Label lblBookID;
        private Label lblHeader;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtBookName;
        private Label lblCategory;
        private Label lblAuthor;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblDescription;
        private Button btnCancel;
        private Label lblPrice;
        private ComboBox cboBookCategoryId;
        private DateTimePicker dtpPublicationDate;
    }
}