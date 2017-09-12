using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        private void cmbProductionFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbProductionFirst.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level1_id = 5 and level2_id = " + this.cmbProductionFirst.SelectedValue;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);

            cmbProductionSecond.DataSource = list;
            cmbProductionSecond.DisplayMember = "name";
            cmbProductionSecond.ValueMember = "id3";
            cmbProductionSecond.Text = "";

            this.txtProductionCode.Text = "";
            this.txtProductionCode.Text = "9." + this.txtProductionCode.Text + this.cmbProductionFirst.SelectedValue + "."
                + this.txtProductionSerialNum.Text;
        }

        private void cmbProductionSecond_SelectedIndexChanged(object sender, EventArgs e)
        {

            FillNumToTxtProductionCode();
        }

        private void FillNumToTxtProductionCode()
        {
            this.txtProductionCode.Text = "";
            this.txtProductionCode.Text = "9." + this.txtProductionCode.Text + this.cmbProductionFirst.SelectedValue + "."
                + this.cmbProductionSecond.SelectedValue + "."
                + this.txtProductionSerialNum.Text;
        }

        private void txtProductionSerialNum_TextChanged(object sender, EventArgs e)
        {
            this.txtProductionCode.Text = "";
            this.txtProductionCode.Text = "9." + this.txtProductionCode.Text + this.cmbProductionFirst.SelectedValue + "."
                + this.cmbProductionSecond.SelectedValue + "."
                + this.txtProductionSerialNum.Text;
        }
    }
}
