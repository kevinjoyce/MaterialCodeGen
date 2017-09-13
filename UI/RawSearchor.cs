using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    class RawSearchor
    {
        public void search(string[] codes) 
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.initLabelSearch();

            if (!isLegal(codes))
            {
                MessageBox.Show("编码不符合要求，请核实。");
                return;
            }
            else 
            {
                this.showTopCategory();
                this.searchLevelFirst(codes[1]);
                this.searchLevelSecond(codes[1], codes[2]);
                this.searchLevelThird(codes[1], codes[2], codes[3]);
                this.searchRawLabel(codes[4]);
                this.searchThick(codes[5]);
                this.searchSize(codes[6]);
            }
        }

        private void showTopCategory()
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel0("大类：原材料 ");
        }

        private bool isLegal(string[] codes){
            bool islegal = true;
            if(codes.Length != 7) 
                islegal = false;
            return islegal;
        }

        private void searchLevelFirst(string codeFirst) 
        {
            string strWhere = "level1_id = 1 and id2 = " + codeFirst;
            Material.BLL.level2 lev2 = new Material.BLL.level2();
            List<Material.Model.level2> list = lev2.GetModelList(strWhere);
            if (list.Count == 1)
            {
                Form1 frmMain = Application.OpenForms["Form1"] as Form1;
                frmMain.setSearchLabel1("一级子类:" + list[0].name);
            }
        }

        private void searchLevelSecond(string codeFirst, string codeSecond)
        {
            string strWhere = "level1_id = 1 and level2_id = " + codeFirst + " and id3 = "+ codeSecond;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);
            if (1 == list.Count)
            {
                Form1 frmMain = Application.OpenForms["Form1"] as Form1;
                frmMain.setSearchLabel2("二级子类:" + list[0].name);
            }
        }

        private void searchLevelThird(string codeFirst, string codeSecond, string codeThird)
        {
            string strWhere = "level2_id = 1 and level3_id = " 
                + codeFirst + " and name = " 
                + codeSecond + " and id4 = "
                + codeThird;
            Material.BLL.level4 lev4 = new Material.BLL.level4();
            List<Material.Model.level4> list = lev4.GetModelList(strWhere);
            if (1 == list.Count)
            {
                Form1 frmMain = Application.OpenForms["Form1"] as Form1;
                frmMain.setSearchLabel3("三级子类:" + list[0].name2);
            }
        }

        private void searchRawLabel(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel4("原材料牌号:" + codeFirst);
        }
        private void searchThick(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel5("厚度:" + codeFirst);
        }
        private void searchSize(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel6("尺寸:" + codeFirst);
        }
    }
}
