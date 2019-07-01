using iqbal_russian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iqbal_Russian_Roullete
{
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            (new Russian()).Show();
            this.Hide();
        }
    }
}
