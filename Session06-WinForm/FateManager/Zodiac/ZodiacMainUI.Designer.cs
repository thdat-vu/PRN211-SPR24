namespace Zodiac
{
    partial class ZodiacMainUI
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
            btnShowImage = new Button();
            lblDay = new Label();
            picImageSign = new PictureBox();
            pnl = new Panel();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            lblMonth = new Label();
            lblZodiacSign = new Label();
            btnCheckZodiac = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picImageSign).BeginInit();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowImage
            // 
            btnShowImage.BackColor = Color.IndianRed;
            btnShowImage.FlatStyle = FlatStyle.Flat;
            btnShowImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowImage.ForeColor = Color.Yellow;
            btnShowImage.Location = new Point(31, 78);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(167, 89);
            btnShowImage.TabIndex = 0;
            btnShowImage.Text = "Show Image";
            btnShowImage.UseVisualStyleBackColor = false;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.ForeColor = Color.FromArgb(255, 255, 128);
            lblDay.Location = new Point(12, 261);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(108, 20);
            lblDay.TabIndex = 1;
            lblDay.Text = "Your birth day";
            // 
            // picImageSign
            // 
            picImageSign.BackColor = Color.FromArgb(255, 255, 128);
            picImageSign.Location = new Point(0, 3);
            picImageSign.Name = "picImageSign";
            picImageSign.Size = new Size(503, 384);
            picImageSign.SizeMode = PictureBoxSizeMode.AutoSize;
            picImageSign.TabIndex = 2;
            picImageSign.TabStop = false;
            // 
            // pnl
            // 
            pnl.AutoScroll = true;
            pnl.BackColor = Color.Silver;
            pnl.Controls.Add(picImageSign);
            pnl.Location = new Point(539, 21);
            pnl.Name = "pnl";
            pnl.Size = new Size(527, 488);
            pnl.TabIndex = 3;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(146, 254);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(125, 27);
            txtDay.TabIndex = 4;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(146, 301);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(125, 27);
            txtMonth.TabIndex = 5;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonth.ForeColor = Color.FromArgb(255, 255, 128);
            lblMonth.Location = new Point(12, 304);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(130, 20);
            lblMonth.TabIndex = 6;
            lblMonth.Text = "Your birth month";
            // 
            // lblZodiacSign
            // 
            lblZodiacSign.AutoSize = true;
            lblZodiacSign.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblZodiacSign.ForeColor = Color.FromArgb(255, 255, 128);
            lblZodiacSign.Location = new Point(9, 454);
            lblZodiacSign.Name = "lblZodiacSign";
            lblZodiacSign.Size = new Size(262, 41);
            lblZodiacSign.TabIndex = 7;
            lblZodiacSign.Text = "Your zodiac sign: ";
            lblZodiacSign.Click += lblZodiacSign_Click;
            // 
            // btnCheckZodiac
            // 
            btnCheckZodiac.BackColor = Color.IndianRed;
            btnCheckZodiac.FlatStyle = FlatStyle.Flat;
            btnCheckZodiac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckZodiac.ForeColor = Color.Yellow;
            btnCheckZodiac.Location = new Point(130, 347);
            btnCheckZodiac.Name = "btnCheckZodiac";
            btnCheckZodiac.Size = new Size(141, 66);
            btnCheckZodiac.TabIndex = 8;
            btnCheckZodiac.Text = "Check Your Sign";
            btnCheckZodiac.UseVisualStyleBackColor = false;
            btnCheckZodiac.Click += btnCheckZodiac_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 255, 128);
            label1.Location = new Point(31, 9);
            label1.Name = "label1";
            label1.Size = new Size(509, 41);
            label1.TabIndex = 9;
            label1.Text = "Welcome to Zodiac Sign Calculator";
            // 
            // ZodiacMainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1078, 690);
            Controls.Add(label1);
            Controls.Add(btnCheckZodiac);
            Controls.Add(lblZodiacSign);
            Controls.Add(lblMonth);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(pnl);
            Controls.Add(lblDay);
            Controls.Add(btnShowImage);
            Name = "ZodiacMainUI";
            Text = "Zodiac Calculator";
            ((System.ComponentModel.ISupportInitialize)picImageSign).EndInit();
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowImage;
        private Label lblDay;
        private PictureBox picImageSign;
        private Panel pnl;
        private TextBox txtDay;
        private TextBox txtMonth;
        private Label lblMonth;
        private Label lblZodiacSign;
        private Button btnCheckZodiac;
        private Label label1;
    }
}
