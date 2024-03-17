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
            btnSave.Location = new Point(779, 118);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 41);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
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
            grpSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            grpSearch.ForeColor = Color.FromArgb(255, 255, 128);
            grpSearch.Location = new Point(64, 109);
            grpSearch.Margin = new Padding(3, 2, 3, 2);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(3, 2, 3, 2);
            grpSearch.Size = new Size(693, 386);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "Book Info";
            // 
            // cboBookCategoryId
            // 
            cboBookCategoryId.FormattingEnabled = true;
            cboBookCategoryId.Location = new Point(188, 322);
            cboBookCategoryId.Margin = new Padding(3, 2, 3, 2);
            cboBookCategoryId.Name = "cboBookCategoryId";
            cboBookCategoryId.Size = new Size(223, 33);
            cboBookCategoryId.TabIndex = 18;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(188, 168);
            dtpPublicationDate.Margin = new Padding(3, 2, 3, 2);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(198, 32);
            dtpPublicationDate.TabIndex = 17;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(188, 278);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(448, 32);
            txtAuthor.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(488, 219);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(148, 32);
            txtPrice.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(188, 219);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(154, 32);
            txtQuantity.TabIndex = 14;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(188, 25);
            txtBookId.Margin = new Padding(3, 2, 3, 2);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(198, 32);
            txtBookId.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.FromArgb(192, 0, 0);
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(5, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(84, 25);
            lblId.TabIndex = 11;
            lblId.Text = "Book ID";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.FromArgb(192, 0, 0);
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Yellow;
            lblPrice.Location = new Point(397, 224);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 25);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(192, 0, 0);
            lblQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.ForeColor = Color.Yellow;
            lblQuantity.Location = new Point(5, 224);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(89, 25);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            lblQuantity.Click += label5_Click;
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.BackColor = Color.FromArgb(192, 0, 0);
            lblPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPublicationDate.ForeColor = Color.Yellow;
            lblPublicationDate.Location = new Point(5, 173);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(159, 25);
            lblPublicationDate.TabIndex = 8;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.FromArgb(192, 0, 0);
            lblCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategory.ForeColor = Color.Yellow;
            lblCategory.Location = new Point(5, 322);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(94, 25);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            lblCategory.Click += label3_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.FromArgb(192, 0, 0);
            lblAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAuthor.ForeColor = Color.Yellow;
            lblAuthor.Location = new Point(5, 278);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(75, 25);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "Author";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(188, 88);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(448, 64);
            txtDescription.TabIndex = 3;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(188, 58);
            txtBookName.Margin = new Padding(3, 2, 3, 2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(448, 32);
            txtBookName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.FromArgb(192, 0, 0);
            lblDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.Yellow;
            lblDescription.Location = new Point(5, 91);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(114, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(192, 0, 0);
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Yellow;
            lblName.Location = new Point(5, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Book Name";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(192, 0, 0);
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(255, 255, 128);
            lblHeader.Location = new Point(64, 58);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(334, 45);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Add | Update a Book";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(779, 182);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 41);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1008, 562);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(grpSearch);
            Controls.Add(lblHeader);
            Margin = new Padding(3, 2, 3, 2);
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