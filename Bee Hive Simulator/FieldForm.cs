using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bee_Hive_Simulator
{
    public partial class FieldForm : Form
    {
        public Renderer Renderer { get; set; }
        
        public FieldForm()
        {
            InitializeComponent();
            //pictureHiveOutside.BackColor = System.Drawing.Color.Transparent;
            //pictureHiveOutside.BackgroundImageLayout = ImageLayout.Stretch;
            //pictureHiveOutside.BackgroundImage = Properties.Resources.Hive__outside_;
            //pictureHiveOutside.BringToFront();
        }

        private void FieldForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void FieldForm_Paint(object sender, PaintEventArgs e)
        {
            Renderer.PaintField(e.Graphics);
        }

       
       
    }
}
