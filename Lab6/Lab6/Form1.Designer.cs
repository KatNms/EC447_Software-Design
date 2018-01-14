namespace Lab6
{
    partial class Form1
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Settings = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.lineButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PenWidth = new System.Windows.Forms.ListBox();
            this.FillColor = new System.Windows.Forms.ListBox();
            this.PenColor = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.CheckBox();
            this.outline = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 12, 0, 12);
            this.menuStrip1.Size = new System.Drawing.Size(1338, 69);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(199, 46);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(199, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(80, 45);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(206, 46);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 334);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Settings);
            this.groupBox1.Controls.Add(this.ellipseButton);
            this.groupBox1.Controls.Add(this.rectangleButton);
            this.groupBox1.Controls.Add(this.lineButton);
            this.groupBox1.Location = new System.Drawing.Point(62, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.groupBox1.Size = new System.Drawing.Size(589, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw";
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(416, 141);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(173, 55);
            this.Settings.TabIndex = 9;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.AutoSize = true;
            this.ellipseButton.Location = new System.Drawing.Point(22, 169);
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(138, 36);
            this.ellipseButton.TabIndex = 2;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Location = new System.Drawing.Point(22, 112);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(181, 36);
            this.rectangleButton.TabIndex = 1;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            // 
            // lineButton
            // 
            this.lineButton.AutoSize = true;
            this.lineButton.Checked = true;
            this.lineButton.Location = new System.Drawing.Point(22, 55);
            this.lineButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(107, 36);
            this.lineButton.TabIndex = 0;
            this.lineButton.TabStop = true;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pen Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fill Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pen Color";
            // 
            // PenWidth
            // 
            this.PenWidth.FormattingEnabled = true;
            this.PenWidth.ItemHeight = 31;
            this.PenWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PenWidth.Location = new System.Drawing.Point(223, 153);
            this.PenWidth.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(120, 314);
            this.PenWidth.TabIndex = 13;
            // 
            // FillColor
            // 
            this.FillColor.FormattingEnabled = true;
            this.FillColor.ItemHeight = 31;
            this.FillColor.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.FillColor.Location = new System.Drawing.Point(124, 153);
            this.FillColor.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(66, 159);
            this.FillColor.TabIndex = 11;
            // 
            // PenColor
            // 
            this.PenColor.FormattingEnabled = true;
            this.PenColor.ItemHeight = 31;
            this.PenColor.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.PenColor.Location = new System.Drawing.Point(29, 153);
            this.PenColor.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.PenColor.Name = "PenColor";
            this.PenColor.Size = new System.Drawing.Size(66, 159);
            this.PenColor.TabIndex = 9;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(178, 548);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 55);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(283, 548);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 55);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // fill
            // 
            this.fill.AutoSize = true;
            this.fill.Location = new System.Drawing.Point(98, 439);
            this.fill.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(91, 36);
            this.fill.TabIndex = 15;
            this.fill.Text = "Fill";
            this.fill.UseVisualStyleBackColor = true;
            // 
            // outline
            // 
            this.outline.AutoSize = true;
            this.outline.Location = new System.Drawing.Point(98, 496);
            this.outline.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.outline.Name = "outline";
            this.outline.Size = new System.Drawing.Size(145, 36);
            this.outline.TabIndex = 16;
            this.outline.Text = "Outline";
            this.outline.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 811);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 1214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.outline);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PenWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FillColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PenColor);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lab6 by Katrina Nemes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox outline;
        private System.Windows.Forms.CheckBox fill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lineButton;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.RadioButton ellipseButton;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ListBox PenColor;
        private System.Windows.Forms.ListBox FillColor;
        private System.Windows.Forms.ListBox PenWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
