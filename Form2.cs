using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_zenix_notepad
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InstalledFontCollection col = new InstalledFontCollection();
            foreach (FontFamily fa in col.Families)
            {
                lbox_font.Items.Add(fa.Name);   
            }
        }
    }
}
