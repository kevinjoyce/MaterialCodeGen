using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        private void tabElectricComponent_Click(object sender, EventArgs e)
        {

        }

        private void cmbElecFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbElecFirst.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level1_id = 3 and level2_id = " + this.cmbElecFirst.SelectedValue;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);

            cmbElecSecond.DataSource = list;
            cmbElecSecond.DisplayMember = "name";
            cmbElecSecond.ValueMember = "id3";
            cmbElecSecond.Text = "";

            this.txtElecCode.Text = "";
            this.txtElecCode.Text = "3." + this.txtElecCode.Text + this.cmbElecFirst.SelectedValue + "."
                + this.txtElecU.Text + "."
                + this.txtElecI.Text + "."
                + this.txtElecSerialNum.Text + "."
                + this.txtElecCode.Text;
        }

        private void cmbElecSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtElecCode.Text = "";
            this.txtElecCode.Text = "3." + this.txtElecCode.Text + this.cmbElecFirst.SelectedValue + "."
                + this.cmbElecSecond.SelectedValue + "."
                + this.txtElecU.Text + "."
                + this.txtElecI.Text + "."
                + this.txtElecSerialNum.Text + "."
                + this.txtElecCode.Text;
        }

        private void txtElecU_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtElecCode();
        }

        private void FillNumToTxtElecCode()
        {
            this.txtElecCode.Text = "";
            this.txtElecCode.Text = "2." + this.cmbElecFirst.SelectedValue + "."
                + this.cmbElecSecond.SelectedValue + "."
                 + this.txtElecU.Text + "."
                + this.txtElecI.Text + "."
                + this.txtElecSerialNum.Text + "."
                + this.txtElecCode.Text;
        }

        private void txtElecI_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtElecCode();
        }

        private void txtElecSerialNum_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtElecCode();
        }
    }
}
