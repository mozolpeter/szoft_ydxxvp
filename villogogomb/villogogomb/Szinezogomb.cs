using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Villogogomb
{
    internal class Szinezogomb : Button
    {
        public Szinezogomb()
        {
            Height = 20;
            Width = 20;
            Click += Szinezogomb_Click;
        }

        private void Szinezogomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Turquoise;
        }
    }
}
