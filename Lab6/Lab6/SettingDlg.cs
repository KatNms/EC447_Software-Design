using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class SettingDlg : Form
    {
        private int fillc;
        private int pen;
        private int width;
        private bool outlineck;
        private bool fillck;

        public SettingDlg()
        {
            InitializeComponent();
            this.FillColor.SelectedIndex = 0;
            this.PenColor.SelectedIndex = 0;
            this.PenWidth.SelectedIndex = 0;
            this.outline.Checked = true;
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.FillColor.SelectedIndex = this.fillc;
            this.PenColor.SelectedIndex = this.pen;
            this.PenWidth.SelectedIndex = this.width;
            this.outline.Checked = this.outlineck;
            this.fill.Checked = this.fillck;
            base.DialogResult = DialogResult.Cancel;
        }

        protected override void OnShown(EventArgs e)
        {
            this.fillc = this.FillColor.SelectedIndex;
            this.pen = this.PenColor.SelectedIndex;
            this.width = this.PenWidth.SelectedIndex;
            this.outlineck = this.outline.Checked;
            this.fillck = this.fill.Checked;
        }

    }
}
