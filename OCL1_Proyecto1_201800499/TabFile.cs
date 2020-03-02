using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCL1_Proyecto1_201800499
{
    class TabFile : System.Windows.Forms.TabPage
    {
        public System.Windows.Forms.RichTextBox fileOPen;
        public TabFile(String name)
        {
            this.Text = name;
            fileOPen = new System.Windows.Forms.RichTextBox();
            this.Controls.Add(fileOPen);
            fileOPen.Dock = System.Windows.Forms.DockStyle.Fill;
        }

    }
}
