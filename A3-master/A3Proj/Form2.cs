using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A3Proj
{
    public partial class Form2 : A3Proj.Form1
    {
        public class MyThing : System.Windows.Forms.Panel {
            public MyThing() {
                this.myPanel = new System.Windows.Forms.Panel();
            }
            public System.Windows.Forms.Panel myPanel;
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
