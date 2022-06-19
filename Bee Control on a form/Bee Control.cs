using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bee_Control_on_a_form
{
    public class BeeControl:PictureBox
    {
        private Timer animationTimer;

        public BeeControl()
        {
            animationTimer = new Timer()
            {Interval = 150};

            animationTimer.Tick += new EventHandler(animationTimer_Tick);
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            animationTimer.Start();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
                animationTimer.Dispose();
        }

        private int Cell = 0;
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Cell++;
            switch (Cell)
            {
                case 1: BackgroundImage = Properties.Resources.Bee_animation_1; break;
                case 2: BackgroundImage = Properties.Resources.Bee_animation_2; break;
                case 3: BackgroundImage = Properties.Resources.Bee_animation_3; break;
                case 4: BackgroundImage = Properties.Resources.Bee_animation_4; break;
                case 5: BackgroundImage = Properties.Resources.Bee_animation_3; break;
                default: BackgroundImage = Properties.Resources.Bee_animation_2;
                    Cell = 0;
                    break;
            }
        }
    }
}
