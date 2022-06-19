using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bee_Control_on_a_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        BeeControl beeControl = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (beeControl == null)
            {
                beeControl = new BeeControl()
                    {Location = new Point(100,100),};
                Controls.Add(beeControl);
            }
            else
            {
                using (beeControl)
                {
                    Controls.Remove(beeControl);
                }
                beeControl = null;
            }
            
        }
    }
}
