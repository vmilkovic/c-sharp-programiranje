using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Vrijeme {
    class Vrijeme {
        public Vrijeme() {
            vrijeme = new XmlDocument();
            Osvjezi();
        }

        public void Osvjezi() {
            vrijeme.Load("http://vrijeme.hr/hrvatska_n.xml");
            DohvatiPodatke();
        }

        private void DohvatiPodatke() {
            podaci = new List<VrijemePodatak>();

            XmlNodeList gradovi = vrijeme.GetElementsByTagName("Grad");
            foreach(XmlNode grad in gradovi) {
                podaci.Add(new VrijemePodatak(
                    grad["GradIme"].InnerText,
                    grad["Podatci"]["Temp"].InnerText,
                    grad["Podatci"]["Vlaga"].InnerText,
                    grad["Podatci"]["Tlak"].InnerText
                ));
            }
        }

        public VrijemePodatak DohvatiPodatkeZaGrad(string grad) {
            return
                (from podatak in podaci
                 where podatak.Grad == grad
                 select podatak).First();
        }

        public IEnumerable<string> DohvatiGradove() {
            return
                from podatak in podaci
                orderby podatak.Grad
                select podatak.Grad;
        }

        public IEnumerable<string> DohvatiNajtoplije() {
            return
                (from podatak in podaci
                 orderby podatak.Temperatura descending
                 select podatak.Grad + ", " + podatak.Temperatura + " °C").Take(5);
        }

        public IEnumerable<string> DohvatiNajhladnije() {
            return
                (from podatak in podaci
                 orderby podatak.Temperatura
                 select podatak.Grad + ", " + podatak.Temperatura + " °C").Take(5);
        }

        private List<VrijemePodatak> podaci;
        private XmlDocument vrijeme;
    }
}
