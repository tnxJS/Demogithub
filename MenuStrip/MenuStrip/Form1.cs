using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTest.Text = "Mind Gap between train and platform";
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            lblTest.Text = "새 파일 누름";
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            lblTest.Text = "파일 열기";
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            lblTest.Text = "파일 저장";
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("종료하시겠습니까?", "프로그램 종료", //messagebox message, messagebox caption
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;
            else if (result == DialogResult.Yes) //else
                Application.Exit();
        }
        private void ToolStripExit_BackColorChanged(object sender, EventArgs e)
        {
            var inint = 501;//"what the hell";
            int nn = inint;
        }

        private void ToolStripCopy_Click(object sender, EventArgs e)
        {
            lblTest.Text = "복사♡";
        }

        private void ToolStripPaste_Click(object sender, EventArgs e)
        {
            lblTest.Text = "붙여넣기♡";
        }

        private void ToolStripCut_Click(object sender, EventArgs e)
        {
            lblTest.Text = "잘라내기♡";
        }

        private void btnModal_Click(object sender, EventArgs e)
        {//모달
            Modal modal = new Modal();
            modal.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {//모달리스
            Modaless modaless = new Modaless();
            modaless.Setstr(tbPaste.Text);
            modaless.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                tbFour.Text = ofd.FileName + "파일 열기";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfd.Filter = "All file(*.*)|(*.*)";
            if (sfd.ShowDialog() == DialogResult.OK)
                tbFour.Text = sfd.FileName + "파일 저장";
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.OK)
                tbFour.Font = fd.Font;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
                tbFour.BackColor = cd.Color; //ForeColor = 글꼴색 BackColor = 배경색
        }
    }
}
