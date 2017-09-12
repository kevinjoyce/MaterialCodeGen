using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        private void txtBakSubCat_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtBakCode();
        }

        private void txtBakSize_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtBakCode();
        }

        private void txtBakSerialNum_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtBakCode();
        }
        private void FillNumToTxtBakCode()
        {
            this.txtBakCode.Text = "";
            this.txtBakCode.Text = "8." + this.txtBakSubCat.Text + "."
                + this.txtBakSize.Text +"."
                 + this.txtBakSerialNum.Text;
        }
    }
}
