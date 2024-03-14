using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villogogomb
{
    internal class Villogogomb : Button
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public Villogogomb()
        {
            BackColor = Color.Gray;
            MouseEnter += Villogogomb_MouseEnter;
            //MouseLeave += Villogogomb_MouseLeave;
            t.Tick += T_Tick;

        }

        private void T_Tick(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
            t.Stop();
        }

        private void Villogogomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void Villogogomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.DarkTurquoise;
            t.Interval = 1000;
            t.Start();
        }
    }
}
