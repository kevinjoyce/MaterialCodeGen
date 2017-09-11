using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        private void cmbEquipFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbEquipFirst.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level1_id = 6 and level2_id = " + this.cmbEquipFirst.SelectedValue;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);

            cmbEquipSecond.DataSource = list;
            cmbEquipSecond.DisplayMember = "name";
            cmbEquipSecond.ValueMember = "id3";
            cmbEquipSecond.Text = "";

            this.txtEquipCode.Text = "";
            this.txtEquipCode.Text = "6." + this.txtEquipCode.Text + this.cmbEquipFirst.SelectedValue + "."
                 + this.txtEquipSerialNum.Text;
        }

        private void cmbEquipSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumToTxtEquipode();
        }

        private void txtEquipSerialNum_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtEquipode();
        }

        private void FillNumToTxtEquipode()
        {
            this.txtEquipCode.Text = "";
            this.txtEquipCode.Text = "6." + this.txtEquipCode.Text + this.cmbEquipFirst.SelectedValue + "."
                 + this.cmbEquipSecond.SelectedValue + "."
                 + this.txtEquipSerialNum.Text;
        }
    }
}
