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

       

        

        
        

        
        

       

        
        
        
    }
}
