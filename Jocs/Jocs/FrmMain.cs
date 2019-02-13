using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocs
{
    public partial class FrmMain : Form
    {
        FrmPedra fpedra = null;
        FrmPenjat fpenjat = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void elPenjatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fpenjat == null)
            {
                fpenjat = new FrmPenjat();
                fpenjat.esticTancant += new EventHandler(tancarFormPenjat);
                fpenjat.MdiParent = this;
            }
            fpenjat.Show();
            fpenjat.Focus();
        }

        private void tancarFormPenjat(object sender, EventArgs e)
        {
            fpenjat = null;
        }

        private void pedraPaperTisoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fpedra == null)
            {
                fpedra = new FrmPedra();
                fpedra.esticTancant += new EventHandler(tancarFormPedra);
                fpedra.MdiParent = this;
            }
            fpedra.Show();
            fpedra.Focus();
        }

        private void tancarFormPedra(object sender, EventArgs e)
        {
            fpenjat = null;
        }
    }
}
