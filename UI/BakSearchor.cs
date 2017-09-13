using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    class BakSearchor
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
                this.searchSubCategory(codes[1]);
                this.searchSize(codes[2]);
                this.searchFlowNo(codes[3]);
            }
        }

        private void showTopCategory()
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel0("大类：备用 ");
        }

        private bool isLegal(string[] codes)
        {
            bool islegal = true;
            if (codes.Length != 4)
                islegal = false;
            return islegal;
        }

        private void searchSubCategory(string codeFirst)
        {
             Form1 frmMain = Application.OpenForms["Form1"] as Form1;
             frmMain.setSearchLabel1("子类:" + codeFirst);            
        }

        private void searchSize(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel2("规格/牌号/工艺:" + codeFirst);   
        }


        private void searchFlowNo(string codeFirst)
        {
            Form1 frmMain = Application.OpenForms["Form1"] as Form1;
            frmMain.setSearchLabel3("流水号:" + codeFirst);
        }
    }
}
