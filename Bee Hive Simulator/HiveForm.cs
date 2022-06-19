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
    public partial class HiveForm : Form
    {
        public Renderer Renderer { get; set; }
        
        public HiveForm()
        {
            InitializeComponent();
            //pictureHiveInside.BackgroundImageLayout = ImageLayout.Stretch;

            BackgroundImage = Renderer.ResizeImage(
               Properties.Resources.Hive__inside_,
               ClientRectangle.Width,
               ClientRectangle.Height);
        }

        private void HiveForm_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void HiveForm_Paint(object sender, PaintEventArgs e)
        {
            Renderer.PaintHive(e.Graphics);
        }

       
    }
}
