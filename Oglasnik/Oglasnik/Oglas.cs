using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oglasnik {
    public partial class Oglas : Form {
        public Oglas() {

            Oglasi  = new List<string>();
            SlikovniOglasi = new List<string>();
            VideoOglasi = new List<string>();
            InitializeComponent();

        }

        private void checkBoxSlika_Click(object sender, EventArgs e) {
            Slika = checkBoxSlika.Checked;
        }

        private void checkBoxVideo_Click(object sender, EventArgs e) {
            Video = checkBoxVideo.Checked;
        }

        public override string ToString() {
            return String.Format("{0}\n{1}\n(nema slike/video)\n\n", Naslov, Tekst);
        }

        private void btnDodaj_Click(object sender, EventArgs e) {

            if (Slika && Video) {
                MessageBox.Show("Nije moguće unijeti oglas koji je slikovni i video");
                return;
            }

            spremiPodatke();

            txtOglasi.ResetText();

            foreach ( string oglas in Oglasi) {
                txtOglasi.AppendText(oglas);
            }
                
               
            foreach( string soglas in SlikovniOglasi) {
                txtOglasi.AppendText(soglas);
            }

            foreach (string voglas in VideoOglasi) {
                txtOglasi.AppendText(voglas);
            }

        }

        private void spremiPodatke() {

            Naslov = txtNaslovOglasa.Text;
            Tekst = txtTekstOglasa.Text;

            if ( Slika ) {

                SlikovniOglas slikovniOglas = new SlikovniOglas();

                slikovniOglas.Naslov = Naslov;
                slikovniOglas.Tekst = Tekst;
                slikovniOglas.Slika = txtSlika.Text;

                SlikovniOglasi.Add(slikovniOglas.ToString());

            } else if (Video) {

                VideoOglas videoOglas = new VideoOglas();

                videoOglas.Naslov = Naslov;
                videoOglas.Tekst = Tekst;
                videoOglas.Video = txtVideo.Text;

                VideoOglasi.Add(videoOglas.ToString());

            } else {

                Naslov = txtNaslovOglasa.Text;
                Tekst = txtTekstOglasa.Text;
                Oglasi.Add(ToString());

            }  

        }
    }
}
