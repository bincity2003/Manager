namespace UserInterface
{
    partial class Attendance
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstDay = new System.Windows.Forms.DateTimePicker();
            this.LastDay = new System.Windows.Forms.DateTimePicker();
            this.DButton = new System.Windows.Forms.Button();
            this.AButton = new System.Windows.Forms.Button();
            this.TotalDay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 249);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Delete absent days";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.FirstDay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LastDay, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.AButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.TotalDay, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 82);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First day";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last day";
            // 
            // FirstDay
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.FirstDay, 2);
            this.FirstDay.Location = new System.Drawing.Point(57, 3);
            this.FirstDay.Name = "FirstDay";
            this.FirstDay.Size = new System.Drawing.Size(159, 20);
            this.FirstDay.TabIndex = 2;
            // 
            // LastDay
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.LastDay, 2);
            this.LastDay.Location = new System.Drawing.Point(57, 29);
            this.LastDay.Name = "LastDay";
            this.LastDay.Size = new System.Drawing.Size(159, 20);
            this.LastDay.TabIndex = 3;
            // 
            // DButton
            // 
            this.DButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DButton.Location = new System.Drawing.Point(57, 55);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(77, 24);
            this.DButton.TabIndex = 5;
            this.DButton.Text = "Delete";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.DButton_Click);
            // 
            // AButton
            // 
            this.AButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AButton.Location = new System.Drawing.Point(140, 55);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(80, 24);
            this.AButton.TabIndex = 6;
            this.AButton.Text = "Add";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // TotalDay
            // 
            this.TotalDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalDay.AutoSize = true;
            this.TotalDay.Location = new System.Drawing.Point(8, 60);
            this.TotalDay.Name = "TotalDay";
            this.TotalDay.Size = new System.Drawing.Size(37, 13);
            this.TotalDay.TabIndex = 7;
            this.TotalDay.Text = "Total: ";
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.HistoryBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.Location = new System.Drawing.Point(3, 16);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(223, 117);
            this.HistoryBox.TabIndex = 0;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 249);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FirstDay;
        private System.Windows.Forms.DateTimePicker LastDay;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TotalDay;
        private System.Windows.Forms.ListBox HistoryBox;
    }
}