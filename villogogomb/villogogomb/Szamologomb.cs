using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace villogogomb
{
    internal class Szamologomb : Button
    {
        int szam = 1;
        public Szamologomb()
        {
            Height = 20;
            Width = 20;
            Click += Szamologomb_Click;
            szam = 1;
            Text = szam.ToString();
            
        }

        private void Szamologomb_Click(object? sender, EventArgs e)
        {
            szam++;
            if (szam == 6) 
            { 
                szam = 1;
            }
            Text = szam.ToString();
        }
    }
}
