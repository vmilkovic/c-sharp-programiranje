using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vrijeme {
    public partial class VrijemeForm : Form {
        Vrijeme vrijeme;
        public VrijemeForm() {
            InitializeComponent();
            vrijeme = new Vrijeme();
        }

        private void formMain_Load(object sender, EventArgs e) {
            /*foreach (var grad in vrijeme.DohvatiGradove()) {
                cbGradovi.Items.Add(grad);
            }*/
            // ista stvar
            cbGradovi.Items.AddRange(vrijeme.DohvatiGradove().ToArray());
            lbNajtopliji.Items.AddRange(vrijeme.DohvatiNajtoplije().ToArray());
            lbNajhladniji.Items.AddRange(vrijeme.DohvatiNajhladnije().ToArray());
        }

        private void cbGradovi_TextChanged(object sender, EventArgs e) {
            //MessageBox.Show(cbGradovi.Text);
            var podaci = vrijeme.DohvatiPodatkeZaGrad(cbGradovi.Text);
            OsvjeziPrikaz();
        }

        private void tmrOsvjezi_Tick(object sender, EventArgs e) {
            vrijeme.Osvjezi();
            OsvjeziPrikaz();
        }

        private void OsvjeziPrikaz() {
            lbNajhladniji.Items.Clear();
            lbNajtopliji.Items.Clear();
            lbNajtopliji.Items.AddRange(vrijeme.DohvatiNajtoplije().ToArray());
            lbNajhladniji.Items.AddRange(vrijeme.DohvatiNajhladnije().ToArray());
            if(cbGradovi.Text != "") {
                var podaci = vrijeme.DohvatiPodatkeZaGrad(cbGradovi.Text);
                lblGrad.Text = podaci.Grad;
                lblTemperatura.Text = podaci.Temperatura.ToString() + " °C";
                lblVlaga.Text = podaci.Vlaga.ToString() + " %";
                lblTlak.Text = podaci.Tlak.ToString() + " hPa";
            }
        }
    }
}
