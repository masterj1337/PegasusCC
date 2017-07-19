using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pegasus
{
    public partial class home : Form
    {
        //These are default, you broke shit touching these last time.
        public home()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void PegasusName_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_HLabel_Click(object sender, EventArgs e)
        {

        }
        //Custom
        //Move UI
        Bunifu.Framework.UI.Drag drag = new Bunifu.Framework.UI.Drag();

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag.Grab(this);
        }

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag.Release();
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            drag.MoveObject();
        }
        //Exit Application
        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        //Navbutton Clicks

        private void DashboardButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void ToolwatchButton_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
