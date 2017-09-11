using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        //第一级
        private void cmbMetalFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbMetalFirst.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level1_id = 5 and level2_id = " + this.cmbMetalFirst.SelectedValue;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);

            cmbMetalSecond.DataSource = list;
            cmbMetalSecond.DisplayMember = "name";
            cmbMetalSecond.ValueMember = "id3";
            cmbMetalSecond.Text = "";

            this.txtMetalCode.Text = "";
            this.txtMetalCode.Text = "5." + this.txtMetalCode.Text + this.cmbMetalFirst.SelectedValue + "."
                + this.txtMetalGBCode.Text + "."
                + this.txtMentalLwsize.Text + "."
                + this.txtMentalLength.Text + "."
                + this.txtMentalStrength.Text + "."
                + this.txtMentalMaterial.Text;
        }

        //第二级
        private void cmbMetalSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumToTxtMetalCode();
        }

        private void txtMetalGBCode_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtMetalCode();
        }

        private void txtMentalLwsize_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtMetalCode();
        }

        private void txtMentalLength_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtMetalCode();
        }

        private void txtMentalStrength_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtMetalCode();
        }

        private void txtMentalMaterial_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtMetalCode();
        }

        private void FillNumToTxtMetalCode()
        {
            this.txtMetalCode.Text = "";
            this.txtMetalCode.Text = "5." + this.txtMetalCode.Text + this.cmbMetalFirst.SelectedValue + "."
                + this.cmbMetalSecond.SelectedValue + "."
                + this.txtMetalGBCode.Text + "."
                + this.txtMentalLwsize.Text + "."
                + this.txtMentalLength.Text + "."
                + this.txtMentalStrength.Text + "."
                + this.txtMentalMaterial.Text;
        }
    }
}
