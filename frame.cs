using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frame : UserControl
    {
        Boolean doMove = false;
        public frame()
        {
            InitializeComponent();
        }

        private void frame_MouseDown(object sender, MouseEventArgs e)
        {
            doMove = true;
        }

        private void frame_MouseMove(object sender, MouseEventArgs e)
        {
            if (doMove)
            {
                this.Left=MousePosition.X-(this.Width/2);
                this.Top= MousePosition.Y-(this.Height/2);
            }
        }

        private void frame_MouseUp(object sender, MouseEventArgs e)
        {
            doMove=false;
        }
    }
}
