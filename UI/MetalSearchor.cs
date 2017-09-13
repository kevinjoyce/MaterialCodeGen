using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class MetalSearchor
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
                this.searchGB(codes[3]);
                this.searchSize(codes[4]);
                this.searchLength(codes[5]);
                this.searchStrength(codes[6]);
                this.searchMaterial(codes[7]);
            }
        }

        private void showTopCategory()
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel0("大类：五金标准件 ");
        }

        private bool isLegal(string[] codes)
        {
            bool islegal = true;
            if (codes.Length != 8)
                islegal = false;
            return islegal;
        }

        private void searchLevelFirst(string codeFirst)
        {
            string strWhere = "level1_id = 5 and id2 = " + codeFirst;
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
            string strWhere = "level1_id = 5 and level2_id = " + codeFirst + " and id3 = " + codeSecond;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);
            if (1 == list.Count)
            {
                Form1 frmMain = Application.OpenForms["Form1"] as Form1;
                frmMain.setSearchLabel2("二级子类:" + list[0].name);
            }
        }



        private void searchGB(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel4("国际编号:" + codeFirst);
        }
        private void searchSize(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel5("螺纹规格:" + codeFirst);
        }
        private void searchLength(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel6("长度:" + codeFirst);
        }
        private void searchStrength(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel7("抗拉强度:" + codeFirst);
        }
        private void searchMaterial(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel8("材料:" + codeFirst);
        }
    }
}
