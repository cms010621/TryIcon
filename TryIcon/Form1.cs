using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.ntiTray.Visible = !visible;
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false); //버튼을 누르면 사라져야한다.

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //닫기버튼 눌러도 종료되지 않음.
            VisibleChange(false);
        }

        private void NtiTray_DoubleClick(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ntiTray.Visible = false;
            Application.ExitThread(); //프로그램 완전종료
        }
    }
}
