namespace UserInterface
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DCheck = new System.Windows.Forms.CheckBox();
            this.AButton = new System.Windows.Forms.Button();
            this.PCheck = new System.Windows.Forms.CheckBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TShow = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AForm = new System.Windows.Forms.Button();
            this.ESelect = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEmployeeToolStripMenuItem,
            this.advancedToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edit employee";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.EditEmployeeToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.advancedToolStripMenuItem.Text = "Advanced";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.34234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.65766F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.45033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.54967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 199);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DCheck);
            this.groupBox2.Controls.Add(this.AButton);
            this.groupBox2.Controls.Add(this.PCheck);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.DText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add new task";
            // 
            // DCheck
            // 
            this.DCheck.AutoSize = true;
            this.DCheck.Location = new System.Drawing.Point(6, 46);
            this.DCheck.Name = "DCheck";
            this.DCheck.Size = new System.Drawing.Size(68, 17);
            this.DCheck.TabIndex = 7;
            this.DCheck.Text = "Deadline";
            this.DCheck.UseVisualStyleBackColor = true;
            this.DCheck.CheckedChanged += new System.EventHandler(this.DCheck_CheckedChanged);
            // 
            // AButton
            // 
            this.AButton.Location = new System.Drawing.Point(114, 65);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(112, 23);
            this.AButton.TabIndex = 6;
            this.AButton.Text = "Add";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.AButton_Click);
            // 
            // PCheck
            // 
            this.PCheck.AutoSize = true;
            this.PCheck.Location = new System.Drawing.Point(6, 69);
            this.PCheck.Name = "PCheck";
            this.PCheck.Size = new System.Drawing.Size(82, 17);
            this.PCheck.TabIndex = 5;
            this.PCheck.Text = "High Priority";
            this.PCheck.UseVisualStyleBackColor = true;
            // 
            // DatePicker
            // 
            this.DatePicker.Enabled = false;
            this.DatePicker.Location = new System.Drawing.Point(81, 43);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(145, 20);
            this.DatePicker.TabIndex = 4;
            // 
            // DText
            // 
            this.DText.Location = new System.Drawing.Point(69, 13);
            this.DText.Name = "DText";
            this.DText.Size = new System.Drawing.Size(157, 20);
            this.DText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TShow);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(237, 3);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 3);
            this.groupBox3.Size = new System.Drawing.Size(315, 193);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task Panel";
            // 
            // TShow
            // 
            this.TShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TShow.FormattingEnabled = true;
            this.TShow.Location = new System.Drawing.Point(3, 16);
            this.TShow.Name = "TShow";
            this.TShow.Size = new System.Drawing.Size(309, 174);
            this.TShow.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AForm);
            this.groupBox1.Controls.Add(this.ESelect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // AForm
            // 
            this.AForm.Location = new System.Drawing.Point(153, 14);
            this.AForm.Name = "AForm";
            this.AForm.Size = new System.Drawing.Size(72, 23);
            this.AForm.TabIndex = 1;
            this.AForm.Text = "Attendance";
            this.AForm.UseVisualStyleBackColor = true;
            this.AForm.Click += new System.EventHandler(this.AForm_Click);
            // 
            // ESelect
            // 
            this.ESelect.FormattingEnabled = true;
            this.ESelect.Items.AddRange(new object[] {
            "Test"});
            this.ESelect.Location = new System.Drawing.Point(3, 16);
            this.ESelect.Name = "ESelect";
            this.ESelect.Size = new System.Drawing.Size(147, 21);
            this.ESelect.TabIndex = 0;
            this.ESelect.SelectedIndexChanged += new System.EventHandler(this.ESelect_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SButton);
            this.groupBox4.Controls.Add(this.DButton);
            this.groupBox4.Controls.Add(this.EButton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 44);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action";
            // 
            // SButton
            // 
            this.SButton.Location = new System.Drawing.Point(156, 14);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(69, 23);
            this.SButton.TabIndex = 2;
            this.SButton.Text = "Save";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.SButton_Click);
            // 
            // DButton
            // 
            this.DButton.Location = new System.Drawing.Point(81, 14);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(69, 23);
            this.DButton.TabIndex = 1;
            this.DButton.Text = "Delete";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.DButton_Click);
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(6, 14);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(69, 23);
            this.EButton.TabIndex = 0;
            this.EButton.Text = "Edit";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 223);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.CheckBox PCheck;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox DText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox TShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ESelect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.CheckBox DCheck;
        private System.Windows.Forms.Button AForm;
    }
}

