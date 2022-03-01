using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PripremaZaProvjeruZnanja
{
    public partial class lbl : Form
    {
        List<Vozilo> ListaVozila = new List<Vozilo>();
        public lbl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo(cmbVrsta.Text, txtMarka.Text, txtNaziv.Text, dtpGodPro.Value, trckSnaga.Value);
            ListaVozila.Add(vozilo);
            MessageBox.Show("Unos je uspješan!", "Obavijest", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            rtbIspis.Clear();
            foreach (Vozilo vozilo in ListaVozila) 
            {
                rtbIspis.AppendText(vozilo.ToString());
            }
        }

        private void trckSnaga_Scroll(object sender, EventArgs e)
        {
            lblSnaga.Text = Convert.ToString(trckSnaga.Value);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

         
        }
    }
}
