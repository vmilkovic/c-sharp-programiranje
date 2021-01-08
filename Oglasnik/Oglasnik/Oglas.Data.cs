using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik {
    partial class Oglas {


        public string Naslov { get; set; }

        public string Tekst { get; set; }

        public List<string> Oglasi { get; set; }
        public List<string> SlikovniOglasi { get; set; }
        public List<string> VideoOglasi { get; set; }

        public Boolean Slika { get; set; }

        public Boolean Video { get; set; }

        protected string naslov;
        protected string tekst;
        private List<string> oglasi;
        private List<string> slikovniOglasi;
        private List<string> videoOglasi;
        private Boolean slika;
        private Boolean video;
    }

}
