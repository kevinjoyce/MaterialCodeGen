using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class StdSearchor
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
                this.searchConstructWorkFlow(codes[3]);
                this.searchFlowNo(codes[4]);                
            }
        }

        private void showTopCategory()
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel0("大类：自制标准件 ");
        }

        private bool isLegal(string[] codes)
        {
            bool islegal = true;
            if (codes.Length != 5)
                islegal = false;
            return islegal;
        }

        private void searchLevelFirst(string codeFirst)
        {
            string strWhere = "level1_id = 2 and id2 = " + codeFirst;
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
            string strWhere = "level1_id = 2 and level2_id = " + codeFirst + " and id3 = " + codeSecond;
            Material.BLL.level3 lev3 = new Material.BLL.level3();
            List<Material.Model.level3> list = lev3.GetModelList(strWhere);
            if (1 == list.Count)
            {
                Form1 frmMain = Application.OpenForms["Form1"] as Form1;
                frmMain.setSearchLabel2("二级子类:" + list[0].name);
            }
        }

        private void searchConstructWorkFlow(string code)
        {
            if (code.Length != 6)
            {
                MessageBox.Show("工艺流程部分的编码非法，应有6位，请核实。");
                return;
            }

            this.searchJQ(code.Substring(0,1));
            this.searchC(code.Substring(1,1));
            this.searchZ(code.Substring(2,1));
            this.searchPD(code.Substring(3,1));
            this.searchH(code.Substring(4,1));
            this.searchM(code.Substring(5,1));

        }

        private void searchJQ(string code)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            switch (code)
            {
                case "J":
                    frmMain.setSearchLabel3("剪板");
                    break;
                case "Q":
                    frmMain.setSearchLabel3("切锯");
                    break;
                case "0":
                    frmMain.setSearchLabel3("不切不锯");
                    break;
            }
        }

        private void searchC(string code)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            switch (code)
            {
                case "C":
                    frmMain.setSearchLabel4("冲压");
                    break;
                case "0":
                    frmMain.setSearchLabel4("不冲");
                    break;
            }
        }

        private void searchZ(string code)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            switch (code)
            {
                case "Z":
                    frmMain.setSearchLabel5("折弯");
                    break;
                case "0":
                    frmMain.setSearchLabel5("不折");
                    break;
            }
        }

        private void searchPD(string code)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            switch (code)
            {
                case "P":
                    frmMain.setSearchLabel6("喷涂");
                    break;
                case "D":
                    frmMain.setSearchLabel6("电镀");
                    break;
                case "0":
                    frmMain.setSearchLabel6("不喷不镀");
                    break;
            }
        }

        private void searchH(string code)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            switch (code)
            {
                case "H":
                    frmMain.setSearchLabel7("焊接");
                    break;
                case "0":
                    frmMain.setSearchLabel7("不焊接");
                    break;
            }
        }

        private void searchM(string code)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            switch (code)
            {
                case "M":
                    frmMain.setSearchLabel8("铆接");
                    break;
                case "0":
                    frmMain.setSearchLabel8("不铆接");
                    break;
            }
        }

        private void searchFlowNo(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel9("流水号:" + codeFirst);
        }

        
        
    }
}
