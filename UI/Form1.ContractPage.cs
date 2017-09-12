using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        private void txtContractNo_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtContractCode();
        }
        private void rdoContractJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractJ.Checked == true)
            {
                strArrayContract[0] = rdoContractJ.Text;
            }

            FillNumToTxtContractCode();
        }
        private void rdoContractQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractQ.Checked == true)
            {
                strArrayContract[0] = rdoContractQ.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractNJQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractNJQ.Checked == true)
            {
                strArrayContract[0] = rdoContractNJQ.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractC.Checked == true)
            {
                strArrayContract[1] = rdoContractC.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractNC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractNC.Checked == true)
            {
                strArrayContract[1] = rdoContractNC.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractZ.Checked == true)
            {
                strArrayContract[2] = rdoContractZ.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractNZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractNZ.Checked == true)
            {
                strArrayContract[2] = rdoContractNZ.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractP.Checked == true)
            {
                strArrayContract[3] = rdoContractP.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractD.Checked == true)
            {
                strArrayContract[3] = rdoContractD.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractNPD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractNPD.Checked == true)
            {
                strArrayContract[3] = rdoContractNPD.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractH.Checked == true)
            {
                strArrayContract[4] = rdoContractH.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractNH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractNH.Checked == true)
            {
                strArrayContract[4] = rdoContractNH.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractM.Checked == true)
            {
                strArrayContract[5] = rdoContractM.Text;
            }

            FillNumToTxtContractCode();
        }

        private void rdoContractNM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoContractNM.Checked == true)
            {
                strArrayContract[5] = rdoContractNM.Text;
            }

            FillNumToTxtContractCode();
        }

        

        private void txtContractSerialNum_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtContractCode();
        }

        private void FillNumToTxtContractCode()
        {
            this.txtContractCode.Text = "";
            this.txtContractCode.Text = "7." + this.txtContractNo.Text + "."
                + string.Join("", strArrayContract) + "."
                + this.txtContractSerialNum.Text;
        }

        
    }
}
