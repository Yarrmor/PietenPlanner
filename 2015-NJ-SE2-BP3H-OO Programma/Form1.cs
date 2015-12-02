using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    public partial class Form1 : Form
    {
        private Administratie adm;

        public Form1()
        {
            InitializeComponent();

            adm = new Administratie();

            cbProvincie.DataSource = adm.Provincies.OrderBy(provincie => provincie.Naam).ToList();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            adm.VoegToe(tbGemeente.Text, adm.Provincies[cbProvincie.SelectedIndex].Naam, Convert.ToInt16(nudAantalKinderen.Value), Convert.ToInt16(nudX.Value), Convert.ToInt16(nudY.Value));
        }

        private void cbProvincie_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Provincie> provTemp = adm.Provincies.OrderBy(provincie => provincie.Naam).ToList();

            var gemResult = from g in provTemp[cbProvincie.SelectedIndex].Gemeenten orderby g.AantalKinderen ascending select g;

            List<Gemeente> gemeenten = gemResult.ToList();

            lbGemeenten.DataSource = gemeenten;
        }

        private void lbGemeenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
