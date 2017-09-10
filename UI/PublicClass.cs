using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UI
{
    class PublicClass
    {
        /*List<DictionaryEntry> getKeyValueFromList()
        { 
        }*/
        List<DictionaryEntry> listDE = new List<DictionaryEntry>();

        private void Process(/*Control.ControlCollection c*/)
        {
            //This funciton is used to clear all the contents in textbox
            /*
            foreach (Control c1 in this.tabRawMaterial.Controls)
            {
                if (c1.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                {
                    ((TextBox)c1).Clear();
                }
                if (c1 != null)
                {
                    Process(c1.Controls);
                }
                else
                {
                    return;
                }
            }*/
            /*
            if (c.Count > 0)
            {
                foreach (Control c1 in c)
                {
                    if (c1.GetType().ToString().Equals("System.Windows.Forms.TextBox"))
                    {
                        ((TextBox)c1).Clear();
                    }
                    if (c1 != null)
                    {
                        Process(c1.Controls);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                return;
            }*/
        }
    }
}
