using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    partial class Form1
    {
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] codes = this.txtSearchCode.Text.Split('.');

            switch (codes[0])
            {
                case "1":
                    RawSearchor rs = new RawSearchor();
                    rs.search(codes);
                    break;
                case "2":
                    StdSearchor ss = new StdSearchor();
                    ss.search(codes);
                    break;
                case "3":
                    ElecSearchor es = new ElecSearchor();
                    es.search(codes);
                    break;
                case "4":
                    LineSearchor ls = new LineSearchor();
                    ls.search(codes);
                    break;
                case "5":
                    MetalSearchor ms = new MetalSearchor();
                    ms.search(codes);
                    break;
                case "6":
                    EquipmentSearchor eqs = new EquipmentSearchor();
                    eqs.search(codes);
                    break;
                case "7":
                    ContractSearchor cs = new ContractSearchor();
                    cs.search(codes);
                    break;
                case "8":
                    BakSearchor bs = new BakSearchor();
                    bs.search(codes);
                    break;
                case "9":
                    ProductionSearchor ps = new ProductionSearchor();
                    ps.search(codes);
                    break;
            }

            //RawSearchor rs = new RawSearchor();
            //rs.search(codes);
            /*
             * string[] codes = cs.splitCode();
             * switch(codes[0])
             * case 0:
             *     RawSearchor rs = new RawSearchor();
             *     rs.search(codes);
             * case 1:
             *     StdSearchor ss = new StdSearchor();
             *     rs.search(codes);
             *     ...
             * case 9:
             *     ProductionSearchor ps = new ProductionSearchor();
             *     ps.search(codes);
             * */
        }
    }
}
