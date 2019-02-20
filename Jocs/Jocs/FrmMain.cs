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
            if (obert_finestra("FrmPedra") == false)
            {
                FrmPedra pedra = new FrmPedra();
                pedra.MdiParent = this;
                pedra.Show();
            }
        }

        Boolean obert_finestra(String xnom_frm)
        {

            Boolean xb = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name.Equals(xnom_frm))
                {
                    xb = true;
                }
            }

            return xb;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
