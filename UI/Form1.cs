using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        string[] strArrayStd = new string[6];
        string[] strArrayContract = new string[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToCmbRawFirst();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tbControlMaterial.SelectedIndex)
            {
                case 0:
                    //MessageBox.Show("tabPage1 is Selected");
                    LoadDataToCmbRawFirst();
                    break;
                case 1:
                    //MessageBox.Show("tabPage2 is Selected");
                    LoadDataTocmbStdFirst();
                    break;
                case 2:
                    //MessageBox.Show("tabPage3 is Selected");
                    LoadDataTocmbElecFirst();
                    break;
                case 3:
                    //MessageBox.Show("tabPage4 is Selected");
                    LoadDataTocmbLineFirst();
                    break;
                case 4:
                    //MessageBox.Show("tabPage5 is Selected");
                    LoadDataTocmbMetalFirst();
                    break;
                case 5:
                    //MessageBox.Show("tabPage5 is Selected");
                    LoadDataTocmbEquipFirst();
                    break;
                case 8:
                    LoadDataTocmbProductionFirst();
                    break;
            }
        }

        
        

        private void LoadDataToCmbRawFirst()
        {
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList("level1_id = 1");

            cmbRawFirst.DataSource = list;
            cmbRawFirst.DisplayMember = "name";
            cmbRawFirst.ValueMember = "id2";
            cmbRawFirst.Text = "";
        }

        private void LoadDataTocmbStdFirst()
        {
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList("level1_id = 2");

            cmbStdFirst.DataSource = list;
            cmbStdFirst.DisplayMember = "name";
            cmbStdFirst.ValueMember = "id2";
            cmbStdFirst.Text = "";
        }
        //电器元件
        private void LoadDataTocmbElecFirst()
        {
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList("level1_id = 3");

            cmbElecFirst.DataSource = list;
            cmbElecFirst.DisplayMember = "name";
            cmbElecFirst.ValueMember = "id2";
            cmbElecFirst.Text = "";
        }

        //线缆
        private void LoadDataTocmbLineFirst()
        {
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList("level1_id = 4");

            cmbLineFirst.DataSource = list;
            cmbLineFirst.DisplayMember = "name";
            cmbLineFirst.ValueMember = "id2";
            cmbLineFirst.Text = "";
        }


        //五金
        private void LoadDataTocmbMetalFirst()
        {
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList("level1_id = 5");

            cmbMetalFirst.DataSource = list;
            cmbMetalFirst.DisplayMember = "name";
            cmbMetalFirst.ValueMember = "id2";
            cmbMetalFirst.Text = "";
        }

        private void LoadDataTocmbEquipFirst()
        {
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList("level1_id = 6");

            cmbEquipFirst.DataSource = list;
            cmbEquipFirst.DisplayMember = "name";
            cmbEquipFirst.ValueMember = "id2";
            cmbEquipFirst.Text = "";
        }

        private void LoadDataTocmbProductionFirst()
        {
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList("level1_id = 9");

            cmbProductionFirst.DataSource = list;
            cmbProductionFirst.DisplayMember = "name";
            cmbProductionFirst.ValueMember = "id2";
            cmbProductionFirst.Text = "";
        }

        public void setSearchLabel0(string label)
        {
            this.labelSearch0.Text = label;
            this.labelSearch0.Visible = true;
        }

        public void setSearchLabel1(string label) 
        {
            this.labelSearch1.Text = label;
            this.labelSearch1.Visible = true;
        }

        public void setSearchLabel2(string label)
        {
            this.labelSearch2.Text = label;
            this.labelSearch2.Visible = true;
        }

        public void setSearchLabel3(string label)
        {
            this.labelSearch3.Text = label;
            this.labelSearch3.Visible = true;
        }

        public void setSearchLabel4(string label)
        {
            this.labelSearch4.Text = label;
            this.labelSearch4.Visible = true;
        }

        public void setSearchLabel5(string label)
        {
            this.labelSearch5.Text = label;
            this.labelSearch5.Visible = true;
        }

        public void setSearchLabel6(string label)
        {
            this.labelSearch6.Text = label;
            this.labelSearch6.Visible = true;
        }

        public void setSearchLabel7(string label)
        {
            this.labelSearch7.Text = label;
            this.labelSearch7.Visible = true;
        }

        public void setSearchLabel8(string label)
        {
            this.labelSearch8.Text = label;
            this.labelSearch8.Visible = true;
        }

        public void setSearchLabel9(string label)
        {
            this.labelSearch9.Text = label;
            this.labelSearch9.Visible = true;
        }

        public void setSearchLabel10(string label)
        {
            this.labelSearch10.Text = label;
            this.labelSearch10.Visible = true;
        }

        public void initLabelSearch() 
        {
            this.labelSearch1.Text = "";
            this.labelSearch1.Visible = false;
            this.labelSearch2.Text = "";
            this.labelSearch2.Visible = false;
            this.labelSearch3.Text = "";
            this.labelSearch3.Visible = false;
            this.labelSearch4.Text = "";
            this.labelSearch4.Visible = false;
            this.labelSearch5.Text = "";
            this.labelSearch5.Visible = false;
            this.labelSearch6.Text = "";
            this.labelSearch6.Visible = false;
            this.labelSearch7.Text = "";
            this.labelSearch7.Visible = false;
            this.labelSearch8.Text = "";
            this.labelSearch8.Visible = false;
            this.labelSearch9.Text = "";
            this.labelSearch9.Visible = false;
            this.labelSearch10.Text = "";
            this.labelSearch10.Visible = false;
        }

        private void txtElecCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopyStandard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtStdCode.Text);
            MessageBox.Show("编码复制成功");
        }

        private void btnElecCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtElecCode.Text);
            MessageBox.Show("编码复制成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtLineCode.Text);
            MessageBox.Show("编码复制成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtMetalCode.Text);
            MessageBox.Show("编码复制成功");
        }

        private void btnEnquipment_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtEquipCode.Text);
            MessageBox.Show("编码复制成功");
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtContractCode.Text);
            MessageBox.Show("编码复制成功");
        }

        private void btnCopyBak_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtBakCode.Text);
            MessageBox.Show("编码复制成功");
        }

        private void btnCopyProduction_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.txtProductionCode.Text);
            MessageBox.Show("编码复制成功");
        }

       

        

        

        

        

        

        

       

        

       

        

       

        

        
        

        
        

       

        
        
        
    }
}
