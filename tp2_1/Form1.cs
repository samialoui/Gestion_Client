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
       
    public partial class frmprincipale : Form
    {
        //Client[] tabClient = new Client[100];
        public static Client[] c;
        public static int nbClient = 0;

        public frmprincipale()
        {
            InitializeComponent();
            c = new Client[10];
            
        }

        private void btnLister_Click(object sender, EventArgs e)
        {
            frmListe frm = new frmListe();
            frm.Show();

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            if (estTexte(txtNom.Text.Trim()) == -1 || (estTexte(txtPrenom.Text.Trim()) == -1) || (estNombre(txtAge.Text.Trim()) == -1))
            {
                MessageBox.Show("Saisie incorrecte, verifier les champs Nom, Prenom et Age");
                if (estNombre(txtAge.Text.Trim()) == -1)
                {
                    txtAge.ForeColor = System.Drawing.Color.Red;
                    txtAge.Focus();
                }

                
                if (estTexte(txtPrenom.Text.Trim()) == -1)
                {
                    txtPrenom.ForeColor = System.Drawing.Color.Red;
                    txtPrenom.Focus();
                }

                if (estTexte(txtNom.Text.Trim()) == -1)
                {
                    txtNom.ForeColor = System.Drawing.Color.Red;
                    txtNom.Focus();
                }
                
                
            }
            else
            {

                Client cl = new Client(txtNom.Text, txtPrenom.Text, Int32.Parse(txtAge.Text));
                c[nbClient] = cl;
                nbClient++;
                txtNom.Clear();
                txtPrenom.Clear();
                txtAge.Clear();

            }
        }

        public static string identifie(int i) { return c[i].identifie(); }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtAge.Clear();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

   private int estTexte(string  text)
        {
            int i = 0;
            int Letter = 1;
            while (i < text.Length && (Letter != -1))
            {
                if (!char.IsLetter(text[i])) { Letter = -1; }
                else i++;
            }

          return (Letter);
       }

   private int estNombre(string text)
   {
       int i = 0;
       int estNombre = 1;
       while (i < text.Length && (estNombre != -1))
       {
           if (!char.IsNumber(text[i])) { estNombre = -1; }
           else i++;
       }

       return (estNombre);
   }

   
  
    }
}