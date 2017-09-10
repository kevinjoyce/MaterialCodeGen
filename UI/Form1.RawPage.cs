using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    partial class Form1
    {
        private void cmbRawFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRawFirst.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level1_id = 1 and level2_id = " + this.cmbRawFirst.SelectedValue;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);

            cmbRawSecond.DataSource = list;
            cmbRawSecond.DisplayMember = "name";
            cmbRawSecond.ValueMember = "id3";
            cmbRawSecond.Text = "";

            this.txtCode.Text = "";
            this.txtCode.Text = "1." + this.txtCode.Text + this.cmbRawFirst.SelectedValue + "."
                + this.txtRawLabel.Text + "."
                + this.txtThick.Text + "."
                + this.txtSize.Text;
        }

        private void cmbRawSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRawSecond.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level2_id = 1 and level3_id = " + this.cmbRawFirst.SelectedValue
                                + " and name = " + this.cmbRawSecond.SelectedValue;
            Material.BLL.level4 lev4 = new Material.BLL.level4();
            List<Material.Model.level4> list = lev4.GetModelList(strWhere);

            cmbRawThird.DataSource = list;
            cmbRawThird.DisplayMember = "name2";
            cmbRawThird.ValueMember = "id4";
            cmbRawThird.Text = "";

            this.txtCode.Text = "";
            this.txtCode.Text = "1." + this.txtCode.Text + this.cmbRawFirst.SelectedValue + "."
                + this.cmbRawSecond.SelectedValue + "."
                + this.txtRawLabel.Text + "."
                + this.txtThick.Text + "."
                + this.txtSize.Text;
        }


        private void cmbRawThird_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumToTxtCode();
        }

        private void txtRawLabel_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtCode();
        }

        private void txtThick_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtCode();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtCode();
        }

        private void FillNumToTxtCode()
        {
            this.txtCode.Text = "";
            this.txtCode.Text = "1." + this.txtCode.Text + this.cmbRawFirst.SelectedValue + "."
                + this.cmbRawSecond.SelectedValue + "."
                + this.cmbRawThird.SelectedValue + "."
                + this.txtRawLabel.Text + "."
                + this.txtThick.Text + "."
                + this.txtSize.Text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            /***
             * 此处应该增加针对编码正确性的判断功能
             * **/
            Clipboard.SetDataObject(txtCode.Text);
            MessageBox.Show("编码复制成功");
        }
    }
}
