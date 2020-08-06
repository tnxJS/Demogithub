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
    public partial class Modaless : Form
    {
        private string strModaless;
        public Modaless()
        {
            InitializeComponent();
        }

        public string Getstr()
        {
            return strModaless;
        }

        public void Setstr(string _str)
        {
            strModaless = _str;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (strModaless.Contains(tbSearch.Text))
            {
                MessageBox.Show("찾았습니다.", "O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("못찾았습니다.", "X", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
