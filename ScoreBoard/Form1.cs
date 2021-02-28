using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreBoard
{
    public partial class frmScoreboard : Form
    {
        public frmScoreboard()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = Color.Red;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = Color.Red;
            pnlBottomLeft.BackColor = Color.Red;
            pnlMiddle.BackColor = SystemColors.ControlDark;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = SystemColors.ControlDark;
            pnlTop.BackColor = SystemColors.ControlDark;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = SystemColors.ControlDark;
            pnlBottomLeft.BackColor = SystemColors.ControlDark;
            pnlMiddle.BackColor = SystemColors.ControlDark;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = SystemColors.ControlDark;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = SystemColors.ControlDark;
            pnlBottom.BackColor = Color.Red;
            pnlBottomLeft.BackColor = Color.Red;
            pnlMiddle.BackColor = Color.Red;


        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = SystemColors.ControlDark;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = Color.Red;
            pnlBottomLeft.BackColor = SystemColors.ControlDark;
            pnlMiddle.BackColor = Color.Red;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = Color.Red;
            pnlTop.BackColor = SystemColors.ControlDark;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = SystemColors.ControlDark;
            pnlBottomLeft.BackColor = SystemColors.ControlDark;
            pnlMiddle.BackColor = Color.Red;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = Color.Red;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = SystemColors.ControlDark;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = Color.Red;
            pnlBottomLeft.BackColor = SystemColors.ControlDark;
            pnlMiddle.BackColor = Color.Red;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = Color.Red;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = SystemColors.ControlDark;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = Color.Red;
            pnlBottomLeft.BackColor = Color.Red;
            pnlMiddle.BackColor = Color.Red;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = SystemColors.ControlDark;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = SystemColors.ControlDark;
            pnlBottomLeft.BackColor = SystemColors.ControlDark;
            pnlMiddle.BackColor = SystemColors.ControlDark;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = Color.Red;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = Color.Red;
            pnlBottomLeft.BackColor = Color.Red;
            pnlMiddle.BackColor = Color.Red;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            pnlTopLeft.BackColor = Color.Red;
            pnlTop.BackColor = Color.Red;
            pnlTopRight.BackColor = Color.Red;
            pnlBottomRight.BackColor = Color.Red;
            pnlBottom.BackColor = Color.Red;
            pnlBottomLeft.BackColor = SystemColors.ControlDark;
            pnlMiddle.BackColor = Color.Red;
        }
    }
}
