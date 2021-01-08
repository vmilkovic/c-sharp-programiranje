using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrijeme {
    class VrijemePodatak {
        public VrijemePodatak(string grad, string temperatura, string vlaga, string tlak) {
            Grad = grad;
            Temperatura = temperatura;
            Vlaga = vlaga;
            Tlak = tlak;
        }
        public string Grad { get; set; }
        public string Temperatura { get; set; }
        public string Vlaga { get; set; }
        public string Tlak { get; set; }
    }
}
