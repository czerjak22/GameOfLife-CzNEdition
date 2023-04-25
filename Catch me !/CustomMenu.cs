using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catch_me__
{
    public partial class CustomMenu : UserControl
    {
        SoundManager sfx;
        public CustomMenu(SoundManager s)
        {
            sfx= s;
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            sfx.PlayClick();
            var p = Parent.Controls.OfType<MainMenu>().FirstOrDefault();

            if (p != null) p.Visible = true;
        }

        

        private void CustomMenu_Load(object sender, EventArgs e)
        {
            panelCellActive.BackColor = GlobalVar.CellActive;
            panelCellInactive.BackColor = GlobalVar.CellInactive;
            panelBorder.BackColor = GlobalVar.Border;
            panelCellInitial.BackColor = GlobalVar.InitCell;

        }

        private void panelcellActive_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorPicker.ShowDialog())
            {
                panelCellActive.BackColor = colorPicker.Color;
                GlobalVar.CellActive=colorPicker.Color;
            }

           
        }

        private void panelBorder_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorPicker.ShowDialog())
            {
                panelBorder.BackColor = colorPicker.Color;
                GlobalVar.Border = colorPicker.Color;
            }
        }

        private void panelCellInactive_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorPicker.ShowDialog())
            {
                panelCellInactive.BackColor = colorPicker.Color;
                GlobalVar.CellInactive = colorPicker.Color;
            }

        }

        private void panelCellInitial_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorPicker.ShowDialog())
            {
                panelCellInitial.BackColor = colorPicker.Color;
                GlobalVar.InitCell = colorPicker.Color;
            }
        }
    }
}
