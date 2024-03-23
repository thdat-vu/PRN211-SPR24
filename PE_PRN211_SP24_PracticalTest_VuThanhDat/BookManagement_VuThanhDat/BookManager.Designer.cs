namespace BookManagement_VuThanhDat
{
	partial class BookManager
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
            grpSearch = new GroupBox();
            btnSearch = new Button();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            lblBookDescription = new Label();
            lblBookName = new Label();
            dgvBookList = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = Color.FromArgb(192, 0, 0);
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(255, 255, 128);
            lblHeader.Location = new Point(48, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(299, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Manager";
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(txtBookDescription);
            grpSearch.Controls.Add(txtBookName);
            grpSearch.Controls.Add(lblBookDescription);
            grpSearch.Controls.Add(lblBookName);
            grpSearch.Font = new Font("Segoe UI", 13.8F);
            grpSearch.ForeColor = Color.FromArgb(255, 255, 128);
            grpSearch.Location = new Point(48, 88);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(997, 124);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = " Search Criteria ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Yellow;
            btnSearch.Location = new Point(880, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(95, 55);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(491, 64);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(194, 38);
            txtBookDescription.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(151, 64);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(105, 38);
            txtBookName.TabIndex = 2;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.BackColor = Color.FromArgb(192, 0, 0);
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookDescription.ForeColor = Color.Yellow;
            lblBookDescription.Location = new Point(285, 67);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(200, 31);
            lblBookDescription.TabIndex = 3;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.FromArgb(192, 0, 0);
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(6, 67);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(139, 31);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Book Name";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(48, 251);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(870, 307);
            dgvBookList.TabIndex = 2;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(192, 0, 0);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(950, 253);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(199, 55);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create New Book";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Yellow;
            btnUpdate.Location = new Point(950, 327);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(199, 55);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update A Book";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Yellow;
            btnDelete.Location = new Point(950, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(199, 55);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete A Book";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(192, 0, 0);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(950, 499);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(199, 55);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1232, 648);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvBookList);
            Controls.Add(grpSearch);
            Controls.Add(lblHeader);
            Name = "BookManager";
            Text = "Book Manager";
            Load += BookManager_Load;
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
		private GroupBox grpSearch;
		private Label lblBookName;
		private Label lblBookDescription;
		private TextBox txtBookDescription;
		private TextBox txtBookName;
		private Button btnSearch;
		private DataGridView dgvBookList;
		private Button btnCreate;
		private Button btnUpdate;
		private Button btnDelete;
		private Button btnQuit;
	}
}
