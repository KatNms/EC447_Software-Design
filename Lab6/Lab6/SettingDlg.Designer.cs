using System;

namespace Lab6
{
    partial class SettingDlg
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
            this.outline = new System.Windows.Forms.CheckBox();
            this.fill = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PenWidth = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FillColor = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PenColor = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pen Width";
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
            this.PenWidth.Location = new System.Drawing.Point(336, 147);
            this.PenWidth.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.PenWidth.Name = "PenWidth";
            this.PenWidth.Size = new System.Drawing.Size(120, 314);
            this.PenWidth.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fill Color";
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
            this.FillColor.Location = new System.Drawing.Point(189, 147);
            this.FillColor.Margin = new System.Windows.Forms.Padding(8, 17, 8, 17);
            this.FillColor.Name = "FillColor";
            this.FillColor.Size = new System.Drawing.Size(107, 159);
            this.FillColor.TabIndex = 11;
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
            this.PenColor.Size = new System.Drawing.Size(91, 159);
            this.PenColor.TabIndex = 9;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(189, 548);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(107, 55);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(370, 548);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 55);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // SettingDlg
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 1214);
            this.ControlBox = false;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingDlg";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox PenColor;
        public System.Windows.Forms.ListBox FillColor;
        public System.Windows.Forms.ListBox PenWidth;
        public System.Windows.Forms.CheckBox outline;
        public System.Windows.Forms.CheckBox fill;
        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.Button CancelButton;
    }
}