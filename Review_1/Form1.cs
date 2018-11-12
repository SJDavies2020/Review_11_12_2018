using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_1
{
    public partial class frmReview : Form
    {
    Double MyResult = 0;
        public frmReview()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            MyResult = (Convert.ToDouble(txtVal1.Text) + Convert.ToDouble(txtVal2.Text)) / 2;
            lblResult.Text = Convert.ToString(MyResult);

        }
    }
}
