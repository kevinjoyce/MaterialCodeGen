using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class LineSearchor
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
                this.searchColor(codes[3]);
                this.searchComm(codes[4]);
                this.searchSqDivLen(codes[5]);
                this.searchFlowNo(codes[6]);
            }
        }

        private void showTopCategory()
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel0("大类：线缆 ");
        }

        private bool isLegal(string[] codes)
        {
            bool islegal = true;
            if (codes.Length != 7)
                islegal = false;
            return islegal;
        }

        private void searchLevelFirst(string codeFirst)
        {
            string strWhere = "level1_id = 4 and id2 = " + codeFirst;
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
            string strWhere = "level1_id = 4 and level2_id = " + codeFirst + " and id3 = " + codeSecond;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);
            if (1 == list.Count)
            {
                Form1 frmMain = Application.OpenForms["Form1"] as Form1;
                frmMain.setSearchLabel2("二级子类:" + list[0].name);
            }
        }

        

        private void searchColor(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel4("颜色或进口出口:" + codeFirst);
        }
        private void searchComm(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel5("通讯线出口接口:" + codeFirst);
        }
        private void searchSqDivLen(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel6("平方数除长度:" + codeFirst);
        }
        private void searchFlowNo(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel7("流水号:" + codeFirst);
        }
    }
}
