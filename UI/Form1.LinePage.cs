using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        //一级
        private void cmbLineFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLineFirst.SelectedValue.ToString().Length > 5) return;

            string strWhere = "level1_id = 4 and level2_id = " + this.cmbLineFirst.SelectedValue;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);

            cmbLineSecond.DataSource = list;
            cmbLineSecond.DisplayMember = "name";
            cmbLineSecond.ValueMember = "id3";
            cmbLineSecond.Text = "";

            this.txtLineCode.Text = "";
            this.txtLineCode.Text = "4." + this.txtLineCode.Text + this.cmbLineFirst.SelectedValue + "."
                + this.cmbLineColorAndIO.Text + "."
                + this.cmbLineComIO.Text + "."
                + this.txtLineSquDivLen.Text + "."
                + this.txtLineSerialNum.Text + "."
                + this.txtLineCode.Text;
        }

        //二级
        private void cmbLineSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNumToTxtLineCode();
        }

        //颜色，进出口
        private void cmbLineColorAndIO_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtLineCode();
        }

        //通讯线出口接口
        private void cmbLineComIO_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtLineCode();
        }
        //平方数/长度
        private void txtLineSquDivLen_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtLineCode();
        }

        //流水号
        private void txtLineSerialNum_TextChanged(object sender, EventArgs e)
        {
            FillNumToTxtLineCode();
        }
        private void FillNumToTxtLineCode()
        {
            this.txtLineCode.Text = "";
            this.txtLineCode.Text = "4." + this.txtLineCode.Text + this.cmbLineFirst.SelectedValue + "."
                + this.cmbLineSecond.SelectedValue + "."
                + this.cmbLineColorAndIO.Text + "."
                + this.cmbLineComIO.Text + "."
                + this.txtLineSquDivLen.Text + "."
                + this.txtLineSerialNum.Text;
        }
        
    }
}
