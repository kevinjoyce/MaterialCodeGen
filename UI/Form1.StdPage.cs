using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        private void cmbStdFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbStdFirst.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level1_id = 2 and level2_id = " + this.cmbStdFirst.SelectedValue;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);

            cmbStdSecond.DataSource = list;
            cmbStdSecond.DisplayMember = "name";
            cmbStdSecond.ValueMember = "id3";
            cmbStdSecond.Text = "";

            this.txtStdCode.Text = "";
            this.txtStdCode.Text = "2." + this.cmbStdFirst.SelectedValue + "."
                + string.Join("", strArrayStd) + "."
                + this.txtStdSerialNum.Text;
        }

        private void cmbStdSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtStdCode.Text = "";
            this.txtStdCode.Text = "2." + this.cmbStdFirst.SelectedValue + "."
                + this.cmbStdSecond.SelectedValue + "."
                + string.Join("", strArrayStd) + "."
                + this.txtStdSerialNum.Text;
        }

        private void rdoJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ.Checked == true)
            {
                strArrayStd[0] = rdoJ.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoQ.Checked == true)
            {
                strArrayStd[0] = rdoQ.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoNJQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNJQ.Checked == true)
            {
                strArrayStd[0] = rdoNJQ.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoC.Checked == true)
            {
                strArrayStd[1] = rdoC.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoNC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNC.Checked == true)
            {
                strArrayStd[1] = rdoNC.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoZ.Checked == true)
            {
                strArrayStd[2] = rdoZ.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoNZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNZ.Checked == true)
            {
                strArrayStd[2] = rdoNZ.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoP.Checked == true)
            {
                strArrayStd[3] = rdoP.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoD.Checked == true)
            {
                strArrayStd[3] = rdoD.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoNPD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNPD.Checked == true)
            {
                strArrayStd[3] = rdoNPD.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoH.Checked == true)
            {
                strArrayStd[4] = rdoH.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoNH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNH.Checked == true)
            {
                strArrayStd[4] = rdoNH.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoM.Checked == true)
            {
                strArrayStd[5] = rdoM.Text;
            }

            FillNumToTxtStdCode();
        }

        private void rdoNM_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNM.Checked == true)
            {
                strArrayStd[5] = rdoNM.Text;
            }

            FillNumToTxtStdCode();
        }

        private void txtStdSerialNum_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtStdCode();
        }

        private void FillNumToTxtStdCode()
        {
            this.txtStdCode.Text = "";
            this.txtStdCode.Text = "2." + this.cmbStdFirst.SelectedValue + "."
                + this.cmbStdSecond.SelectedValue + "."
                + string.Join("", strArrayStd) + "."
                + this.txtStdSerialNum.Text;
        }
    }
}
