using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tp2_1
{
    public partial class frmListe : Form
    {
        public frmListe()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
              this.Close();
        }

        private void frmListe_Load(object sender, EventArgs e)
        {
            int i;
            txtliste.Clear();
            for (i = 0; i < frmprincipale.nbClient; i++) {
                txtliste.Text += frmprincipale.identifie(i) + Environment.NewLine;
            }
        }
    }
}
