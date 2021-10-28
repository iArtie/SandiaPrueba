using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial.Forms
{
    public partial class GestionActivoFijo : Form
    {
        public GestionActivoFijo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FmdActivoFijo fmd = new FmdActivoFijo();
            fmd.Show();
        }
    }
}
