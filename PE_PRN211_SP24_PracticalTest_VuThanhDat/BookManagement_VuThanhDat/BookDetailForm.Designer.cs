namespace BookManagement_VuThanhDat
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
            grpSearch = new GroupBox();
            cboBookCategoryId = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtBookId = new TextBox();
            lblId = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblPublicationDate = new Label();
            lblCategory = new Label();
            lblAuthor = new Label();
            txtDescription = new TextBox();
            txtBookName = new TextBox();
            lblDescription = new Label();
            lblName = new Label();
            lblHeader = new Label();
            btnCancel = new Button();
            grpSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.Yellow;
            btnSave.Location = new Point(890, 157);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 55);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(cboBookCategoryId);
            grpSearch.Controls.Add(dtpPublicationDate);
            grpSearch.Controls.Add(txtAuthor);
            grpSearch.Controls.Add(txtPrice);
            grpSearch.Controls.Add(txtQuantity);
            grpSearch.Controls.Add(txtBookId);
            grpSearch.Controls.Add(lblId);
            grpSearch.Controls.Add(lblPrice);
            grpSearch.Controls.Add(lblQuantity);
            grpSearch.Controls.Add(lblPublicationDate);
            grpSearch.Controls.Add(lblCategory);
            grpSearch.Controls.Add(lblAuthor);
            grpSearch.Controls.Add(txtDescription);
            grpSearch.Controls.Add(txtBookName);
            grpSearch.Controls.Add(lblDescription);
            grpSearch.Controls.Add(lblName);
            grpSearch.Font = new Font("Segoe UI", 13.8F);
            grpSearch.ForeColor = Color.FromArgb(255, 255, 128);
            grpSearch.Location = new Point(73, 145);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(792, 515);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "Book Info";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(215, 429);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(254, 39);
            cboBookCategoryId.TabIndex = 18;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(215, 224);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(226, 38);
            dtpPublicationDate.TabIndex = 17;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(215, 371);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(511, 38);
            txtAuthor.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(558, 292);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(169, 38);
            txtPrice.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(215, 292);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(175, 38);
            txtQuantity.TabIndex = 14;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(215, 33);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(226, 38);
            txtBookId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(192, 0, 0);
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(6, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 31);
            lblId.TabIndex = 11;
            lblId.Text = "Book ID";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.FromArgb(192, 0, 0);
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(454, 299);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(67, 31);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(192, 0, 0);
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(6, 299);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(108, 31);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            lblQuantity.Click += label5_Click;
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.BackColor = Color.FromArgb(192, 0, 0);
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(6, 231);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(193, 31);
            lblPublicationDate.TabIndex = 8;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.FromArgb(192, 0, 0);
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(6, 429);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(111, 31);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            lblCategory.Click += label3_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.FromArgb(192, 0, 0);
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(6, 371);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(90, 31);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Author";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(215, 117);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(511, 84);
            txtDescription.TabIndex = 3;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(215, 77);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(511, 38);
            txtBookName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(192, 0, 0);
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(6, 121);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 31);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(192, 0, 0);
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblName.ForeColor = Color.Yellow;
            lblName.Location = new Point(6, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(139, 31);
            lblName.TabIndex = 1;
            lblName.Text = "Book Name";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(192, 0, 0);
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(255, 255, 128);
            lblHeader.Location = new Point(73, 77);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(415, 54);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(890, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(199, 55);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1152, 749);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpSearch);
            Controls.Add(lblHeader);
            Name = "BookDetailForm";
            Text = "Add | Update a Book";
            Load += BookDetailForm_Load;
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private GroupBox grpSearch;
        private TextBox txtDescription;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblPublicationDate;
        private Label lblCategory;
        private Label label2;
        private Label lblAuthor;
        private TextBox txtBookDescription;
        private TextBox txtBookName;
        private Label lblDescription;
        private Label lblName;
        private Label lblHeader;
        private TextBox textBox1;
        private Label lblId;
        private TextBox txtBookId;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtAuthor;
        private TextBox textBox2;
        private Button btnCancel;
        private DateTimePicker dtpPublicationDate;
        private ComboBox cboBookCategoryId;
    }
}