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
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(255, 255, 128);
            lblHeader.Location = new Point(42, 16);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(242, 45);
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
            grpSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            grpSearch.ForeColor = Color.FromArgb(255, 255, 128);
            grpSearch.Location = new Point(42, 66);
            grpSearch.Margin = new Padding(3, 2, 3, 2);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(3, 2, 3, 2);
            grpSearch.Size = new Size(872, 93);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = " Search Criteria ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.Yellow;
            btnSearch.Location = new Point(770, 41);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 41);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(430, 48);
            txtBookDescription.Margin = new Padding(3, 2, 3, 2);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(170, 32);
            txtBookDescription.TabIndex = 4;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(132, 48);
            txtBookName.Margin = new Padding(3, 2, 3, 2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(92, 32);
            txtBookName.TabIndex = 2;
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.BackColor = Color.FromArgb(192, 0, 0);
            lblBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookDescription.ForeColor = Color.Yellow;
            lblBookDescription.Location = new Point(249, 50);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(166, 25);
            lblBookDescription.TabIndex = 3;
            lblBookDescription.Text = "Book Description";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.FromArgb(192, 0, 0);
            lblBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookName.ForeColor = Color.Yellow;
            lblBookName.Location = new Point(5, 50);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(116, 25);
            lblBookName.TabIndex = 1;
            lblBookName.Text = "Book Name";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(42, 188);
            dgvBookList.Margin = new Padding(3, 2, 3, 2);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(761, 230);
            dgvBookList.TabIndex = 2;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(192, 0, 0);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.Yellow;
            btnCreate.Location = new Point(831, 190);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(174, 41);
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
            btnUpdate.Location = new Point(831, 245);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(174, 41);
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
            btnDelete.Location = new Point(831, 307);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(174, 41);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete A Book";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(192, 0, 0);
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.ForeColor = Color.Yellow;
            btnQuit.Location = new Point(831, 374);
            btnQuit.Margin = new Padding(3, 2, 3, 2);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(174, 41);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(1078, 486);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvBookList);
            Controls.Add(grpSearch);
            Controls.Add(lblHeader);
            Margin = new Padding(3, 2, 3, 2);
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
