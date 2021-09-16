using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
            //le prenom
        {
            textBoxPrenom.Text = String.Concat(textBoxPrenom.Text.Where(char.IsLetter));
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            textBoxNom.Text = String.Concat(textBoxNom.Text.Where(char.IsLetter));
        }

        private void labelNomUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
